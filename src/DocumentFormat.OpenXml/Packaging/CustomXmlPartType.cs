// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines CustomXmlPartType - types of CustomXmlPart.
    /// </summary>
    public enum CustomXmlPartType
    {
        /// <summary>
        /// Additional characteristics (application/xml).
        /// </summary>
        AdditionalCharacteristics,

        /// <summary>
        /// Bibliography (application/xml).
        /// </summary>
        Bibliography,

        /// <summary>
        /// Custom XML (application/xml).
        /// </summary>
        CustomXml,

        /// <summary>
        /// Ink content (application/inkml+xml).
        /// </summary>
        InkContent,
    }
}
