// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.Theme
{
/// <summary>
/// <para>Defines the ThemeFamily Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is thm15:themeFamily.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;thm15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(73, "themeFamily")]
[Id(ElementTypeIdConst)]
public partial class ThemeFamily : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13430;
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
    /// <para> vid.</para>
    /// <para>Represents the following attribute in the schema: vid </para>
    /// </summary>
    [SchemaAttr(0, "vid")]
    [Index(2)]
    public StringValue Vid { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ThemeFamily class.
    /// </summary>
    public ThemeFamily():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ThemeFamily class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThemeFamily(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ThemeFamily class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThemeFamily(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ThemeFamily class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ThemeFamily(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: thm15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:thm15 = http://schemas.microsoft.com/office/thememl/2012/main
    /// </remark>
	[Index(0)]
    public OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<OfficeArtExtensionList>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThemeFamily>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is thm15:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(73, "extLst")]
[Id(ElementTypeIdConst)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13431;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
/// <summary>
/// <para>Defines the ThemeVariant Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is thm15:themeVariant.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;thm15:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(73, "themeVariant")]
[Id(ElementTypeIdConst)]
public partial class ThemeVariant : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13432;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> vid.</para>
    /// <para>Represents the following attribute in the schema: vid </para>
    /// </summary>
    [SchemaAttr(0, "vid")]
    [Index(1)]
    public StringValue Vid { get; set; }
	
    /// <summary>
    /// <para> cx.</para>
    /// <para>Represents the following attribute in the schema: cx </para>
    /// </summary>
    [SchemaAttr(0, "cx")]
    [Index(2)]
    public Int64Value X { get; set; }
	
    /// <summary>
    /// <para> cy.</para>
    /// <para>Represents the following attribute in the schema: cy </para>
    /// </summary>
    [SchemaAttr(0, "cy")]
    [Index(3)]
    public Int64Value Y { get; set; }
	
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(4)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ThemeVariant class.
    /// </summary>
    public ThemeVariant():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ThemeVariant class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThemeVariant(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ThemeVariant class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThemeVariant(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ThemeVariant class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ThemeVariant(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: thm15:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:thm15 = http://schemas.microsoft.com/office/thememl/2012/main
    /// </remark>
	[Index(0)]
    public OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<OfficeArtExtensionList>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThemeVariant>(deep);

}
/// <summary>
/// <para>Defines the ThemeVariantList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is thm15:themeVariantLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ThemeVariant &lt;thm15:themeVariant></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ThemeVariant), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(73, "themeVariantLst")]
[Id(ElementTypeIdConst)]
public partial class ThemeVariantList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13433;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the ThemeVariantList class.
    /// </summary>
    public ThemeVariantList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ThemeVariantList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThemeVariantList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ThemeVariantList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ThemeVariantList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ThemeVariantList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ThemeVariantList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThemeVariantList>(deep);

}
}
 
 
