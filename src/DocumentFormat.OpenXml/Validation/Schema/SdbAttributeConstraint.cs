// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Attribute constraint data.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal readonly struct SdbAttributeConstraint
    {
        public SdbAttributeConstraint(XsdAttributeUse attributeUse, ushort simpleTypeIndex, byte fileFormatVersion)
        {
            AttributeUse = attributeUse;
            SimpleTypeIndex = simpleTypeIndex;
            FileFormatVersion = fileFormatVersion;
        }

        /// <summary>
        /// Gets the xsd:use value.
        /// </summary>
        public XsdAttributeUse AttributeUse { get; }

        /// <summary>
        /// Gets the index of the simple data in the SdbSimpleTypeRestriction data array.
        /// </summary>
        public ushort SimpleTypeIndex { get; }

        /// <summary>
        /// Gets the file format version where this attribute is allowed.
        /// </summary>
        public byte FileFormatVersion { get; }
    }
}
