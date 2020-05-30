// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
    /// <summary>
    /// <para>Application Specific File Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Properties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Template &lt;ap:Template></description></item>
    ///   <item><description>Manager &lt;ap:Manager></description></item>
    ///   <item><description>Company &lt;ap:Company></description></item>
    ///   <item><description>Pages &lt;ap:Pages></description></item>
    ///   <item><description>Words &lt;ap:Words></description></item>
    ///   <item><description>Characters &lt;ap:Characters></description></item>
    ///   <item><description>PresentationFormat &lt;ap:PresentationFormat></description></item>
    ///   <item><description>Lines &lt;ap:Lines></description></item>
    ///   <item><description>Paragraphs &lt;ap:Paragraphs></description></item>
    ///   <item><description>Slides &lt;ap:Slides></description></item>
    ///   <item><description>Notes &lt;ap:Notes></description></item>
    ///   <item><description>TotalTime &lt;ap:TotalTime></description></item>
    ///   <item><description>HiddenSlides &lt;ap:HiddenSlides></description></item>
    ///   <item><description>MultimediaClips &lt;ap:MMClips></description></item>
    ///   <item><description>ScaleCrop &lt;ap:ScaleCrop></description></item>
    ///   <item><description>HeadingPairs &lt;ap:HeadingPairs></description></item>
    ///   <item><description>TitlesOfParts &lt;ap:TitlesOfParts></description></item>
    ///   <item><description>LinksUpToDate &lt;ap:LinksUpToDate></description></item>
    ///   <item><description>CharactersWithSpaces &lt;ap:CharactersWithSpaces></description></item>
    ///   <item><description>SharedDocument &lt;ap:SharedDoc></description></item>
    ///   <item><description>HyperlinkBase &lt;ap:HyperlinkBase></description></item>
    ///   <item><description>HyperlinkList &lt;ap:HLinks></description></item>
    ///   <item><description>HyperlinksChanged &lt;ap:HyperlinksChanged></description></item>
    ///   <item><description>DigitalSignature &lt;ap:DigSig></description></item>
    ///   <item><description>Application &lt;ap:Application></description></item>
    ///   <item><description>ApplicationVersion &lt;ap:AppVersion></description></item>
    ///   <item><description>DocumentSecurity &lt;ap:DocSecurity></description></item>
    /// </list>
    /// </remark>
    public partial class Properties : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Properties class.
        /// </summary>
        public Properties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Properties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public Properties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "Properties");
            builder.AddChild<Template>();
            builder.AddChild<Manager>();
            builder.AddChild<Company>();
            builder.AddChild<Pages>();
            builder.AddChild<Words>();
            builder.AddChild<Characters>();
            builder.AddChild<PresentationFormat>();
            builder.AddChild<Lines>();
            builder.AddChild<Paragraphs>();
            builder.AddChild<Slides>();
            builder.AddChild<Notes>();
            builder.AddChild<TotalTime>();
            builder.AddChild<HiddenSlides>();
            builder.AddChild<MultimediaClips>();
            builder.AddChild<ScaleCrop>();
            builder.AddChild<HeadingPairs>();
            builder.AddChild<TitlesOfParts>();
            builder.AddChild<LinksUpToDate>();
            builder.AddChild<CharactersWithSpaces>();
            builder.AddChild<SharedDocument>();
            builder.AddChild<HyperlinkBase>();
            builder.AddChild<HyperlinkList>();
            builder.AddChild<HyperlinksChanged>();
            builder.AddChild<DigitalSignature>();
            builder.AddChild<Application>();
            builder.AddChild<ApplicationVersion>();
            builder.AddChild<DocumentSecurity>();
            builder.Particle = new CompositeParticle(ParticleType.All, 1, 1)
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
        }

        /// <summary>
        /// <para>Name of Document Template.</para>
        /// <para>Represents the following element tag in the schema: ap:Template.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Template Template
        {
            get => GetElement<Template>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Name of Manager.</para>
        /// <para>Represents the following element tag in the schema: ap:Manager.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Manager Manager
        {
            get => GetElement<Manager>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Name of Company.</para>
        /// <para>Represents the following element tag in the schema: ap:Company.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Company Company
        {
            get => GetElement<Company>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Pages.</para>
        /// <para>Represents the following element tag in the schema: ap:Pages.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Pages Pages
        {
            get => GetElement<Pages>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Word Count.</para>
        /// <para>Represents the following element tag in the schema: ap:Words.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Words Words
        {
            get => GetElement<Words>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Characters.</para>
        /// <para>Represents the following element tag in the schema: ap:Characters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Characters Characters
        {
            get => GetElement<Characters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Intended Format of Presentation.</para>
        /// <para>Represents the following element tag in the schema: ap:PresentationFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public PresentationFormat PresentationFormat
        {
            get => GetElement<PresentationFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Lines.</para>
        /// <para>Represents the following element tag in the schema: ap:Lines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Lines Lines
        {
            get => GetElement<Lines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Paragraphs.</para>
        /// <para>Represents the following element tag in the schema: ap:Paragraphs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Paragraphs Paragraphs
        {
            get => GetElement<Paragraphs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slides Metadata Element.</para>
        /// <para>Represents the following element tag in the schema: ap:Slides.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Slides Slides
        {
            get => GetElement<Slides>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Slides Containing Notes.</para>
        /// <para>Represents the following element tag in the schema: ap:Notes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Notes Notes
        {
            get => GetElement<Notes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Edit Time Metadata Element.</para>
        /// <para>Represents the following element tag in the schema: ap:TotalTime.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public TotalTime TotalTime
        {
            get => GetElement<TotalTime>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Hidden Slides.</para>
        /// <para>Represents the following element tag in the schema: ap:HiddenSlides.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public HiddenSlides HiddenSlides
        {
            get => GetElement<HiddenSlides>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Multimedia Clips.</para>
        /// <para>Represents the following element tag in the schema: ap:MMClips.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public MultimediaClips MultimediaClips
        {
            get => GetElement<MultimediaClips>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Thumbnail Display Mode.</para>
        /// <para>Represents the following element tag in the schema: ap:ScaleCrop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public ScaleCrop ScaleCrop
        {
            get => GetElement<ScaleCrop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Heading Pairs.</para>
        /// <para>Represents the following element tag in the schema: ap:HeadingPairs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public HeadingPairs HeadingPairs
        {
            get => GetElement<HeadingPairs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Part Titles.</para>
        /// <para>Represents the following element tag in the schema: ap:TitlesOfParts.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public TitlesOfParts TitlesOfParts
        {
            get => GetElement<TitlesOfParts>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Links Up-to-Date.</para>
        /// <para>Represents the following element tag in the schema: ap:LinksUpToDate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public LinksUpToDate LinksUpToDate
        {
            get => GetElement<LinksUpToDate>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Characters (With Spaces).</para>
        /// <para>Represents the following element tag in the schema: ap:CharactersWithSpaces.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public CharactersWithSpaces CharactersWithSpaces
        {
            get => GetElement<CharactersWithSpaces>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shared Document.</para>
        /// <para>Represents the following element tag in the schema: ap:SharedDoc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public SharedDocument SharedDocument
        {
            get => GetElement<SharedDocument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Relative Hyperlink Base.</para>
        /// <para>Represents the following element tag in the schema: ap:HyperlinkBase.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public HyperlinkBase HyperlinkBase
        {
            get => GetElement<HyperlinkBase>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink List.</para>
        /// <para>Represents the following element tag in the schema: ap:HLinks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public HyperlinkList HyperlinkList
        {
            get => GetElement<HyperlinkList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlinks Changed.</para>
        /// <para>Represents the following element tag in the schema: ap:HyperlinksChanged.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public HyperlinksChanged HyperlinksChanged
        {
            get => GetElement<HyperlinksChanged>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Digital Signature.</para>
        /// <para>Represents the following element tag in the schema: ap:DigSig.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DigitalSignature DigitalSignature
        {
            get => GetElement<DigitalSignature>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Application Name.</para>
        /// <para>Represents the following element tag in the schema: ap:Application.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public Application Application
        {
            get => GetElement<Application>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Application Version.</para>
        /// <para>Represents the following element tag in the schema: ap:AppVersion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public ApplicationVersion ApplicationVersion
        {
            get => GetElement<ApplicationVersion>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Document Security.</para>
        /// <para>Represents the following element tag in the schema: ap:DocSecurity.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentSecurity DocumentSecurity
        {
            get => GetElement<DocumentSecurity>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties>(deep);

        internal Properties(ExtendedFilePropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ExtendedFilePropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ExtendedFilePropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ExtendedFilePropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ExtendedFilePropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ExtendedFilePropertiesPart associated with this element.
        /// </summary>
        public ExtendedFilePropertiesPart ExtendedFilePropertiesPart
        {
            get => OpenXmlPart as ExtendedFilePropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Name of Document Template.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Template.</para>
    /// </summary>
    public partial class Template : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Template class.
        /// </summary>
        public Template() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Template class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Template(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "Template");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Template>(deep);
    }

    /// <summary>
    /// <para>Name of Manager.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Manager.</para>
    /// </summary>
    public partial class Manager : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Manager class.
        /// </summary>
        public Manager() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Manager class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Manager(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "Manager");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Manager>(deep);
    }

    /// <summary>
    /// <para>Name of Company.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Company.</para>
    /// </summary>
    public partial class Company : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Company class.
        /// </summary>
        public Company() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Company class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Company(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "Company");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Company>(deep);
    }

    /// <summary>
    /// <para>Intended Format of Presentation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:PresentationFormat.</para>
    /// </summary>
    public partial class PresentationFormat : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationFormat class.
        /// </summary>
        public PresentationFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationFormat class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PresentationFormat(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "PresentationFormat");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationFormat>(deep);
    }

    /// <summary>
    /// <para>Relative Hyperlink Base.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HyperlinkBase.</para>
    /// </summary>
    public partial class HyperlinkBase : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinkBase class.
        /// </summary>
        public HyperlinkBase() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkBase class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HyperlinkBase(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "HyperlinkBase");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkBase>(deep);
    }

    /// <summary>
    /// <para>Application Name.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Application.</para>
    /// </summary>
    public partial class Application : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Application class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Application(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "Application");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Application>(deep);
    }

    /// <summary>
    /// <para>Application Version.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:AppVersion.</para>
    /// </summary>
    public partial class ApplicationVersion : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationVersion class.
        /// </summary>
        public ApplicationVersion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationVersion class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ApplicationVersion(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "AppVersion");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationVersion>(deep);
    }

    /// <summary>
    /// <para>Total Number of Pages.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Pages.</para>
    /// </summary>
    public partial class Pages : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Pages class.
        /// </summary>
        public Pages() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pages class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Pages(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "Pages");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pages>(deep);
    }

    /// <summary>
    /// <para>Word Count.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Words.</para>
    /// </summary>
    public partial class Words : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Words class.
        /// </summary>
        public Words() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Words class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Words(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "Words");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Words>(deep);
    }

    /// <summary>
    /// <para>Total Number of Characters.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Characters.</para>
    /// </summary>
    public partial class Characters : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Characters class.
        /// </summary>
        public Characters() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Characters class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Characters(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "Characters");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Characters>(deep);
    }

    /// <summary>
    /// <para>Number of Lines.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Lines.</para>
    /// </summary>
    public partial class Lines : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Lines class.
        /// </summary>
        public Lines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lines class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Lines(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "Lines");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lines>(deep);
    }

    /// <summary>
    /// <para>Total Number of Paragraphs.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Paragraphs.</para>
    /// </summary>
    public partial class Paragraphs : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Paragraphs class.
        /// </summary>
        public Paragraphs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraphs class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Paragraphs(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "Paragraphs");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Paragraphs>(deep);
    }

    /// <summary>
    /// <para>Slides Metadata Element.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Slides.</para>
    /// </summary>
    public partial class Slides : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Slides class.
        /// </summary>
        public Slides() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slides class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Slides(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "Slides");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slides>(deep);
    }

    /// <summary>
    /// <para>Number of Slides Containing Notes.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Notes.</para>
    /// </summary>
    public partial class Notes : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Notes class.
        /// </summary>
        public Notes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Notes class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Notes(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "Notes");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Notes>(deep);
    }

    /// <summary>
    /// <para>Total Edit Time Metadata Element.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:TotalTime.</para>
    /// </summary>
    public partial class TotalTime : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the TotalTime class.
        /// </summary>
        public TotalTime() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TotalTime class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public TotalTime(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "TotalTime");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TotalTime>(deep);
    }

    /// <summary>
    /// <para>Number of Hidden Slides.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HiddenSlides.</para>
    /// </summary>
    public partial class HiddenSlides : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HiddenSlides class.
        /// </summary>
        public HiddenSlides() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiddenSlides class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HiddenSlides(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "HiddenSlides");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenSlides>(deep);
    }

    /// <summary>
    /// <para>Total Number of Multimedia Clips.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:MMClips.</para>
    /// </summary>
    public partial class MultimediaClips : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MultimediaClips class.
        /// </summary>
        public MultimediaClips() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultimediaClips class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MultimediaClips(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "MMClips");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultimediaClips>(deep);
    }

    /// <summary>
    /// <para>Number of Characters (With Spaces).</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:CharactersWithSpaces.</para>
    /// </summary>
    public partial class CharactersWithSpaces : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CharactersWithSpaces class.
        /// </summary>
        public CharactersWithSpaces() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CharactersWithSpaces class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CharactersWithSpaces(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "CharactersWithSpaces");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CharactersWithSpaces>(deep);
    }

    /// <summary>
    /// <para>Document Security.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:DocSecurity.</para>
    /// </summary>
    public partial class DocumentSecurity : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DocumentSecurity class.
        /// </summary>
        public DocumentSecurity() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSecurity class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DocumentSecurity(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema(3, "DocSecurity");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentSecurity>(deep);
    }

    /// <summary>
    /// <para>Thumbnail Display Mode.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:ScaleCrop.</para>
    /// </summary>
    public partial class ScaleCrop : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScaleCrop class.
        /// </summary>
        public ScaleCrop() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScaleCrop class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScaleCrop(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema(3, "ScaleCrop");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScaleCrop>(deep);
    }

    /// <summary>
    /// <para>Links Up-to-Date.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:LinksUpToDate.</para>
    /// </summary>
    public partial class LinksUpToDate : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LinksUpToDate class.
        /// </summary>
        public LinksUpToDate() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinksUpToDate class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LinksUpToDate(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema(3, "LinksUpToDate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinksUpToDate>(deep);
    }

    /// <summary>
    /// <para>Shared Document.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:SharedDoc.</para>
    /// </summary>
    public partial class SharedDocument : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SharedDocument class.
        /// </summary>
        public SharedDocument() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedDocument class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SharedDocument(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema(3, "SharedDoc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedDocument>(deep);
    }

    /// <summary>
    /// <para>Hyperlinks Changed.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HyperlinksChanged.</para>
    /// </summary>
    public partial class HyperlinksChanged : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinksChanged class.
        /// </summary>
        public HyperlinksChanged() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinksChanged class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HyperlinksChanged(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema(3, "HyperlinksChanged");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinksChanged>(deep);
    }

    /// <summary>
    /// <para>Heading Pairs.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HeadingPairs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
    /// </list>
    /// </remark>
    public partial class HeadingPairs : VectorVariantType
    {
        /// <summary>
        /// Initializes a new instance of the HeadingPairs class.
        /// </summary>
        public HeadingPairs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeadingPairs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HeadingPairs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HeadingPairs(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "HeadingPairs");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeadingPairs>(deep);
    }

    /// <summary>
    /// <para>Hyperlink List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HLinks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
    /// </list>
    /// </remark>
    public partial class HyperlinkList : VectorVariantType
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinkList class.
        /// </summary>
        public HyperlinkList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HyperlinkList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public HyperlinkList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "HLinks");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkList>(deep);
    }

    /// <summary>
    /// <para>Defines the VectorVariantType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
    /// </list>
    /// </remark>
    public abstract partial class VectorVariantType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the VectorVariantType class.
        /// </summary>
        protected VectorVariantType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VectorVariantType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected VectorVariantType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        protected VectorVariantType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        }

        /// <summary>
        /// <para>Vector.</para>
        /// <para>Represents the following element tag in the schema: vt:vector.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTVector VTVector
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Part Titles.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:TitlesOfParts.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
    /// </list>
    /// </remark>
    public partial class TitlesOfParts : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TitlesOfParts class.
        /// </summary>
        public TitlesOfParts() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlesOfParts class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitlesOfParts(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public TitlesOfParts(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "TitlesOfParts");
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
            };
        }

        /// <summary>
        /// <para>Vector.</para>
        /// <para>Represents the following element tag in the schema: vt:vector.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTVector VTVector
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitlesOfParts>(deep);
    }

    /// <summary>
    /// <para>Digital Signature.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:DigSig.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTBlob &lt;vt:blob></description></item>
    /// </list>
    /// </remark>
    public partial class DigitalSignature : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DigitalSignature class.
        /// </summary>
        public DigitalSignature() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DigitalSignature class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DigitalSignature(IEnumerable<OpenXmlElement> childElements) : base(childElements)
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
        public DigitalSignature(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(3, "DigSig");
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBlob), 1, 1)
            };
        }

        /// <summary>
        /// <para>Binary Blob.</para>
        /// <para>Represents the following element tag in the schema: vt:blob.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTBlob VTBlob
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DigitalSignature>(deep);
    }
}