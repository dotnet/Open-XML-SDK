// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
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

[SchemaAttr(3, "Properties")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Properties : OpenXmlPartRootElement
{
    
    
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
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneAll;
        /// <summary>
    /// <para> Name of Document Template.</para>
    /// <para> Represents the following element tag in the schema: ap:Template </para>
    /// </summary>
    /// <remark>
    /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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
	[Index(6)]
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
	[Index(7)]
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
	[Index(8)]
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
	[Index(9)]
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
	[Index(10)]
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
	[Index(11)]
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
	[Index(12)]
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
	[Index(13)]
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
	[Index(14)]
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
	[Index(15)]
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
	[Index(16)]
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
	[Index(17)]
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
	[Index(18)]
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
	[Index(19)]
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
	[Index(20)]
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
	[Index(21)]
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
	[Index(22)]
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
	[Index(23)]
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
	[Index(24)]
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
	[Index(25)]
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
	[Index(26)]
    public DocumentSecurity DocumentSecurity
	{
        get => GetElement<DocumentSecurity>(26);
        set => SetElement(26, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties>(deep);

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.All, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Template), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Manager), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Company), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Pages), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Words), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Characters), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Lines), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Paragraphs), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Slides), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Notes), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.TotalTime), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.SharedDocument), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Application), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion), 0, 1),
    new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity), 0, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
}
/// <summary>
/// <para>Name of Document Template.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ap:Template.</para>
/// </summary>

[SchemaAttr(3, "Template")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Template : OpenXmlLeafTextElement
{
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

[SchemaAttr(3, "Manager")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Manager : OpenXmlLeafTextElement
{
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

[SchemaAttr(3, "Company")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Company : OpenXmlLeafTextElement
{
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

[SchemaAttr(3, "PresentationFormat")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PresentationFormat : OpenXmlLeafTextElement
{
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

[SchemaAttr(3, "HyperlinkBase")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HyperlinkBase : OpenXmlLeafTextElement
{
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

[SchemaAttr(3, "Application")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Application : OpenXmlLeafTextElement
{
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

[SchemaAttr(3, "AppVersion")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ApplicationVersion : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "Pages")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Pages : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "Words")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Words : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "Characters")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Characters : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "Lines")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Lines : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "Paragraphs")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Paragraphs : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "Slides")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Slides : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "Notes")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Notes : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "TotalTime")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TotalTime : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "HiddenSlides")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HiddenSlides : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "MMClips")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MultimediaClips : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "CharactersWithSpaces")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CharactersWithSpaces : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(Int32Value))]
[SchemaAttr(3, "DocSecurity")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DocumentSecurity : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(BooleanValue))]
[SchemaAttr(3, "ScaleCrop")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ScaleCrop : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(BooleanValue))]
[SchemaAttr(3, "LinksUpToDate")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LinksUpToDate : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(BooleanValue))]
[SchemaAttr(3, "SharedDoc")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SharedDocument : OpenXmlLeafTextElement
{
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

[NumberValidator(SimpleType = typeof(BooleanValue))]
[SchemaAttr(3, "HyperlinksChanged")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HyperlinksChanged : OpenXmlLeafTextElement
{
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

[SchemaAttr(3, "HeadingPairs")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HeadingPairs : VectorVariantType
{
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

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
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

[SchemaAttr(3, "HLinks")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HyperlinkList : VectorVariantType
{
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

private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
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

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector))]

public abstract partial class VectorVariantType : OpenXmlCompositeElement
{
    
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Vector.</para>
    /// <para> Represents the following element tag in the schema: vt:vector </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(3, "TitlesOfParts")]
public partial class TitlesOfParts : OpenXmlCompositeElement
{
    
    
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

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Vector.</para>
    /// <para> Represents the following element tag in the schema: vt:vector </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(3, "DigSig")]
public partial class DigitalSignature : OpenXmlCompositeElement
{
    
    
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

    
private static readonly ParticleConstraint _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBlob), 1, 1)
};
internal override ParticleConstraint ParticleConstraint => _constraint;
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
        /// <summary>
    /// <para> Binary Blob.</para>
    /// <para> Represents the following element tag in the schema: vt:blob </para>
    /// </summary>
    /// <remark>
    /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
    /// </remark>
	[Index(0)]
    public DocumentFormat.OpenXml.VariantTypes.VTBlob VTBlob
	{
        get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBlob>(0);
        set => SetElement(0, value);
	}


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DigitalSignature>(deep);

}
}
