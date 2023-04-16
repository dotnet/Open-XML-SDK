// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using static DocumentFormat.OpenXml.Packaging.OpenXmlPartExtensions;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines CustomXmlPartType - types of CustomXmlPart.
    /// </summary>
    public static class CustomXmlPartType
    {
        /// <summary>
        /// Defines type information for AdditionalCharacteristicsInfo part.
        /// </summary>
        public static readonly PartTypeInfo AdditionalCharacteristicsInfo = new("application/xml", ".xml");

        /// <summary>
        /// Defines type information for Bibliography part.
        /// </summary>
        public static readonly PartTypeInfo Bibliography = new("application/xml", ".xml");

        /// <summary>
        /// Defines type information for CustomXml part.
        /// </summary>
        public static readonly PartTypeInfo CustomXml = new("application/xml", ".xml");

        /// <summary>
        /// Defines type information for InkContent part.
        /// </summary>
        public static readonly PartTypeInfo InkContent = new("application/inkml+xml", ".xml");
    }
}
