// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:ap="http://schemas.openxmlformats.org/officeDocument/2006/extended-properties" namespace.
    /// </summary>
    public static class AP
    {
        /// <summary>
        /// Defines the XML namespace associated with the ap prefix.
        /// </summary>
        public static readonly XNamespace ap = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties";

        /// <summary>
        /// Represents the ap:Application XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Application.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Application = ap + "Application";

        /// <summary>
        /// Represents the ap:AppVersion XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ApplicationVersion.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName AppVersion = ap + "AppVersion";

        /// <summary>
        /// Represents the ap:Characters XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Characters.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Characters = ap + "Characters";

        /// <summary>
        /// Represents the ap:CharactersWithSpaces XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CharactersWithSpaces.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName CharactersWithSpaces = ap + "CharactersWithSpaces";

        /// <summary>
        /// Represents the ap:Company XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Company.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Company = ap + "Company";

        /// <summary>
        /// Represents the ap:DigSig XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="VT.blob" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DigitalSignature.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DigSig = ap + "DigSig";

        /// <summary>
        /// Represents the ap:DocSecurity XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DocumentSecurity.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DocSecurity = ap + "DocSecurity";

        /// <summary>
        /// Represents the ap:HeadingPairs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="VT.vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HeadingPairs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName HeadingPairs = ap + "HeadingPairs";

        /// <summary>
        /// Represents the ap:HiddenSlides XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HiddenSlides.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName HiddenSlides = ap + "HiddenSlides";

        /// <summary>
        /// Represents the ap:HLinks XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="VT.vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HyperlinkList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName HLinks = ap + "HLinks";

        /// <summary>
        /// Represents the ap:HyperlinkBase XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HyperlinkBase.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName HyperlinkBase = ap + "HyperlinkBase";

        /// <summary>
        /// Represents the ap:HyperlinksChanged XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: HyperlinksChanged.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName HyperlinksChanged = ap + "HyperlinksChanged";

        /// <summary>
        /// Represents the ap:Lines XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Lines.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Lines = ap + "Lines";

        /// <summary>
        /// Represents the ap:LinksUpToDate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: LinksUpToDate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName LinksUpToDate = ap + "LinksUpToDate";

        /// <summary>
        /// Represents the ap:Manager XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Manager.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Manager = ap + "Manager";

        /// <summary>
        /// Represents the ap:MMClips XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MultimediaClips.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName MMClips = ap + "MMClips";

        /// <summary>
        /// Represents the ap:Notes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Notes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Notes = ap + "Notes";

        /// <summary>
        /// Represents the ap:Pages XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Pages.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Pages = ap + "Pages";

        /// <summary>
        /// Represents the ap:Paragraphs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Paragraphs.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Paragraphs = ap + "Paragraphs";

        /// <summary>
        /// Represents the ap:PresentationFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PresentationFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName PresentationFormat = ap + "PresentationFormat";

        /// <summary>
        /// Represents the ap:Properties XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="Application" />, <see cref="AppVersion" />, <see cref="Characters" />, <see cref="CharactersWithSpaces" />, <see cref="Company" />, <see cref="DigSig" />, <see cref="DocSecurity" />, <see cref="HeadingPairs" />, <see cref="HiddenSlides" />, <see cref="HLinks" />, <see cref="HyperlinkBase" />, <see cref="HyperlinksChanged" />, <see cref="Lines" />, <see cref="LinksUpToDate" />, <see cref="Manager" />, <see cref="MMClips" />, <see cref="Notes" />, <see cref="Pages" />, <see cref="Paragraphs" />, <see cref="PresentationFormat" />, <see cref="ScaleCrop" />, <see cref="SharedDoc" />, <see cref="Slides" />, <see cref="Template" />, <see cref="TitlesOfParts" />, <see cref="TotalTime" />, <see cref="Words" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Properties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Properties = ap + "Properties";

        /// <summary>
        /// Represents the ap:ScaleCrop XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ScaleCrop.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ScaleCrop = ap + "ScaleCrop";

        /// <summary>
        /// Represents the ap:SharedDoc XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SharedDocument.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName SharedDoc = ap + "SharedDoc";

        /// <summary>
        /// Represents the ap:Slides XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Slides.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Slides = ap + "Slides";

        /// <summary>
        /// Represents the ap:Template XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Template.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Template = ap + "Template";

        /// <summary>
        /// Represents the ap:TitlesOfParts XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="VT.vector" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TitlesOfParts.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName TitlesOfParts = ap + "TitlesOfParts";

        /// <summary>
        /// Represents the ap:TotalTime XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TotalTime.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName TotalTime = ap + "TotalTime";

        /// <summary>
        /// Represents the ap:Words XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="Properties" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Words.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName Words = ap + "Words";
    }
}
