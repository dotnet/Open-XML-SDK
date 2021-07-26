// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:c14="http://schemas.microsoft.com/office/drawing/2007/8/2/chart" namespace.
    /// </summary>
    public static class C14
    {
        /// <summary>
        /// Defines the XML namespace associated with the c14 prefix.
        /// </summary>
        public static readonly XNamespace c14 = "http://schemas.microsoft.com/office/drawing/2007/8/2/chart";

        /// <summary>
        /// Represents the c14:dropZoneCategories XML element.
        /// </summary>
        public static readonly XName dropZoneCategories = c14 + "dropZoneCategories";

        /// <summary>
        /// Represents the c14:dropZoneData XML element.
        /// </summary>
        public static readonly XName dropZoneData = c14 + "dropZoneData";

        /// <summary>
        /// Represents the c14:dropZoneFilter XML element.
        /// </summary>
        public static readonly XName dropZoneFilter = c14 + "dropZoneFilter";

        /// <summary>
        /// Represents the c14:dropZoneSeries XML element.
        /// </summary>
        public static readonly XName dropZoneSeries = c14 + "dropZoneSeries";

        /// <summary>
        /// Represents the c14:dropZonesVisible XML element.
        /// </summary>
        public static readonly XName dropZonesVisible = c14 + "dropZonesVisible";

        /// <summary>
        /// Represents the c14:inSketchMode XML element.
        /// </summary>
        public static readonly XName inSketchMode = c14 + "inSketchMode";

        /// <summary>
        /// Represents the c14:invertSolidFillFmt XML element.
        /// </summary>
        public static readonly XName invertSolidFillFmt = c14 + "invertSolidFillFmt";

        /// <summary>
        /// Represents the c14:pivotOptions XML element.
        /// </summary>
        public static readonly XName pivotOptions = c14 + "pivotOptions";

        /// <summary>
        /// Represents the c14:showSketchBtn XML element.
        /// </summary>
        public static readonly XName showSketchBtn = c14 + "showSketchBtn";

        /// <summary>
        /// Represents the c14:sketchOptions XML element.
        /// </summary>
        public static readonly XName sketchOptions = c14 + "sketchOptions";

        /// <summary>
        /// Represents the c14:spPr XML element.
        /// </summary>
        public static readonly XName spPr = c14 + "spPr";

        /// <summary>
        /// Represents the c14:style XML element.
        /// </summary>
        public static readonly XName style = c14 + "style";
    }
}
