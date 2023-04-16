// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines EmbeddedPackagePartType - types of EmbeddedPackagePart.
    /// </summary>
    public static class EmbeddedObjectPartType
    {
        /// <summary>
        /// Defines type information for Binary embedded object part.
        /// </summary>
        public static readonly PartTypeInfo Binary = new("application/vnd.openxmlformats-officedocument.oleObject", ".bin");
    }
}
