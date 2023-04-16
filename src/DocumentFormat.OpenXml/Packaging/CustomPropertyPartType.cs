// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using static DocumentFormat.OpenXml.Packaging.OpenXmlPartExtensions;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines CustomPropertyPartType - types of CustomPropertyPart.
    /// </summary>
    public static class CustomPropertyPartType
    {
        /// <summary>
        /// Defines type information for spreadsheet custom property part.
        /// </summary>
        public static readonly PartTypeInfo Spreadsheet = new("application/vnd.openxmlformats-officedocument.spreadsheetml.customProperty", ".xml");

        /// <summary>
        /// Defines type information for xml custom property part.
        /// </summary>
        public static readonly PartTypeInfo Xml = new("application/xml", ".xml");
    }
}
