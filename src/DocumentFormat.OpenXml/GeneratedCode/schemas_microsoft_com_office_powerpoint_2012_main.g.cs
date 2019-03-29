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

namespace DocumentFormat.OpenXml.Office2013.PowerPoint
{
/// <summary>
/// <para>Defines the PresetTransition Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:prstTrans.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "prstTrans")]
[Id(ElementTypeIdConst)]
public partial class PresetTransition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13324;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> prst.</para>
    /// <para>Represents the following attribute in the schema: prst </para>
    /// </summary>
    [SchemaAttr(0, "prst")]
    [Index(0)]
    public StringValue Preset { get; set; }
	
    /// <summary>
    /// <para> invX.</para>
    /// <para>Represents the following attribute in the schema: invX </para>
    /// </summary>
    [SchemaAttr(0, "invX")]
    [Index(1)]
    public BooleanValue InvX { get; set; }
	
    /// <summary>
    /// <para> invY.</para>
    /// <para>Represents the following attribute in the schema: invY </para>
    /// </summary>
    [SchemaAttr(0, "invY")]
    [Index(2)]
    public BooleanValue InvY { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PresetTransition class.
    /// </summary>
    public PresetTransition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresetTransition>(deep);

}
/// <summary>
/// <para>Defines the PresenceInfo Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:presenceInfo.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "presenceInfo")]
[Id(ElementTypeIdConst)]
public partial class PresenceInfo : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13325;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> userId.</para>
    /// <para>Represents the following attribute in the schema: userId </para>
    /// </summary>
    [SchemaAttr(0, "userId")]
    [Index(0)]
    public StringValue UserId { get; set; }
	
