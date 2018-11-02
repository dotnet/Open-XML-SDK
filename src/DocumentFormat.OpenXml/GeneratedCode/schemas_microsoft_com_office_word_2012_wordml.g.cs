// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Office2013.Word
{
/// <summary>
/// <para>Defines the Color Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:color.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Color : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13334;
    /// <inheritdoc/>
    public override string LocalName => "color";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(23, "val"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues>>(23, "themeColor"),
		AttributeTag.Create<StringValue>(23, "themeTint"),
		AttributeTag.Create<StringValue>(23, "themeShade")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Run Content Color.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Run Content Theme Color.</para>
    /// <para>Represents the following attribute in the schema: w:themeColor </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "themeColor")]
    public EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues> ThemeColor
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Run Content Theme Color Tint.</para>
    /// <para>Represents the following attribute in the schema: w:themeTint </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "themeTint")]
    public StringValue ThemeTint
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Run Content Theme Color Shade.</para>
    /// <para>Represents the following attribute in the schema: w:themeShade </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "themeShade")]
    public StringValue ThemeShade
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Color class.
    /// </summary>
    public Color():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Color>(deep);

}
/// <summary>
/// <para>Defines the DataBinding Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:dataBinding.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DataBinding : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13335;
    /// <inheritdoc/>
    public override string LocalName => "dataBinding";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(23, "prefixMappings"),
		AttributeTag.Create<StringValue>(23, "xpath"),
		AttributeTag.Create<StringValue>(23, "storeItemID")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> XML Namespace Prefix Mappings.</para>
    /// <para>Represents the following attribute in the schema: w:prefixMappings </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "prefixMappings")]
    public StringValue PrefixMappings
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> XPath.</para>
    /// <para>Represents the following attribute in the schema: w:xpath </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "xpath")]
    public StringValue XPath
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Custom XML Data Storage ID.</para>
    /// <para>Represents the following attribute in the schema: w:storeItemID </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "storeItemID")]
    public StringValue StoreItemId
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataBinding class.
    /// </summary>
    public DataBinding():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataBinding>(deep);

}
/// <summary>
/// <para>Defines the Appearance Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:appearance.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Appearance : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13336;
    /// <inheritdoc/>
    public override string LocalName => "appearance";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance>>(69, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w15:val </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "val")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Appearance class.
    /// </summary>
    public Appearance():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Appearance>(deep);

}
/// <summary>
/// <para>Defines the CommentsEx Class. The root element of WordprocessingCommentsExPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:commentsEx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CommentEx &lt;w15:commentEx></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(CommentEx), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CommentsEx : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13337;
    /// <inheritdoc/>
    public override string LocalName => "commentsEx";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    
	internal CommentsEx(WordprocessingCommentsExPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WordprocessingCommentsExPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WordprocessingCommentsExPart associated with this element.
    /// </summary>
    public WordprocessingCommentsExPart WordprocessingCommentsExPart
    {
		get => OpenXmlPart as WordprocessingCommentsExPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the CommentsEx class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CommentsEx(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CommentsEx class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CommentsEx(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CommentsEx class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CommentsEx(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the CommentsEx class.
    /// </summary>
    public CommentsEx():base(){}
    
    /// <summary>
    /// Saves the DOM into the WordprocessingCommentsExPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WordprocessingCommentsExPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "commentEx" == name)
    return new CommentEx();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentsEx>(deep);

}
/// <summary>
/// <para>Defines the People Class. The root element of WordprocessingPeoplePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:people.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Person &lt;w15:person></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Person), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class People : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13338;
    /// <inheritdoc/>
    public override string LocalName => "people";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    
	internal People(WordprocessingPeoplePart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the WordprocessingPeoplePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WordprocessingPeoplePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WordprocessingPeoplePart associated with this element.
    /// </summary>
    public WordprocessingPeoplePart WordprocessingPeoplePart
    {
		get => OpenXmlPart as WordprocessingPeoplePart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the People class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public People(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the People class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public People(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the People class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public People(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the People class.
    /// </summary>
    public People():base(){}
    
    /// <summary>
    /// Saves the DOM into the WordprocessingPeoplePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WordprocessingPeoplePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "person" == name)
    return new Person();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<People>(deep);

}
/// <summary>
/// <para>Defines the SdtRepeatedSection Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:repeatingSection.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SectionTitle &lt;w15:sectionTitle></description></item>
///<item><description>DoNotAllowInsertDeleteSection &lt;w15:doNotAllowInsertDeleteSection></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SectionTitle), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(DoNotAllowInsertDeleteSection), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SdtRepeatedSection : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13339;
    /// <inheritdoc/>
    public override string LocalName => "repeatingSection";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SdtRepeatedSection class.
    /// </summary>
    public SdtRepeatedSection():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SdtRepeatedSection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SdtRepeatedSection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SdtRepeatedSection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SdtRepeatedSection(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SdtRepeatedSection class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SdtRepeatedSection(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "sectionTitle" == name)
    return new SectionTitle();
    
if( 69 == namespaceId && "doNotAllowInsertDeleteSection" == name)
    return new DoNotAllowInsertDeleteSection();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sectionTitle","doNotAllowInsertDeleteSection" };
    private static readonly byte[] eleNamespaceIds = { 69,69 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SectionTitle.</para>
    /// <para> Represents the following element tag in the schema: w15:sectionTitle </para>
    /// </summary>
    /// <remark>
    /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
    /// </remark>
    public SectionTitle SectionTitle
    {
        get => GetElement<SectionTitle>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> DoNotAllowInsertDeleteSection.</para>
    /// <para> Represents the following element tag in the schema: w15:doNotAllowInsertDeleteSection </para>
    /// </summary>
    /// <remark>
    /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
    /// </remark>
    public DoNotAllowInsertDeleteSection DoNotAllowInsertDeleteSection
    {
        get => GetElement<DoNotAllowInsertDeleteSection>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtRepeatedSection>(deep);

}
/// <summary>
/// <para>Defines the SdtRepeatedSectionItem Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:repeatingSectionItem.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SdtRepeatedSectionItem : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13340;
    /// <inheritdoc/>
    public override string LocalName => "repeatingSectionItem";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SdtRepeatedSectionItem class.
    /// </summary>
    public SdtRepeatedSectionItem():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SdtRepeatedSectionItem>(deep);

}
/// <summary>
/// <para>Defines the ChartTrackingRefBased Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:chartTrackingRefBased.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ChartTrackingRefBased : OnOffType
{
    internal const int ElementTypeIdConst = 13341;
    /// <inheritdoc/>
    public override string LocalName => "chartTrackingRefBased";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the ChartTrackingRefBased class.
    /// </summary>
    public ChartTrackingRefBased():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartTrackingRefBased>(deep);

}
/// <summary>
/// <para>Defines the DefaultCollapsed Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:collapsed.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DefaultCollapsed : OnOffType
{
    internal const int ElementTypeIdConst = 13342;
    /// <inheritdoc/>
    public override string LocalName => "collapsed";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DefaultCollapsed class.
    /// </summary>
    public DefaultCollapsed():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultCollapsed>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionLinked Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:webExtensionLinked.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionLinked : OnOffType
{
    internal const int ElementTypeIdConst = 13345;
    /// <inheritdoc/>
    public override string LocalName => "webExtensionLinked";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the WebExtensionLinked class.
    /// </summary>
    public WebExtensionLinked():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionLinked>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionCreated Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:webExtensionCreated.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionCreated : OnOffType
{
    internal const int ElementTypeIdConst = 13346;
    /// <inheritdoc/>
    public override string LocalName => "webExtensionCreated";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the WebExtensionCreated class.
    /// </summary>
    public WebExtensionCreated():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionCreated>(deep);

}
/// <summary>
/// <para>Defines the DoNotAllowInsertDeleteSection Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:doNotAllowInsertDeleteSection.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class DoNotAllowInsertDeleteSection : OnOffType
{
    internal const int ElementTypeIdConst = 13351;
    /// <inheritdoc/>
    public override string LocalName => "doNotAllowInsertDeleteSection";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    /// <summary>
    /// Initializes a new instance of the DoNotAllowInsertDeleteSection class.
    /// </summary>
    public DoNotAllowInsertDeleteSection():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DoNotAllowInsertDeleteSection>(deep);

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
		AttributeTag.Create<OnOffValue>(23, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> On/Off Value.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public OnOffValue Val
    {
        get { return (OnOffValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OnOffType class.
    /// </summary>
    protected OnOffType(){}
    
    
    
}
/// <summary>
/// <para>Defines the PersistentDocumentId Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:docId.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PersistentDocumentId : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13343;
    /// <inheritdoc/>
    public override string LocalName => "docId";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(69, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: w15:val </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PersistentDocumentId class.
    /// </summary>
    public PersistentDocumentId():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PersistentDocumentId>(deep);

}
/// <summary>
/// <para>Defines the FootnoteColumns Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:footnoteColumns.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class FootnoteColumns : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13344;
    /// <inheritdoc/>
    public override string LocalName => "footnoteColumns";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(23, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Decimal Number Value.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public Int32Value Val
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FootnoteColumns class.
    /// </summary>
    public FootnoteColumns():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FootnoteColumns>(deep);

}
/// <summary>
/// <para>Defines the CommentEx Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:commentEx.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class CommentEx : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13347;
    /// <inheritdoc/>
    public override string LocalName => "commentEx";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<HexBinaryValue>(69, "paraId"),
		AttributeTag.Create<HexBinaryValue>(69, "paraIdParent"),
		AttributeTag.Create<OnOffValue>(69, "done")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> paraId.</para>
    /// <para>Represents the following attribute in the schema: w15:paraId </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "paraId")]
    public HexBinaryValue ParaId
    {
        get { return (HexBinaryValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> paraIdParent.</para>
    /// <para>Represents the following attribute in the schema: w15:paraIdParent </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "paraIdParent")]
    public HexBinaryValue ParaIdParent
    {
        get { return (HexBinaryValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> done.</para>
    /// <para>Represents the following attribute in the schema: w15:done </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "done")]
    public OnOffValue Done
    {
        get { return (OnOffValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CommentEx class.
    /// </summary>
    public CommentEx():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentEx>(deep);

}
/// <summary>
/// <para>Defines the Person Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:person.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PresenceInfo &lt;w15:presenceInfo></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PresenceInfo), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Person : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13348;
    /// <inheritdoc/>
    public override string LocalName => "person";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(69, "author"),
		AttributeTag.Create<StringValue>(69, "contact")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> author.</para>
    /// <para>Represents the following attribute in the schema: w15:author </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "author")]
    public StringValue Author
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> contact.</para>
    /// <para>Represents the following attribute in the schema: w15:contact </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "contact")]
    public StringValue Contact
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Person class.
    /// </summary>
    public Person():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Person class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Person(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Person class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Person(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Person class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Person(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 69 == namespaceId && "presenceInfo" == name)
    return new PresenceInfo();
    

    return null;
}

        private static readonly string[] eleTagNames = { "presenceInfo" };
    private static readonly byte[] eleNamespaceIds = { 69 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PresenceInfo.</para>
    /// <para> Represents the following element tag in the schema: w15:presenceInfo </para>
    /// </summary>
    /// <remark>
    /// xmlns:w15 = http://schemas.microsoft.com/office/word/2012/wordml
    /// </remark>
    public PresenceInfo PresenceInfo
    {
        get => GetElement<PresenceInfo>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Person>(deep);

}
/// <summary>
/// <para>Defines the PresenceInfo Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:presenceInfo.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class PresenceInfo : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13349;
    /// <inheritdoc/>
    public override string LocalName => "presenceInfo";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(69, "providerId"),
		AttributeTag.Create<StringValue>(69, "userId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> providerId.</para>
    /// <para>Represents the following attribute in the schema: w15:providerId </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "providerId")]
    public StringValue ProviderId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> userId.</para>
    /// <para>Represents the following attribute in the schema: w15:userId </para>
    /// </summary>
///<remark> xmlns:w15=http://schemas.microsoft.com/office/word/2012/wordml
///</remark>
    [SchemaAttr(69, "userId")]
    public StringValue UserId
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PresenceInfo class.
    /// </summary>
    public PresenceInfo():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresenceInfo>(deep);

}
/// <summary>
/// <para>Defines the SectionTitle Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w15:sectionTitle.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SectionTitle : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13350;
    /// <inheritdoc/>
    public override string LocalName => "sectionTitle";
    
    internal override byte NamespaceId => 69;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(23, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> String Value.</para>
    /// <para>Represents the following attribute in the schema: w:val </para>
    /// </summary>
///<remark> xmlns:w=http://schemas.openxmlformats.org/wordprocessingml/2006/main
///</remark>
    [SchemaAttr(23, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SectionTitle class.
    /// </summary>
    public SectionTitle():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionTitle>(deep);

}
/// <summary>
/// Defines the SdtAppearance enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SdtAppearance
{  
	///<summary>
///boundingBox.
///<para>When the item is serialized out as xml, its value is "boundingBox".</para>
///</summary>
[EnumString("boundingBox")]
BoundingBox,
///<summary>
///tags.
///<para>When the item is serialized out as xml, its value is "tags".</para>
///</summary>
[EnumString("tags")]
Tags,
///<summary>
///hidden.
///<para>When the item is serialized out as xml, its value is "hidden".</para>
///</summary>
[EnumString("hidden")]
Hidden,
 
}
}
 
 
