// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.VariantTypes;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
/// <summary>
/// <para>Application Specific File Properties. The root element of ExtendedFilePropertiesPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Properties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Template &lt;ap:Template></description></item>
///<item><description>Manager &lt;ap:Manager></description></item>
///<item><description>Company &lt;ap:Company></description></item>
///<item><description>Pages &lt;ap:Pages></description></item>
///<item><description>Words &lt;ap:Words></description></item>
///<item><description>Characters &lt;ap:Characters></description></item>
///<item><description>PresentationFormat &lt;ap:PresentationFormat></description></item>
///<item><description>Lines &lt;ap:Lines></description></item>
///<item><description>Paragraphs &lt;ap:Paragraphs></description></item>
///<item><description>Slides &lt;ap:Slides></description></item>
///<item><description>Notes &lt;ap:Notes></description></item>
///<item><description>TotalTime &lt;ap:TotalTime></description></item>
///<item><description>HiddenSlides &lt;ap:HiddenSlides></description></item>
///<item><description>MultimediaClips &lt;ap:MMClips></description></item>
///<item><description>ScaleCrop &lt;ap:ScaleCrop></description></item>
///<item><description>HeadingPairs &lt;ap:HeadingPairs></description></item>
///<item><description>TitlesOfParts &lt;ap:TitlesOfParts></description></item>
///<item><description>LinksUpToDate &lt;ap:LinksUpToDate></description></item>
///<item><description>CharactersWithSpaces &lt;ap:CharactersWithSpaces></description></item>
///<item><description>SharedDocument &lt;ap:SharedDoc></description></item>
///<item><description>HyperlinkBase &lt;ap:HyperlinkBase></description></item>
///<item><description>HyperlinkList &lt;ap:HLinks></description></item>
///<item><description>HyperlinksChanged &lt;ap:HyperlinksChanged></description></item>
///<item><description>DigitalSignature &lt;ap:DigSig></description></item>
///<item><description>Application &lt;ap:Application></description></item>
///<item><description>ApplicationVersion &lt;ap:AppVersion></description></item>
///<item><description>DocumentSecurity &lt;ap:DocSecurity></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Template))]
    [ChildElementInfo(typeof(Manager))]
    [ChildElementInfo(typeof(Company))]
    [ChildElementInfo(typeof(Pages))]
    [ChildElementInfo(typeof(Words))]
    [ChildElementInfo(typeof(Characters))]
    [ChildElementInfo(typeof(PresentationFormat))]
    [ChildElementInfo(typeof(Lines))]
    [ChildElementInfo(typeof(Paragraphs))]
    [ChildElementInfo(typeof(Slides))]
    [ChildElementInfo(typeof(Notes))]
    [ChildElementInfo(typeof(TotalTime))]
    [ChildElementInfo(typeof(HiddenSlides))]
    [ChildElementInfo(typeof(MultimediaClips))]
    [ChildElementInfo(typeof(ScaleCrop))]
    [ChildElementInfo(typeof(HeadingPairs))]
    [ChildElementInfo(typeof(TitlesOfParts))]
    [ChildElementInfo(typeof(LinksUpToDate))]
    [ChildElementInfo(typeof(CharactersWithSpaces))]
    [ChildElementInfo(typeof(SharedDocument))]
    [ChildElementInfo(typeof(HyperlinkBase))]
    [ChildElementInfo(typeof(HyperlinkList))]
    [ChildElementInfo(typeof(HyperlinksChanged))]
    [ChildElementInfo(typeof(DigitalSignature))]
    [ChildElementInfo(typeof(Application))]
    [ChildElementInfo(typeof(ApplicationVersion))]
    [ChildElementInfo(typeof(DocumentSecurity))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Properties : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 11064;
    /// <inheritdoc/>
    public override string LocalName => "Properties";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal Properties(ExtendedFilePropertiesPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the ExtendedFilePropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(ExtendedFilePropertiesPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the ExtendedFilePropertiesPart associated with this element.
    /// </summary>
    public ExtendedFilePropertiesPart ExtendedFilePropertiesPart
    {
		get => OpenXmlPart as ExtendedFilePropertiesPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the Properties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Properties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Properties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Properties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Properties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Properties(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the Properties class.
    /// </summary>
    public Properties():base(){}
    
    /// <summary>
    /// Saves the DOM into the ExtendedFilePropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(ExtendedFilePropertiesPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 3 == namespaceId && "Template" == name)
    return new Template();
    
if( 3 == namespaceId && "Manager" == name)
    return new Manager();
    
if( 3 == namespaceId && "Company" == name)
    return new Company();
    
if( 3 == namespaceId && "Pages" == name)
    return new Pages();
    
if( 3 == namespaceId && "Words" == name)
    return new Words();
    
if( 3 == namespaceId && "Characters" == name)
    return new Characters();
    
if( 3 == namespaceId && "PresentationFormat" == name)
    return new PresentationFormat();
    
if( 3 == namespaceId && "Lines" == name)
    return new Lines();
    
if( 3 == namespaceId && "Paragraphs" == name)
    return new Paragraphs();
    
if( 3 == namespaceId && "Slides" == name)
    return new Slides();
    
if( 3 == namespaceId && "Notes" == name)
    return new Notes();
    
if( 3 == namespaceId && "TotalTime" == name)
    return new TotalTime();
    
if( 3 == namespaceId && "HiddenSlides" == name)
    return new HiddenSlides();
    
if( 3 == namespaceId && "MMClips" == name)
    return new MultimediaClips();
    
if( 3 == namespaceId && "ScaleCrop" == name)
    return new ScaleCrop();
    
if( 3 == namespaceId && "HeadingPairs" == name)
    return new HeadingPairs();
    
if( 3 == namespaceId && "TitlesOfParts" == name)
    return new TitlesOfParts();
    
if( 3 == namespaceId && "LinksUpToDate" == name)
    return new LinksUpToDate();
    
if( 3 == namespaceId && "CharactersWithSpaces" == name)
    return new CharactersWithSpaces();
    
if( 3 == namespaceId && "SharedDoc" == name)
    return new SharedDocument();
    
if( 3 == namespaceId && "HyperlinkBase" == name)
    return new HyperlinkBase();
    
if( 3 == namespaceId && "HLinks" == name)
    return new HyperlinkList();
    
if( 3 == namespaceId && "HyperlinksChanged" == name)
    return new HyperlinksChanged();
    
if( 3 == namespaceId && "DigSig" == name)
    return new DigitalSignature();
    
if( 3 == namespaceId && "Application" == name)
    return new Application();
    
if( 3 == namespaceId && "AppVersion" == name)
    return new ApplicationVersion();
    
if( 3 == namespaceId && "DocSecurity" == name)
    return new DocumentSecurity();
    

    return null;
}

        private static readonly string[] eleTagNames = { "Template","Manager","Company","Pages","Words","Characters","PresentationFormat","Lines","Paragraphs","Slides","Notes","TotalTime","HiddenSlides","MMClips","ScaleCrop","HeadingPairs","TitlesOfParts","LinksUpToDate","CharactersWithSpaces","SharedDoc","HyperlinkBase","HLinks","HyperlinksChanged","DigSig","Application","AppVersion","DocSecurity" };
    private static readonly byte[] eleNamespaceIds = { 3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
    
        /// <summary>
    /// <para> Name of Document Template.</para>
    /// <para> Represents the following element tag in the schema: ap:Template </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Template Template
    {
        get => GetElement<Template>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Name of Manager.</para>
    /// <para> Represents the following element tag in the schema: ap:Manager </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Manager Manager
    {
        get => GetElement<Manager>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Name of Company.</para>
    /// <para> Represents the following element tag in the schema: ap:Company </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Company Company
    {
        get => GetElement<Company>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Total Number of Pages.</para>
    /// <para> Represents the following element tag in the schema: ap:Pages </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Pages Pages
    {
        get => GetElement<Pages>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Word Count.</para>
    /// <para> Represents the following element tag in the schema: ap:Words </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Words Words
    {
        get => GetElement<Words>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Total Number of Characters.</para>
    /// <para> Represents the following element tag in the schema: ap:Characters </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Characters Characters
    {
        get => GetElement<Characters>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Intended Format of Presentation.</para>
    /// <para> Represents the following element tag in the schema: ap:PresentationFormat </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public PresentationFormat PresentationFormat
    {
        get => GetElement<PresentationFormat>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Number of Lines.</para>
    /// <para> Represents the following element tag in the schema: ap:Lines </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Lines Lines
    {
        get => GetElement<Lines>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Total Number of Paragraphs.</para>
    /// <para> Represents the following element tag in the schema: ap:Paragraphs </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Paragraphs Paragraphs
    {
        get => GetElement<Paragraphs>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Slides Metadata Element.</para>
    /// <para> Represents the following element tag in the schema: ap:Slides </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Slides Slides
    {
        get => GetElement<Slides>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Number of Slides Containing Notes.</para>
    /// <para> Represents the following element tag in the schema: ap:Notes </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Notes Notes
    {
        get => GetElement<Notes>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> Total Edit Time Metadata Element.</para>
    /// <para> Represents the following element tag in the schema: ap:TotalTime </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public TotalTime TotalTime
    {
        get => GetElement<TotalTime>(11);
        set => SetElement(11, value);
    }
    /// <summary>
    /// <para> Number of Hidden Slides.</para>
    /// <para> Represents the following element tag in the schema: ap:HiddenSlides </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public HiddenSlides HiddenSlides
    {
        get => GetElement<HiddenSlides>(12);
        set => SetElement(12, value);
    }
    /// <summary>
    /// <para> Total Number of Multimedia Clips.</para>
    /// <para> Represents the following element tag in the schema: ap:MMClips </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public MultimediaClips MultimediaClips
    {
        get => GetElement<MultimediaClips>(13);
        set => SetElement(13, value);
    }
    /// <summary>
    /// <para> Thumbnail Display Mode.</para>
    /// <para> Represents the following element tag in the schema: ap:ScaleCrop </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public ScaleCrop ScaleCrop
    {
        get => GetElement<ScaleCrop>(14);
        set => SetElement(14, value);
    }
    /// <summary>
    /// <para> Heading Pairs.</para>
    /// <para> Represents the following element tag in the schema: ap:HeadingPairs </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public HeadingPairs HeadingPairs
    {
        get => GetElement<HeadingPairs>(15);
        set => SetElement(15, value);
    }
    /// <summary>
    /// <para> Part Titles.</para>
    /// <para> Represents the following element tag in the schema: ap:TitlesOfParts </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public TitlesOfParts TitlesOfParts
    {
        get => GetElement<TitlesOfParts>(16);
        set => SetElement(16, value);
    }
    /// <summary>
    /// <para> Links Up-to-Date.</para>
    /// <para> Represents the following element tag in the schema: ap:LinksUpToDate </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public LinksUpToDate LinksUpToDate
    {
        get => GetElement<LinksUpToDate>(17);
        set => SetElement(17, value);
    }
    /// <summary>
    /// <para> Number of Characters (With Spaces).</para>
    /// <para> Represents the following element tag in the schema: ap:CharactersWithSpaces </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public CharactersWithSpaces CharactersWithSpaces
    {
        get => GetElement<CharactersWithSpaces>(18);
        set => SetElement(18, value);
    }
    /// <summary>
    /// <para> Shared Document.</para>
    /// <para> Represents the following element tag in the schema: ap:SharedDoc </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public SharedDocument SharedDocument
    {
        get => GetElement<SharedDocument>(19);
        set => SetElement(19, value);
    }
    /// <summary>
    /// <para> Relative Hyperlink Base.</para>
    /// <para> Represents the following element tag in the schema: ap:HyperlinkBase </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public HyperlinkBase HyperlinkBase
    {
        get => GetElement<HyperlinkBase>(20);
        set => SetElement(20, value);
    }
    /// <summary>
    /// <para> Hyperlink List.</para>
    /// <para> Represents the following element tag in the schema: ap:HLinks </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public HyperlinkList HyperlinkList
    {
        get => GetElement<HyperlinkList>(21);
        set => SetElement(21, value);
    }
    /// <summary>
    /// <para> Hyperlinks Changed.</para>
    /// <para> Represents the following element tag in the schema: ap:HyperlinksChanged </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public HyperlinksChanged HyperlinksChanged
    {
        get => GetElement<HyperlinksChanged>(22);
        set => SetElement(22, value);
    }
    /// <summary>
    /// <para> Digital Signature.</para>
    /// <para> Represents the following element tag in the schema: ap:DigSig </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public DigitalSignature DigitalSignature
    {
        get => GetElement<DigitalSignature>(23);
        set => SetElement(23, value);
    }
    /// <summary>
    /// <para> Application Name.</para>
    /// <para> Represents the following element tag in the schema: ap:Application </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public Application Application
    {
        get => GetElement<Application>(24);
        set => SetElement(24, value);
    }
    /// <summary>
    /// <para> Application Version.</para>
    /// <para> Represents the following element tag in the schema: ap:AppVersion </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public ApplicationVersion ApplicationVersion
    {
        get => GetElement<ApplicationVersion>(25);
        set => SetElement(25, value);
    }
    /// <summary>
    /// <para> Document Security.</para>
    /// <para> Represents the following element tag in the schema: ap:DocSecurity </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
    public DocumentSecurity DocumentSecurity
    {
        get => GetElement<DocumentSecurity>(26);
        set => SetElement(26, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties>(deep);

}
/// <summary>
/// <para>Name of Document Template.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Template.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Template : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11065;
    /// <inheritdoc/>
    public override string LocalName => "Template";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Template class.
    /// </summary>
    public Template():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Template class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Template(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Template>(deep);

}
/// <summary>
/// <para>Name of Manager.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Manager.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Manager : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11066;
    /// <inheritdoc/>
    public override string LocalName => "Manager";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Manager class.
    /// </summary>
    public Manager():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Manager class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Manager(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Manager>(deep);

}
/// <summary>
/// <para>Name of Company.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Company.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Company : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11067;
    /// <inheritdoc/>
    public override string LocalName => "Company";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Company class.
    /// </summary>
    public Company():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Company class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Company(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Company>(deep);

}
/// <summary>
/// <para>Intended Format of Presentation.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:PresentationFormat.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PresentationFormat : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11071;
    /// <inheritdoc/>
    public override string LocalName => "PresentationFormat";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the PresentationFormat class.
    /// </summary>
    public PresentationFormat():base(){}
    
        /// <summary>
    /// Initializes a new instance of the PresentationFormat class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PresentationFormat(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationFormat>(deep);

}
/// <summary>
/// <para>Relative Hyperlink Base.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:HyperlinkBase.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HyperlinkBase : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11085;
    /// <inheritdoc/>
    public override string LocalName => "HyperlinkBase";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HyperlinkBase class.
    /// </summary>
    public HyperlinkBase():base(){}
    
        /// <summary>
    /// Initializes a new instance of the HyperlinkBase class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public HyperlinkBase(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkBase>(deep);

}
/// <summary>
/// <para>Application Name.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Application.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Application : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11089;
    /// <inheritdoc/>
    public override string LocalName => "Application";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Application class.
    /// </summary>
    public Application():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Application class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Application(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Application>(deep);

}
/// <summary>
/// <para>Application Version.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:AppVersion.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ApplicationVersion : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11090;
    /// <inheritdoc/>
    public override string LocalName => "AppVersion";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ApplicationVersion class.
    /// </summary>
    public ApplicationVersion():base(){}
    
        /// <summary>
    /// Initializes a new instance of the ApplicationVersion class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ApplicationVersion(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationVersion>(deep);

}
/// <summary>
/// <para>Total Number of Pages.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Pages.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Pages : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11068;
    /// <inheritdoc/>
    public override string LocalName => "Pages";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Pages class.
    /// </summary>
    public Pages():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Pages class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Pages(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pages>(deep);

}
/// <summary>
/// <para>Word Count.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Words.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Words : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11069;
    /// <inheritdoc/>
    public override string LocalName => "Words";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Words class.
    /// </summary>
    public Words():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Words class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Words(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Words>(deep);

}
/// <summary>
/// <para>Total Number of Characters.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Characters.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Characters : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11070;
    /// <inheritdoc/>
    public override string LocalName => "Characters";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Characters class.
    /// </summary>
    public Characters():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Characters class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Characters(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Characters>(deep);

}
/// <summary>
/// <para>Number of Lines.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Lines.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Lines : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11072;
    /// <inheritdoc/>
    public override string LocalName => "Lines";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Lines class.
    /// </summary>
    public Lines():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Lines class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Lines(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lines>(deep);

}
/// <summary>
/// <para>Total Number of Paragraphs.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Paragraphs.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Paragraphs : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11073;
    /// <inheritdoc/>
    public override string LocalName => "Paragraphs";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Paragraphs class.
    /// </summary>
    public Paragraphs():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Paragraphs class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Paragraphs(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Paragraphs>(deep);

}
/// <summary>
/// <para>Slides Metadata Element.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Slides.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Slides : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11074;
    /// <inheritdoc/>
    public override string LocalName => "Slides";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Slides class.
    /// </summary>
    public Slides():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Slides class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Slides(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slides>(deep);

}
/// <summary>
/// <para>Number of Slides Containing Notes.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Notes.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Notes : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11075;
    /// <inheritdoc/>
    public override string LocalName => "Notes";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Notes class.
    /// </summary>
    public Notes():base(){}
    
        /// <summary>
    /// Initializes a new instance of the Notes class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Notes(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Notes>(deep);

}
/// <summary>
/// <para>Total Edit Time Metadata Element.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:TotalTime.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TotalTime : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11076;
    /// <inheritdoc/>
    public override string LocalName => "TotalTime";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the TotalTime class.
    /// </summary>
    public TotalTime():base(){}
    
        /// <summary>
    /// Initializes a new instance of the TotalTime class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public TotalTime(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TotalTime>(deep);

}
/// <summary>
/// <para>Number of Hidden Slides.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:HiddenSlides.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HiddenSlides : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11077;
    /// <inheritdoc/>
    public override string LocalName => "HiddenSlides";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HiddenSlides class.
    /// </summary>
    public HiddenSlides():base(){}
    
        /// <summary>
    /// Initializes a new instance of the HiddenSlides class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public HiddenSlides(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenSlides>(deep);

}
/// <summary>
/// <para>Total Number of Multimedia Clips.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:MMClips.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MultimediaClips : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11078;
    /// <inheritdoc/>
    public override string LocalName => "MMClips";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MultimediaClips class.
    /// </summary>
    public MultimediaClips():base(){}
    
        /// <summary>
    /// Initializes a new instance of the MultimediaClips class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public MultimediaClips(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultimediaClips>(deep);

}
/// <summary>
/// <para>Number of Characters (With Spaces).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:CharactersWithSpaces.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CharactersWithSpaces : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11083;
    /// <inheritdoc/>
    public override string LocalName => "CharactersWithSpaces";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the CharactersWithSpaces class.
    /// </summary>
    public CharactersWithSpaces():base(){}
    
        /// <summary>
    /// Initializes a new instance of the CharactersWithSpaces class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CharactersWithSpaces(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CharactersWithSpaces>(deep);

}
/// <summary>
/// <para>Document Security.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:DocSecurity.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DocumentSecurity : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11091;
    /// <inheritdoc/>
    public override string LocalName => "DocSecurity";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the DocumentSecurity class.
    /// </summary>
    public DocumentSecurity():base(){}
    
        /// <summary>
    /// Initializes a new instance of the DocumentSecurity class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DocumentSecurity(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new Int32Value(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentSecurity>(deep);

}
/// <summary>
/// <para>Thumbnail Display Mode.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:ScaleCrop.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScaleCrop : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11079;
    /// <inheritdoc/>
    public override string LocalName => "ScaleCrop";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ScaleCrop class.
    /// </summary>
    public ScaleCrop():base(){}
    
        /// <summary>
    /// Initializes a new instance of the ScaleCrop class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScaleCrop(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new BooleanValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScaleCrop>(deep);

}
/// <summary>
/// <para>Links Up-to-Date.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:LinksUpToDate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LinksUpToDate : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11082;
    /// <inheritdoc/>
    public override string LocalName => "LinksUpToDate";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the LinksUpToDate class.
    /// </summary>
    public LinksUpToDate():base(){}
    
        /// <summary>
    /// Initializes a new instance of the LinksUpToDate class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LinksUpToDate(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new BooleanValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinksUpToDate>(deep);

}
/// <summary>
/// <para>Shared Document.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:SharedDoc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SharedDocument : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11084;
    /// <inheritdoc/>
    public override string LocalName => "SharedDoc";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SharedDocument class.
    /// </summary>
    public SharedDocument():base(){}
    
        /// <summary>
    /// Initializes a new instance of the SharedDocument class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SharedDocument(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new BooleanValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedDocument>(deep);

}
/// <summary>
/// <para>Hyperlinks Changed.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:HyperlinksChanged.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HyperlinksChanged : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 11087;
    /// <inheritdoc/>
    public override string LocalName => "HyperlinksChanged";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HyperlinksChanged class.
    /// </summary>
    public HyperlinksChanged():base(){}
    
        /// <summary>
    /// Initializes a new instance of the HyperlinksChanged class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public HyperlinksChanged(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new BooleanValue(){ InnerText = text };
    }
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinksChanged>(deep);

}
/// <summary>
/// <para>Heading Pairs.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:HeadingPairs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HeadingPairs : VectorVariantType
{
    internal const int ElementTypeIdConst = 11080;
    /// <inheritdoc/>
    public override string LocalName => "HeadingPairs";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HeadingPairs class.
    /// </summary>
    public HeadingPairs():base(){}
        /// <summary>
    ///Initializes a new instance of the HeadingPairs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HeadingPairs(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HeadingPairs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HeadingPairs(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HeadingPairs class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HeadingPairs(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeadingPairs>(deep);

}
/// <summary>
/// <para>Hyperlink List.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:HLinks.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HyperlinkList : VectorVariantType
{
    internal const int ElementTypeIdConst = 11086;
    /// <inheritdoc/>
    public override string LocalName => "HLinks";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HyperlinkList class.
    /// </summary>
    public HyperlinkList():base(){}
        /// <summary>
    ///Initializes a new instance of the HyperlinkList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HyperlinkList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the HyperlinkList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public HyperlinkList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the HyperlinkList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public HyperlinkList(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkList>(deep);

}
/// <summary>
/// Defines the VectorVariantType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class VectorVariantType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 5 == namespaceId && "vector" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTVector();
    

    return null;
}

        private static readonly string[] eleTagNames = { "vector" };
    private static readonly byte[] eleNamespaceIds = { 5 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Vector.</para>
    /// <para> Represents the following element tag in the schema: vt:vector </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTVector VTVector
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>(0);
        set => SetElement(0, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the VectorVariantType class.
    /// </summary>
    protected VectorVariantType(){}
    
        /// <summary>
    ///Initializes a new instance of the VectorVariantType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected VectorVariantType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the VectorVariantType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected VectorVariantType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the VectorVariantType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected VectorVariantType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Part Titles.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:TitlesOfParts.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TitlesOfParts : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11081;
    /// <inheritdoc/>
    public override string LocalName => "TitlesOfParts";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TitlesOfParts class.
    /// </summary>
    public TitlesOfParts():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TitlesOfParts class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TitlesOfParts(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TitlesOfParts class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TitlesOfParts(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TitlesOfParts class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TitlesOfParts(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 5 == namespaceId && "vector" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTVector();
    

    return null;
}

        private static readonly string[] eleTagNames = { "vector" };
    private static readonly byte[] eleNamespaceIds = { 5 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Vector.</para>
    /// <para> Represents the following element tag in the schema: vt:vector </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTVector VTVector
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitlesOfParts>(deep);

}
/// <summary>
/// <para>Digital Signature.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:DigSig.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.VariantTypes.VTBlob &lt;vt:blob></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTBlob))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DigitalSignature : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11088;
    /// <inheritdoc/>
    public override string LocalName => "DigSig";
    
    internal override byte NamespaceId => 3;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DigitalSignature class.
    /// </summary>
    public DigitalSignature():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DigitalSignature class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DigitalSignature(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DigitalSignature class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DigitalSignature(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DigitalSignature class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DigitalSignature(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 5 == namespaceId && "blob" == name)
    return new DocumentFormat.OpenXml.VariantTypes.VTBlob();
    

    return null;
}

        private static readonly string[] eleTagNames = { "blob" };
    private static readonly byte[] eleNamespaceIds = { 5 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Binary Blob.</para>
    /// <para> Represents the following element tag in the schema: vt:blob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
    public DocumentFormat.OpenXml.VariantTypes.VTBlob VTBlob
    {
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBlob>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DigitalSignature>(deep);

}
}
 
 