    /// <summary>
    /// <para> providerId.</para>
    /// <para>Represents the following attribute in the schema: providerId </para>
    /// </summary>
    [SchemaAttr(0, "providerId")]
    [Index(1)]
    public StringValue ProviderId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the PresenceInfo class.
    /// </summary>
    public PresenceInfo():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresenceInfo>(deep);

}
/// <summary>
/// <para>Defines the ThreadingInfo Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:threadingInfo.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ParentCommentIdentifier &lt;p15:parentCm></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ParentCommentIdentifier), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "threadingInfo")]
[Id(ElementTypeIdConst)]
public partial class ThreadingInfo : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13326;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> timeZoneBias.</para>
    /// <para>Represents the following attribute in the schema: timeZoneBias </para>
    /// </summary>
    [SchemaAttr(0, "timeZoneBias")]
    [Index(0)]
    public Int32Value TimeZoneBias { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ThreadingInfo class.
    /// </summary>
    public ThreadingInfo():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ThreadingInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThreadingInfo(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ThreadingInfo class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThreadingInfo(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ThreadingInfo class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ThreadingInfo(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ParentCommentIdentifier.</para>
    /// <para> Represents the following element tag in the schema: p15:parentCm </para>
    /// </summary>
    /// <remark>
    /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
    /// </remark>
	[Index(0)]
    public ParentCommentIdentifier ParentCommentIdentifier
	{
        get => GetElement<ParentCommentIdentifier>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadingInfo>(deep);

}
/// <summary>
/// <para>Defines the SlideGuideList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:sldGuideLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtendedGuide &lt;p15:guide></description></item>
///<item><description>ExtensionList &lt;p15:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(68, "sldGuideLst")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SlideGuideList : ExtendedGuideList
{
    internal const int ElementTypeIdConst = 13327;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the SlideGuideList class.
    /// </summary>
    public SlideGuideList():base(){}
        /// <summary>
    ///Initializes a new instance of the SlideGuideList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlideGuideList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlideGuideList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlideGuideList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlideGuideList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlideGuideList(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlideGuideList>(deep);

}
/// <summary>
/// <para>Defines the NotesGuideList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:notesGuideLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtendedGuide &lt;p15:guide></description></item>
///<item><description>ExtensionList &lt;p15:extLst></description></item>
/// </list>
/// </remarks>

[SchemaAttr(68, "notesGuideLst")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class NotesGuideList : ExtendedGuideList
{
    internal const int ElementTypeIdConst = 13328;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the NotesGuideList class.
    /// </summary>
    public NotesGuideList():base(){}
        /// <summary>
    ///Initializes a new instance of the NotesGuideList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NotesGuideList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NotesGuideList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NotesGuideList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NotesGuideList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NotesGuideList(string outerXml)
        : base(outerXml)
    {
    }
    

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NotesGuideList>(deep);

}
/// <summary>
/// Defines the ExtendedGuideList class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtendedGuide &lt;p15:guide></description></item>
///<item><description>ExtensionList &lt;p15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtendedGuide), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

public abstract partial class ExtendedGuideList : OpenXmlCompositeElement
{
        
    
    
    
    
    /// <summary>
    /// Initializes a new instance of the ExtendedGuideList class.
    /// </summary>
    protected ExtendedGuideList(){}
    
        /// <summary>
    ///Initializes a new instance of the ExtendedGuideList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ExtendedGuideList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtendedGuideList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected ExtendedGuideList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtendedGuideList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected ExtendedGuideList(string outerXml)
        : base(outerXml)
    {
    }
    

    
}
/// <summary>
/// <para>Defines the ChartTrackingReferenceBased Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:chartTrackingRefBased.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "chartTrackingRefBased")]
[Id(ElementTypeIdConst)]
public partial class ChartTrackingReferenceBased : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13329;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public BooleanValue Val { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ChartTrackingReferenceBased class.
    /// </summary>
    public ChartTrackingReferenceBased():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTrackingReferenceBased>(deep);

}
/// <summary>
/// <para>Defines the ParentCommentIdentifier Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:parentCm.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "parentCm")]
[Id(ElementTypeIdConst)]
public partial class ParentCommentIdentifier : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13330;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> authorId.</para>
    /// <para>Represents the following attribute in the schema: authorId </para>
    /// </summary>
    [SchemaAttr(0, "authorId")]
    [Index(0)]
    public UInt32Value AuthorId { get; set; }
	
    /// <summary>
    /// <para> idx.</para>
    /// <para>Represents the following attribute in the schema: idx </para>
    /// </summary>
    [SchemaAttr(0, "idx")]
    [Index(1)]
    public UInt32Value Index { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ParentCommentIdentifier class.
    /// </summary>
    public ParentCommentIdentifier():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParentCommentIdentifier>(deep);

}
/// <summary>
/// <para>Defines the ColorType Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:clr.</para>
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

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "clr")]
[Id(ElementTypeIdConst)]
public partial class ColorType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13331;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ColorType class.
    /// </summary>
    public ColorType():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ColorType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorType(string outerXml)
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
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorType>(deep);

}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Presentation.Extension &lt;p:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Presentation.Extension))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "extLst")]
[Id(ElementTypeIdConst)]
public partial class ExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13332;
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
/// <para>Defines the ExtendedGuide Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p15:guide.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ColorType &lt;p15:clr></description></item>
///<item><description>ExtensionList &lt;p15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ColorType), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(68, "guide")]
[Id(ElementTypeIdConst)]
public partial class ExtendedGuide : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13333;
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
    /// <para> orient.</para>
    /// <para>Represents the following attribute in the schema: orient </para>
    /// </summary>
    [SchemaAttr(0, "orient")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues> Orientation { get; set; }
	
    /// <summary>
    /// <para> pos.</para>
    /// <para>Represents the following attribute in the schema: pos </para>
    /// </summary>
    [SchemaAttr(0, "pos")]
    [Index(3)]
    public Int32Value Position { get; set; }
	
    /// <summary>
    /// <para> userDrawn.</para>
    /// <para>Represents the following attribute in the schema: userDrawn </para>
    /// </summary>
    [SchemaAttr(0, "userDrawn")]
    [Index(4)]
    public BooleanValue IsUserDrawn { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ExtendedGuide class.
    /// </summary>
    public ExtendedGuide():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ExtendedGuide class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtendedGuide(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtendedGuide class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtendedGuide(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtendedGuide class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExtendedGuide(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ColorType.</para>
    /// <para> Represents the following element tag in the schema: p15:clr </para>
    /// </summary>
    /// <remark>
    /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
    /// </remark>
	[Index(0)]
    public ColorType ColorType
	{
        get => GetElement<ColorType>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: p15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:p15 = http://schemas.microsoft.com/office/powerpoint/2012/main
    /// </remark>
	[Index(1)]
    public ExtensionList ExtensionList
	{
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtendedGuide>(deep);

}
}
 
 
