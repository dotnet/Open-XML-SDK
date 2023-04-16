// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines EmbeddedControlPersistenceBinaryDataPartType - types of EmbeddedControlPart.
    /// </summary>
    public static class EmbeddedControlPersistenceBinaryDataPartType
    {
        /// <summary>
        /// Defines type information for ActiveXBin embedded control persistence binary data part.
        /// </summary>
        public static readonly PartTypeInfo ActiveXBin = new("application/vnd.ms-office.activeX", ".bin");
    }
}
