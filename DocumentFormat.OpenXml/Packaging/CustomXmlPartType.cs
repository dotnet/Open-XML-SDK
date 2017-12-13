// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

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
        InkContent
    }
}
