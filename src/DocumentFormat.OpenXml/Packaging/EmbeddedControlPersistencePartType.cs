// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines EmbeddedControlPersistencePartType - types of EmbeddedControlPart.
    /// </summary>
    public static class EmbeddedControlPersistencePartType
    {
        /// <summary>
        /// Defines type information for ActiveX embedded control persistence part.
        /// </summary>
        public static readonly PartTypeInfo ActiveX = new("application/vnd.ms-office.activeX+xml", ".xml");

        /// <summary>
        /// Defines type information for ActiveXBin embedded control persistence part.
        /// </summary>
        public static readonly PartTypeInfo ActiveXBin = new("application/vnd.ms-office.activeX", ".bin");
    }
}
