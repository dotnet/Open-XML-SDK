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
        public static readonly XName Application = ap + "Application";

        /// <summary>
        /// Represents the ap:AppVersion XML element.
        /// </summary>
        public static readonly XName AppVersion = ap + "AppVersion";

        /// <summary>
        /// Represents the ap:Characters XML element.
        /// </summary>
        public static readonly XName Characters = ap + "Characters";

        /// <summary>
        /// Represents the ap:CharactersWithSpaces XML element.
        /// </summary>
        public static readonly XName CharactersWithSpaces = ap + "CharactersWithSpaces";

        /// <summary>
        /// Represents the ap:Company XML element.
        /// </summary>
        public static readonly XName Company = ap + "Company";

        /// <summary>
        /// Represents the ap:DigSig XML element.
        /// </summary>
        public static readonly XName DigSig = ap + "DigSig";

        /// <summary>
        /// Represents the ap:DocSecurity XML element.
        /// </summary>
        public static readonly XName DocSecurity = ap + "DocSecurity";

        /// <summary>
        /// Represents the ap:HeadingPairs XML element.
        /// </summary>
        public static readonly XName HeadingPairs = ap + "HeadingPairs";

        /// <summary>
        /// Represents the ap:HiddenSlides XML element.
        /// </summary>
        public static readonly XName HiddenSlides = ap + "HiddenSlides";

        /// <summary>
        /// Represents the ap:HLinks XML element.
        /// </summary>
        public static readonly XName HLinks = ap + "HLinks";

        /// <summary>
        /// Represents the ap:HyperlinkBase XML element.
        /// </summary>
        public static readonly XName HyperlinkBase = ap + "HyperlinkBase";

        /// <summary>
        /// Represents the ap:HyperlinksChanged XML element.
        /// </summary>
        public static readonly XName HyperlinksChanged = ap + "HyperlinksChanged";

        /// <summary>
        /// Represents the ap:Lines XML element.
        /// </summary>
        public static readonly XName Lines = ap + "Lines";

        /// <summary>
        /// Represents the ap:LinksUpToDate XML element.
        /// </summary>
        public static readonly XName LinksUpToDate = ap + "LinksUpToDate";

        /// <summary>
        /// Represents the ap:Manager XML element.
        /// </summary>
        public static readonly XName Manager = ap + "Manager";

        /// <summary>
        /// Represents the ap:MMClips XML element.
        /// </summary>
        public static readonly XName MMClips = ap + "MMClips";

        /// <summary>
        /// Represents the ap:Notes XML element.
        /// </summary>
        public static readonly XName Notes = ap + "Notes";

        /// <summary>
        /// Represents the ap:Pages XML element.
        /// </summary>
        public static readonly XName Pages = ap + "Pages";

        /// <summary>
        /// Represents the ap:Paragraphs XML element.
        /// </summary>
        public static readonly XName Paragraphs = ap + "Paragraphs";

        /// <summary>
        /// Represents the ap:PresentationFormat XML element.
        /// </summary>
        public static readonly XName PresentationFormat = ap + "PresentationFormat";

        /// <summary>
        /// Represents the ap:Properties XML element.
        /// </summary>
        public static readonly XName Properties = ap + "Properties";

        /// <summary>
        /// Represents the ap:ScaleCrop XML element.
        /// </summary>
        public static readonly XName ScaleCrop = ap + "ScaleCrop";

        /// <summary>
        /// Represents the ap:SharedDoc XML element.
        /// </summary>
        public static readonly XName SharedDoc = ap + "SharedDoc";

        /// <summary>
        /// Represents the ap:Slides XML element.
        /// </summary>
        public static readonly XName Slides = ap + "Slides";

        /// <summary>
        /// Represents the ap:Template XML element.
        /// </summary>
        public static readonly XName Template = ap + "Template";

        /// <summary>
        /// Represents the ap:TitlesOfParts XML element.
        /// </summary>
        public static readonly XName TitlesOfParts = ap + "TitlesOfParts";

        /// <summary>
        /// Represents the ap:TotalTime XML element.
        /// </summary>
        public static readonly XName TotalTime = ap + "TotalTime";

        /// <summary>
        /// Represents the ap:Words XML element.
        /// </summary>
        public static readonly XName Words = ap + "Words";
    }
}
