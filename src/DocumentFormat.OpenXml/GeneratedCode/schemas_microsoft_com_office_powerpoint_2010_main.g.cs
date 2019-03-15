// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Office2010.Drawing;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
/// <summary>
/// <para>Defines the NonVisualContentPartProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:nvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NonVisualDrawingProperties &lt;p14:cNvPr></description></item>
///<item><description>NonVisualInkContentPartProperties &lt;p14:cNvContentPartPr></description></item>
///<item><description>ApplicationNonVisualDrawingProperties &lt;p14:nvPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NonVisualDrawingProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NonVisualInkContentPartProperties), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ApplicationNonVisualDrawingProperties), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "nvContentPartPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualContentPartProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12831;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class.
    /// </summary>
    public NonVisualContentPartProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualContentPartProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualContentPartProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualContentPartProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: p14:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(0)]
    public NonVisualDrawingProperties NonVisualDrawingProperties
	{
        get => GetElement<NonVisualDrawingProperties>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> NonVisualInkContentPartProperties.</para>
    /// <para> Represents the following element tag in the schema: p14:cNvContentPartPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(1)]
    public NonVisualInkContentPartProperties NonVisualInkContentPartProperties
	{
        get => GetElement<NonVisualInkContentPartProperties>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> ApplicationNonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: p14:nvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(2)]
    public ApplicationNonVisualDrawingProperties ApplicationNonVisualDrawingProperties
	{
        get => GetElement<ApplicationNonVisualDrawingProperties>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualContentPartProperties>(deep);

}
/// <summary>
/// <para>Defines the Transform2D Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:xfrm.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Offset &lt;a:off></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Extents &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Offset))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extents))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "xfrm")]
[Id(ElementTypeIdConst)]
public partial class Transform2D : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12832;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Rotation.</para>
    /// <para>Represents the following attribute in the schema: rot </para>
    /// </summary>
    [SchemaAttr(0, "rot")]
    [Index(0)]
    public Int32Value Rotation { get; set; }
	
    /// <summary>
    /// <para> Horizontal Flip.</para>
    /// <para>Represents the following attribute in the schema: flipH </para>
    /// </summary>
    [SchemaAttr(0, "flipH")]
    [Index(1)]
    public BooleanValue HorizontalFlip { get; set; }
	
    /// <summary>
    /// <para> Vertical Flip.</para>
    /// <para>Represents the following attribute in the schema: flipV </para>
    /// </summary>
    [SchemaAttr(0, "flipV")]
    [Index(2)]
    public BooleanValue VerticalFlip { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Transform2D class.
    /// </summary>
    public Transform2D():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Transform2D class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Transform2D(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Offset.</para>
    /// <para> Represents the following element tag in the schema: a:off </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.Offset Offset
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> Extents.</para>
    /// <para> Represents the following element tag in the schema: a:ext </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.Extents Extents
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);

}
/// <summary>
/// <para>Defines the ExtensionListModify Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Presentation.Extension &lt;p:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Presentation.Extension))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "extLst")]
[Id(ElementTypeIdConst)]
public partial class ExtensionListModify : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12833;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Modify.</para>
    /// <para>Represents the following attribute in the schema: mod </para>
    /// </summary>
    [SchemaAttr(0, "mod")]
    [Index(0)]
    public BooleanValue Modify { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ExtensionListModify class.
    /// </summary>
    public ExtensionListModify():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ExtensionListModify class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionListModify(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionListModify class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionListModify(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionListModify class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExtensionListModify(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionListModify>(deep);

}
/// <summary>
/// <para>Defines the Media Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:media.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MediaTrim &lt;p14:trim></description></item>
///<item><description>MediaFade &lt;p14:fade></description></item>
///<item><description>MediaBookmarkList &lt;p14:bmkLst></description></item>
///<item><description>ExtensionList &lt;p14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MediaTrim), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MediaFade), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MediaBookmarkList), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "media")]
[Id(ElementTypeIdConst)]
public partial class Media : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12834;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Embedded Picture Reference.</para>
    /// <para>Represents the following attribute in the schema: r:embed </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "embed")]
    [Index(0)]
    public StringValue Embed { get; set; }
	
    /// <summary>
    /// <para> Linked Picture Reference.</para>
    /// <para>Represents the following attribute in the schema: r:link </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "link")]
    [Index(1)]
    public StringValue Link { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Media class.
    /// </summary>
    public Media():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Media class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Media(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Media class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Media(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Media class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Media(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> MediaTrim.</para>
    /// <para> Represents the following element tag in the schema: p14:trim </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(0)]
    public MediaTrim MediaTrim
	{
        get => GetElement<MediaTrim>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> MediaFade.</para>
    /// <para> Represents the following element tag in the schema: p14:fade </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(1)]
    public MediaFade MediaFade
	{
        get => GetElement<MediaFade>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> MediaBookmarkList.</para>
    /// <para> Represents the following element tag in the schema: p14:bmkLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(2)]
    public MediaBookmarkList MediaBookmarkList
	{
        get => GetElement<MediaBookmarkList>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: p14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(3)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Media>(deep);

}
/// <summary>
/// <para>Defines the VortexTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:vortex.</para>
/// </summary>

[SchemaAttr(49, "vortex")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class VortexTransition : SideDirectionTransitionType
{
    internal const int ElementTypeIdConst = 12835;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the VortexTransition class.
    /// </summary>
    public VortexTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VortexTransition>(deep);

}
/// <summary>
/// <para>Defines the PanTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:pan.</para>
/// </summary>

[SchemaAttr(49, "pan")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PanTransition : SideDirectionTransitionType
{
    internal const int ElementTypeIdConst = 12846;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the PanTransition class.
    /// </summary>
    public PanTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PanTransition>(deep);

}
/// <summary>
/// Defines the SideDirectionTransitionType class.
/// </summary>


public abstract partial class SideDirectionTransitionType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Direction.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues> Direction { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the SideDirectionTransitionType class.
    /// </summary>
    protected SideDirectionTransitionType(){}
    
    
    
}
/// <summary>
/// <para>Defines the SwitchTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:switch.</para>
/// </summary>

[SchemaAttr(49, "switch")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SwitchTransition : LeftRightDirectionTransitionType
{
    internal const int ElementTypeIdConst = 12836;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SwitchTransition class.
    /// </summary>
    public SwitchTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SwitchTransition>(deep);

}
/// <summary>
/// <para>Defines the FlipTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:flip.</para>
/// </summary>

[SchemaAttr(49, "flip")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FlipTransition : LeftRightDirectionTransitionType
{
    internal const int ElementTypeIdConst = 12837;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the FlipTransition class.
    /// </summary>
    public FlipTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FlipTransition>(deep);

}
/// <summary>
/// <para>Defines the FerrisTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:ferris.</para>
/// </summary>

[SchemaAttr(49, "ferris")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FerrisTransition : LeftRightDirectionTransitionType
{
    internal const int ElementTypeIdConst = 12843;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the FerrisTransition class.
    /// </summary>
    public FerrisTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FerrisTransition>(deep);

}
/// <summary>
/// <para>Defines the GalleryTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:gallery.</para>
/// </summary>

[SchemaAttr(49, "gallery")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GalleryTransition : LeftRightDirectionTransitionType
{
    internal const int ElementTypeIdConst = 12844;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the GalleryTransition class.
    /// </summary>
    public GalleryTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GalleryTransition>(deep);

}
/// <summary>
/// <para>Defines the ConveyorTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:conveyor.</para>
/// </summary>

[SchemaAttr(49, "conveyor")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConveyorTransition : LeftRightDirectionTransitionType
{
    internal const int ElementTypeIdConst = 12845;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the ConveyorTransition class.
    /// </summary>
    public ConveyorTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConveyorTransition>(deep);

}
/// <summary>
/// Defines the LeftRightDirectionTransitionType class.
/// </summary>


public abstract partial class LeftRightDirectionTransitionType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionLeftRightDirectionTypeValues> Direction { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the LeftRightDirectionTransitionType class.
    /// </summary>
    protected LeftRightDirectionTransitionType(){}
    
    
    
}
/// <summary>
/// <para>Defines the RippleTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:ripple.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "ripple")]
[Id(ElementTypeIdConst)]
public partial class RippleTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12838;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public StringValue Direction { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the RippleTransition class.
    /// </summary>
    public RippleTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RippleTransition>(deep);

}
/// <summary>
/// <para>Defines the HoneycombTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:honeycomb.</para>
/// </summary>

[SchemaAttr(49, "honeycomb")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HoneycombTransition : EmptyType
{
    internal const int ElementTypeIdConst = 12839;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the HoneycombTransition class.
    /// </summary>
    public HoneycombTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HoneycombTransition>(deep);

}
/// <summary>
/// <para>Defines the FlashTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:flash.</para>
/// </summary>

[SchemaAttr(49, "flash")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FlashTransition : EmptyType
{
    internal const int ElementTypeIdConst = 12850;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the FlashTransition class.
    /// </summary>
    public FlashTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FlashTransition>(deep);

}
/// <summary>
/// Defines the EmptyType class.
/// </summary>


public abstract partial class EmptyType : OpenXmlLeafElement
{
        
    
    
    
    
    /// <summary>
    /// Initializes a new instance of the EmptyType class.
    /// </summary>
    protected EmptyType(){}
    
    
    
}
/// <summary>
/// <para>Defines the PrismTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:prism.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "prism")]
[Id(ElementTypeIdConst)]
public partial class PrismTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12840;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues> Direction { get; set; }
	
    /// <summary>
    /// <para> isContent.</para>
    /// <para>Represents the following attribute in the schema: isContent </para>
    /// </summary>
    [SchemaAttr(0, "isContent")]
    [Index(1)]
    public BooleanValue IsContent { get; set; }
	
    /// <summary>
    /// <para> isInverted.</para>
    /// <para>Represents the following attribute in the schema: isInverted </para>
    /// </summary>
    [SchemaAttr(0, "isInverted")]
    [Index(2)]
    public BooleanValue IsInverted { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PrismTransition class.
    /// </summary>
    public PrismTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrismTransition>(deep);

}
/// <summary>
/// <para>Defines the DoorsTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:doors.</para>
/// </summary>

[SchemaAttr(49, "doors")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DoorsTransition : OrientationTransitionType
{
    internal const int ElementTypeIdConst = 12841;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the DoorsTransition class.
    /// </summary>
    public DoorsTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DoorsTransition>(deep);

}
/// <summary>
/// <para>Defines the WindowTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:window.</para>
/// </summary>

[SchemaAttr(49, "window")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class WindowTransition : OrientationTransitionType
{
    internal const int ElementTypeIdConst = 12842;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the WindowTransition class.
    /// </summary>
    public WindowTransition():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WindowTransition>(deep);

}
/// <summary>
/// Defines the OrientationTransitionType class.
/// </summary>


public abstract partial class OrientationTransitionType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Transition Direction.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues> Direction { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the OrientationTransitionType class.
    /// </summary>
    protected OrientationTransitionType(){}
    
    
    
}
/// <summary>
/// <para>Defines the GlitterTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:glitter.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "glitter")]
[Id(ElementTypeIdConst)]
public partial class GlitterTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12847;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues> Direction { get; set; }
	
    /// <summary>
    /// <para> pattern.</para>
    /// <para>Represents the following attribute in the schema: pattern </para>
    /// </summary>
    [SchemaAttr(0, "pattern")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionPatternValues> Pattern { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the GlitterTransition class.
    /// </summary>
    public GlitterTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GlitterTransition>(deep);

}
/// <summary>
/// <para>Defines the WarpTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:warp.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "warp")]
[Id(ElementTypeIdConst)]
public partial class WarpTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12848;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Direction.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues> Direction { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WarpTransition class.
    /// </summary>
    public WarpTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WarpTransition>(deep);

}
/// <summary>
/// <para>Defines the FlythroughTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:flythrough.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "flythrough")]
[Id(ElementTypeIdConst)]
public partial class FlythroughTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12849;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues> Direction { get; set; }
	
    /// <summary>
    /// <para> hasBounce.</para>
    /// <para>Represents the following attribute in the schema: hasBounce </para>
    /// </summary>
    [SchemaAttr(0, "hasBounce")]
    [Index(1)]
    public BooleanValue HasBounce { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the FlythroughTransition class.
    /// </summary>
    public FlythroughTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FlythroughTransition>(deep);

}
/// <summary>
/// <para>Defines the ShredTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:shred.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "shred")]
[Id(ElementTypeIdConst)]
public partial class ShredTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12851;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> pattern.</para>
    /// <para>Represents the following attribute in the schema: pattern </para>
    /// </summary>
    [SchemaAttr(0, "pattern")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionShredPatternValues> Pattern { get; set; }
	
    /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues> Direction { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ShredTransition class.
    /// </summary>
    public ShredTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShredTransition>(deep);

}
/// <summary>
/// <para>Defines the RevealTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:reveal.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "reveal")]
[Id(ElementTypeIdConst)]
public partial class RevealTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12852;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> thruBlk.</para>
    /// <para>Represents the following attribute in the schema: thruBlk </para>
    /// </summary>
    [SchemaAttr(0, "thruBlk")]
    [Index(0)]
    public BooleanValue ThroughBlack { get; set; }
	
    /// <summary>
    /// <para> dir.</para>
    /// <para>Represents the following attribute in the schema: dir </para>
    /// </summary>
    [SchemaAttr(0, "dir")]
    [Index(1)]
    public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionLeftRightDirectionTypeValues> Direction { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the RevealTransition class.
    /// </summary>
    public RevealTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevealTransition>(deep);

}
/// <summary>
/// <para>Defines the WheelReverseTransition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:wheelReverse.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "wheelReverse")]
[Id(ElementTypeIdConst)]
public partial class WheelReverseTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12853;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Spokes.</para>
    /// <para>Represents the following attribute in the schema: spokes </para>
    /// </summary>
    [SchemaAttr(0, "spokes")]
    [Index(0)]
    public UInt32Value Spokes { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WheelReverseTransition class.
    /// </summary>
    public WheelReverseTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WheelReverseTransition>(deep);

}
/// <summary>
/// <para>Defines the BookmarkTarget Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:bmkTgt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "bmkTgt")]
[Id(ElementTypeIdConst)]
public partial class BookmarkTarget : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12854;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    [Index(0)]
    public UInt32Value ShapeId { get; set; }
	
    /// <summary>
    /// <para> bmkName.</para>
    /// <para>Represents the following attribute in the schema: bmkName </para>
    /// </summary>
    [SchemaAttr(0, "bmkName")]
    [Index(1)]
    public StringValue BookmarkName { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the BookmarkTarget class.
    /// </summary>
    public BookmarkTarget():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BookmarkTarget>(deep);

}
/// <summary>
/// <para>Defines the SectionProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:sectionPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SectionOld &lt;p14:section></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SectionOld), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "sectionPr")]
[Id(ElementTypeIdConst)]
public partial class SectionProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12855;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SectionProperties class.
    /// </summary>
    public SectionProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SectionProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SectionProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionProperties>(deep);

}
/// <summary>
/// <para>Defines the SectionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:sectionLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Section &lt;p14:section></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Section), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "sectionLst")]
[Id(ElementTypeIdConst)]
public partial class SectionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12856;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SectionList class.
    /// </summary>
    public SectionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SectionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SectionList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionList>(deep);

}
/// <summary>
/// <para>Defines the BrowseMode Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:browseMode.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "browseMode")]
[Id(ElementTypeIdConst)]
public partial class BrowseMode : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12857;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> showStatus.</para>
    /// <para>Represents the following attribute in the schema: showStatus </para>
    /// </summary>
    [SchemaAttr(0, "showStatus")]
    [Index(0)]
    public BooleanValue ShowStatus { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the BrowseMode class.
    /// </summary>
    public BrowseMode():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrowseMode>(deep);

}
/// <summary>
/// <para>Defines the LaserColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:laserClr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HslColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SystemColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetColor))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "laserClr")]
[Id(ElementTypeIdConst)]
public partial class LaserColor : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12858;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the LaserColor class.
    /// </summary>
    public LaserColor():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LaserColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LaserColor(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LaserColor class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LaserColor(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LaserColor class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LaserColor(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> RGB Color Model - Percentage Variant.</para>
    /// <para> Represents the following element tag in the schema: a:scrgbClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage RgbColorModelPercentage
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> RGB Color Model - Hex Variant.</para>
    /// <para> Represents the following element tag in the schema: a:srgbClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.RgbColorModelHex RgbColorModelHex
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> Hue, Saturation, Luminance Color Model.</para>
    /// <para> Represents the following element tag in the schema: a:hslClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.HslColor HslColor
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> System Color.</para>
    /// <para> Represents the following element tag in the schema: a:sysClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(3)]
    public DocumentFormat.OpenXml.Drawing.SystemColor SystemColor
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Scheme Color.</para>
    /// <para> Represents the following element tag in the schema: a:schemeClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(4)]
    public DocumentFormat.OpenXml.Drawing.SchemeColor SchemeColor
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> Preset Color.</para>
    /// <para> Represents the following element tag in the schema: a:prstClr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(5)]
    public DocumentFormat.OpenXml.Drawing.PresetColor PresetColor
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LaserColor>(deep);

}
/// <summary>
/// <para>Defines the DefaultImageDpi Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:defaultImageDpi.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "defaultImageDpi")]
[Id(ElementTypeIdConst)]
public partial class DefaultImageDpi : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12859;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public UInt32Value Val { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DefaultImageDpi class.
    /// </summary>
    public DefaultImageDpi():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultImageDpi>(deep);

}
/// <summary>
/// <para>Defines the DiscardImageEditData Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:discardImageEditData.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "discardImageEditData")]
[Id(ElementTypeIdConst)]
public partial class DiscardImageEditData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12860;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the DiscardImageEditData class.
    /// </summary>
    public DiscardImageEditData():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiscardImageEditData>(deep);

}
/// <summary>
/// <para>Defines the ShowMediaControls Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:showMediaCtrls.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "showMediaCtrls")]
[Id(ElementTypeIdConst)]
public partial class ShowMediaControls : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12861;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ShowMediaControls class.
    /// </summary>
    public ShowMediaControls():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowMediaControls>(deep);

}
/// <summary>
/// <para>Defines the LaserTraceList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:laserTraceLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TracePointList &lt;p14:tracePtLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TracePointList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "laserTraceLst")]
[Id(ElementTypeIdConst)]
public partial class LaserTraceList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12862;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the LaserTraceList class.
    /// </summary>
    public LaserTraceList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LaserTraceList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LaserTraceList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LaserTraceList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LaserTraceList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LaserTraceList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LaserTraceList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LaserTraceList>(deep);

}
/// <summary>
/// <para>Defines the CreationId Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:creationId.</para>
/// </summary>

[SchemaAttr(49, "creationId")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CreationId : RandomIdType
{
    internal const int ElementTypeIdConst = 12863;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the CreationId class.
    /// </summary>
    public CreationId():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CreationId>(deep);

}
/// <summary>
/// <para>Defines the ModificationId Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:modId.</para>
/// </summary>

[SchemaAttr(49, "modId")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ModificationId : RandomIdType
{
    internal const int ElementTypeIdConst = 12864;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the ModificationId class.
    /// </summary>
    public ModificationId():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModificationId>(deep);

}
/// <summary>
/// Defines the RandomIdType class.
/// </summary>


public abstract partial class RandomIdType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public UInt32Value Val { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the RandomIdType class.
    /// </summary>
    protected RandomIdType(){}
    
    
    
}
/// <summary>
/// <para>Defines the ShowEventRecordList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:showEvtLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TriggerEventRecord &lt;p14:triggerEvt></description></item>
///<item><description>PlayEventRecord &lt;p14:playEvt></description></item>
///<item><description>StopEventRecord &lt;p14:stopEvt></description></item>
///<item><description>PauseEventRecord &lt;p14:pauseEvt></description></item>
///<item><description>ResumeEventRecord &lt;p14:resumeEvt></description></item>
///<item><description>SeekEventRecord &lt;p14:seekEvt></description></item>
///<item><description>NullEventRecord &lt;p14:nullEvt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TriggerEventRecord), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PlayEventRecord), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(StopEventRecord), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PauseEventRecord), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ResumeEventRecord), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SeekEventRecord), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NullEventRecord), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "showEvtLst")]
[Id(ElementTypeIdConst)]
public partial class ShowEventRecordList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12865;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ShowEventRecordList class.
    /// </summary>
    public ShowEventRecordList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShowEventRecordList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShowEventRecordList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShowEventRecordList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShowEventRecordList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShowEventRecordList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShowEventRecordList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
    
        /// <summary>
    /// <para> TriggerEventRecord.</para>
    /// <para> Represents the following element tag in the schema: p14:triggerEvt </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(0)]
    public TriggerEventRecord TriggerEventRecord
	{
        get => GetElement<TriggerEventRecord>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> PlayEventRecord.</para>
    /// <para> Represents the following element tag in the schema: p14:playEvt </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(1)]
    public PlayEventRecord PlayEventRecord
	{
        get => GetElement<PlayEventRecord>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> StopEventRecord.</para>
    /// <para> Represents the following element tag in the schema: p14:stopEvt </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(2)]
    public StopEventRecord StopEventRecord
	{
        get => GetElement<StopEventRecord>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> PauseEventRecord.</para>
    /// <para> Represents the following element tag in the schema: p14:pauseEvt </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(3)]
    public PauseEventRecord PauseEventRecord
	{
        get => GetElement<PauseEventRecord>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> ResumeEventRecord.</para>
    /// <para> Represents the following element tag in the schema: p14:resumeEvt </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(4)]
    public ResumeEventRecord ResumeEventRecord
	{
        get => GetElement<ResumeEventRecord>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> SeekEventRecord.</para>
    /// <para> Represents the following element tag in the schema: p14:seekEvt </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(5)]
    public SeekEventRecord SeekEventRecord
	{
        get => GetElement<SeekEventRecord>(5);
        set => SetElement(5, value);
	}
    
    /// <summary>
    /// <para> NullEventRecord.</para>
    /// <para> Represents the following element tag in the schema: p14:nullEvt </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(6)]
    public NullEventRecord NullEventRecord
	{
        get => GetElement<NullEventRecord>(6);
        set => SetElement(6, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowEventRecordList>(deep);

}
/// <summary>
/// <para>Defines the NonVisualDrawingProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:cNvPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnClick &lt;a:hlinkClick></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.HyperlinkOnHover &lt;a:hlinkHover></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "cNvPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12866;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public UInt32Value Id { get; set; }
	
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(1)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> descr.</para>
    /// <para>Represents the following attribute in the schema: descr </para>
    /// </summary>
    [SchemaAttr(0, "descr")]
    [Index(2)]
    public StringValue Description { get; set; }
	
    /// <summary>
    /// <para> hidden.</para>
    /// <para>Represents the following attribute in the schema: hidden </para>
    /// </summary>
    [SchemaAttr(0, "hidden")]
    [Index(3)]
    public BooleanValue Hidden { get; set; }
	
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    [Index(4)]
    public StringValue Title { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class.
    /// </summary>
    public NonVisualDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> HyperlinkOnClick.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkClick </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick HyperlinkOnClick
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> HyperlinkOnHover.</para>
    /// <para> Represents the following element tag in the schema: a:hlinkHover </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover HyperlinkOnHover
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> NonVisualDrawingPropertiesExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(2)]
    public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList NonVisualDrawingPropertiesExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>(2);
        set => SetElement(2, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);

}
/// <summary>
/// <para>Defines the NonVisualInkContentPartProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:cNvContentPartPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks &lt;a14:cpLocks></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList &lt;a14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "cNvContentPartPr")]
[Id(ElementTypeIdConst)]
public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12867;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> isComment.</para>
    /// <para>Represents the following attribute in the schema: isComment </para>
    /// </summary>
    [SchemaAttr(0, "isComment")]
    [Index(0)]
    public BooleanValue IsComment { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class.
    /// </summary>
    public NonVisualInkContentPartProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NonVisualInkContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NonVisualInkContentPartProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NonVisualInkContentPartProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ContentPartLocks.</para>
    /// <para> Represents the following element tag in the schema: a14:cpLocks </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks ContentPartLocks
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: a14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
    /// </remark>
	[Index(1)]
    public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualInkContentPartProperties>(deep);

}
/// <summary>
/// <para>Defines the ApplicationNonVisualDrawingProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:nvPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Presentation.PlaceholderShape &lt;p:ph></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AudioFromCD &lt;a:audioCd></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.WaveAudioFile &lt;a:wavAudioFile></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AudioFromFile &lt;a:audioFile></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.VideoFromFile &lt;a:videoFile></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.QuickTimeFromFile &lt;a:quickTimeFile></description></item>
///<item><description>DocumentFormat.OpenXml.Presentation.CustomerDataList &lt;p:custDataLst></description></item>
///<item><description>DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingPropertiesExtensionList &lt;p:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Presentation.PlaceholderShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AudioFromCD))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.WaveAudioFile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AudioFromFile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.VideoFromFile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Presentation.CustomerDataList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingPropertiesExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "nvPr")]
[Id(ElementTypeIdConst)]
public partial class ApplicationNonVisualDrawingProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12868;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Is a Photo Album.</para>
    /// <para>Represents the following attribute in the schema: isPhoto </para>
    /// </summary>
    [SchemaAttr(0, "isPhoto")]
    [Index(0)]
    public BooleanValue IsPhoto { get; set; }
	
    /// <summary>
    /// <para> Is User Drawn.</para>
    /// <para>Represents the following attribute in the schema: userDrawn </para>
    /// </summary>
    [SchemaAttr(0, "userDrawn")]
    [Index(1)]
    public BooleanValue UserDrawn { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class.
    /// </summary>
    public ApplicationNonVisualDrawingProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ApplicationNonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ApplicationNonVisualDrawingProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ApplicationNonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ApplicationNonVisualDrawingProperties(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Placeholder Shape.</para>
    /// <para> Represents the following element tag in the schema: p:ph </para>
    /// </summary>
    /// <remark>
    /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.Presentation.PlaceholderShape PlaceholderShape
	{
        get => GetElement<DocumentFormat.OpenXml.Presentation.PlaceholderShape>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationNonVisualDrawingProperties>(deep);

}
/// <summary>
/// <para>Defines the MediaBookmark Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:bmk.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "bmk")]
[Id(ElementTypeIdConst)]
public partial class MediaBookmark : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12869;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    [Index(1)]
    public StringValue Time { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the MediaBookmark class.
    /// </summary>
    public MediaBookmark():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaBookmark>(deep);

}
/// <summary>
/// <para>Defines the MediaTrim Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:trim.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "trim")]
[Id(ElementTypeIdConst)]
public partial class MediaTrim : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12870;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> st.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    [Index(0)]
    public StringValue Start { get; set; }
	
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: end </para>
    /// </summary>
    [SchemaAttr(0, "end")]
    [Index(1)]
    public StringValue End { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the MediaTrim class.
    /// </summary>
    public MediaTrim():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaTrim>(deep);

}
/// <summary>
/// <para>Defines the MediaFade Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:fade.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "fade")]
[Id(ElementTypeIdConst)]
public partial class MediaFade : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12871;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> in.</para>
    /// <para>Represents the following attribute in the schema: in </para>
    /// </summary>
    [SchemaAttr(0, "in")]
    [Index(0)]
    public StringValue InDuration { get; set; }
	
    /// <summary>
    /// <para> out.</para>
    /// <para>Represents the following attribute in the schema: out </para>
    /// </summary>
    [SchemaAttr(0, "out")]
    [Index(1)]
    public StringValue OutDuration { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the MediaFade class.
    /// </summary>
    public MediaFade():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaFade>(deep);

}
/// <summary>
/// <para>Defines the MediaBookmarkList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:bmkLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MediaBookmark &lt;p14:bmk></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MediaBookmark), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "bmkLst")]
[Id(ElementTypeIdConst)]
public partial class MediaBookmarkList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12872;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the MediaBookmarkList class.
    /// </summary>
    public MediaBookmarkList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MediaBookmarkList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MediaBookmarkList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MediaBookmarkList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MediaBookmarkList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MediaBookmarkList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MediaBookmarkList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaBookmarkList>(deep);

}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Presentation.Extension &lt;p:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Presentation.Extension))]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "extLst")]
[Id(ElementTypeIdConst)]
public partial class ExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12873;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);

}
/// <summary>
/// <para>Defines the SectionOld Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:section.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;p14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "section")]
[Id(ElementTypeIdConst)]
public partial class SectionOld : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12874;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> slideIdLst.</para>
    /// <para>Represents the following attribute in the schema: slideIdLst </para>
    /// </summary>
    [SchemaAttr(0, "slideIdLst")]
    [Index(1)]
    public ListValue<UInt32Value> SlideIdList { get; set; }
	
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(2)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SectionOld class.
    /// </summary>
    public SectionOld():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SectionOld class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionOld(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionOld class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionOld(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionOld class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SectionOld(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: p14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(0)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionOld>(deep);

}
/// <summary>
/// <para>Defines the SectionSlideIdListEntry Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:sldId.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "sldId")]
[Id(ElementTypeIdConst)]
public partial class SectionSlideIdListEntry : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12875;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public UInt32Value Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SectionSlideIdListEntry class.
    /// </summary>
    public SectionSlideIdListEntry():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionSlideIdListEntry>(deep);

}
/// <summary>
/// <para>Defines the SectionSlideIdList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:sldIdLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SectionSlideIdListEntry &lt;p14:sldId></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SectionSlideIdListEntry), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "sldIdLst")]
[Id(ElementTypeIdConst)]
public partial class SectionSlideIdList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12876;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SectionSlideIdList class.
    /// </summary>
    public SectionSlideIdList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SectionSlideIdList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionSlideIdList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionSlideIdList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SectionSlideIdList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SectionSlideIdList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SectionSlideIdList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionSlideIdList>(deep);

}
/// <summary>
/// <para>Defines the Section Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:section.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SectionSlideIdList &lt;p14:sldIdLst></description></item>
///<item><description>ExtensionList &lt;p14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SectionSlideIdList), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "section")]
[Id(ElementTypeIdConst)]
public partial class Section : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12877;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(1)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Section class.
    /// </summary>
    public Section():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Section class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Section(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Section class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Section(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Section class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Section(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SectionSlideIdList.</para>
    /// <para> Represents the following element tag in the schema: p14:sldIdLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(0)]
    public SectionSlideIdList SectionSlideIdList
	{
        get => GetElement<SectionSlideIdList>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: p14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Section>(deep);

}
/// <summary>
/// <para>Defines the TracePoint Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:tracePt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "tracePt")]
[Id(ElementTypeIdConst)]
public partial class TracePoint : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12878;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> t.</para>
    /// <para>Represents the following attribute in the schema: t </para>
    /// </summary>
    [SchemaAttr(0, "t")]
    [Index(0)]
    public StringValue Time { get; set; }
	
    /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    [Index(1)]
    public Int64Value XCoordinate { get; set; }
	
    /// <summary>
    /// <para> y.</para>
    /// <para>Represents the following attribute in the schema: y </para>
    /// </summary>
    [SchemaAttr(0, "y")]
    [Index(2)]
    public Int64Value YCoordinate { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TracePoint class.
    /// </summary>
    public TracePoint():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TracePoint>(deep);

}
/// <summary>
/// <para>Defines the TracePointList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:tracePtLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TracePoint &lt;p14:tracePt></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TracePoint), FileFormatVersions.Office2010)]

[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "tracePtLst")]
[Id(ElementTypeIdConst)]
public partial class TracePointList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12879;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the TracePointList class.
    /// </summary>
    public TracePointList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TracePointList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TracePointList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TracePointList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TracePointList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TracePointList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TracePointList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TracePointList>(deep);

}
/// <summary>
/// <para>Defines the TriggerEventRecord Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:triggerEvt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "triggerEvt")]
[Id(ElementTypeIdConst)]
public partial class TriggerEventRecord : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12880;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.TriggerEventValues> Type { get; set; }
	
    /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    [Index(1)]
    public StringValue Time { get; set; }
	
    /// <summary>
    /// <para> objId.</para>
    /// <para>Represents the following attribute in the schema: objId </para>
    /// </summary>
    [SchemaAttr(0, "objId")]
    [Index(2)]
    public UInt32Value ObjectId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TriggerEventRecord class.
    /// </summary>
    public TriggerEventRecord():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TriggerEventRecord>(deep);

}
/// <summary>
/// <para>Defines the PlayEventRecord Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:playEvt.</para>
/// </summary>

[SchemaAttr(49, "playEvt")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PlayEventRecord : MediaPlaybackEventRecordType
{
    internal const int ElementTypeIdConst = 12881;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the PlayEventRecord class.
    /// </summary>
    public PlayEventRecord():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlayEventRecord>(deep);

}
/// <summary>
/// <para>Defines the StopEventRecord Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:stopEvt.</para>
/// </summary>

[SchemaAttr(49, "stopEvt")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class StopEventRecord : MediaPlaybackEventRecordType
{
    internal const int ElementTypeIdConst = 12882;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the StopEventRecord class.
    /// </summary>
    public StopEventRecord():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StopEventRecord>(deep);

}
/// <summary>
/// <para>Defines the PauseEventRecord Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:pauseEvt.</para>
/// </summary>

[SchemaAttr(49, "pauseEvt")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PauseEventRecord : MediaPlaybackEventRecordType
{
    internal const int ElementTypeIdConst = 12883;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the PauseEventRecord class.
    /// </summary>
    public PauseEventRecord():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PauseEventRecord>(deep);

}
/// <summary>
/// <para>Defines the ResumeEventRecord Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:resumeEvt.</para>
/// </summary>

[SchemaAttr(49, "resumeEvt")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ResumeEventRecord : MediaPlaybackEventRecordType
{
    internal const int ElementTypeIdConst = 12884;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the ResumeEventRecord class.
    /// </summary>
    public ResumeEventRecord():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResumeEventRecord>(deep);

}
/// <summary>
/// Defines the MediaPlaybackEventRecordType class.
/// </summary>


public abstract partial class MediaPlaybackEventRecordType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    [Index(0)]
    public StringValue Time { get; set; }
	
    /// <summary>
    /// <para> objId.</para>
    /// <para>Represents the following attribute in the schema: objId </para>
    /// </summary>
    [SchemaAttr(0, "objId")]
    [Index(1)]
    public UInt32Value ObjectId { get; set; }
	

    
    
    
    /// <summary>
    /// Initializes a new instance of the MediaPlaybackEventRecordType class.
    /// </summary>
    protected MediaPlaybackEventRecordType(){}
    
    
    
}
/// <summary>
/// <para>Defines the SeekEventRecord Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:seekEvt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "seekEvt")]
[Id(ElementTypeIdConst)]
public partial class SeekEventRecord : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12885;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    [Index(0)]
    public StringValue Time { get; set; }
	
    /// <summary>
    /// <para> objId.</para>
    /// <para>Represents the following attribute in the schema: objId </para>
    /// </summary>
    [SchemaAttr(0, "objId")]
    [Index(1)]
    public UInt32Value ObjectId { get; set; }
	
    /// <summary>
    /// <para> seek.</para>
    /// <para>Represents the following attribute in the schema: seek </para>
    /// </summary>
    [SchemaAttr(0, "seek")]
    [Index(2)]
    public StringValue Seek { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SeekEventRecord class.
    /// </summary>
    public SeekEventRecord():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeekEventRecord>(deep);

}
/// <summary>
/// <para>Defines the NullEventRecord Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p14:nullEvt.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(49, "nullEvt")]
[Id(ElementTypeIdConst)]
public partial class NullEventRecord : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12886;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> time.</para>
    /// <para>Represents the following attribute in the schema: time </para>
    /// </summary>
    [SchemaAttr(0, "time")]
    [Index(0)]
    public StringValue Time { get; set; }
	
    /// <summary>
    /// <para> objId.</para>
    /// <para>Represents the following attribute in the schema: objId </para>
    /// </summary>
    [SchemaAttr(0, "objId")]
    [Index(1)]
    public UInt32Value ObjectId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the NullEventRecord class.
    /// </summary>
    public NullEventRecord():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NullEventRecord>(deep);

}
/// <summary>
/// Defines the TransitionPatternValues enumeration. 
/// </summary> 
public enum TransitionPatternValues
{  
	///<summary>
///diamond.
///<para>When the item is serialized out as xml, its value is "diamond".</para>
///</summary>
[EnumString("diamond")]
Diamond,
///<summary>
///hexagon.
///<para>When the item is serialized out as xml, its value is "hexagon".</para>
///</summary>
[EnumString("hexagon")]
Hexagon,
 
}
/// <summary>
/// Defines the TransitionCenterDirectionTypeValues enumeration. 
/// </summary> 
public enum TransitionCenterDirectionTypeValues
{  
	///<summary>
///center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
 
}
/// <summary>
/// Defines the TransitionShredPatternValues enumeration. 
/// </summary> 
public enum TransitionShredPatternValues
{  
	///<summary>
///strip.
///<para>When the item is serialized out as xml, its value is "strip".</para>
///</summary>
[EnumString("strip")]
Strip,
///<summary>
///rectangle.
///<para>When the item is serialized out as xml, its value is "rectangle".</para>
///</summary>
[EnumString("rectangle")]
Rectangle,
 
}
/// <summary>
/// Defines the TransitionLeftRightDirectionTypeValues enumeration. 
/// </summary> 
public enum TransitionLeftRightDirectionTypeValues
{  
	///<summary>
///l.
///<para>When the item is serialized out as xml, its value is "l".</para>
///</summary>
[EnumString("l")]
Left,
///<summary>
///r.
///<para>When the item is serialized out as xml, its value is "r".</para>
///</summary>
[EnumString("r")]
Right,
 
}
}
 
 
