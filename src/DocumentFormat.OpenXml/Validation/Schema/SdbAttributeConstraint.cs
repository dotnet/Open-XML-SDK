// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Attribute constraint data.
    /// </summary>
    /// <remarks>
    /// We cannot use auto-properties here due to failure in .NET Native to compile them. For further details, https://github.com/OfficeDev/Open-XML-SDK/issues/567.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal readonly struct SdbAttributeConstraint
    {
        private readonly XsdAttributeUse _attributeUse;
        private readonly ushort _simpleTypeIndex;
        private readonly byte _fileFormatVersion;

        public SdbAttributeConstraint(XsdAttributeUse attributeUse, ushort simpleTypeIndex, byte fileFormatVersion)
        {
            _attributeUse = attributeUse;
            _simpleTypeIndex = simpleTypeIndex;
            _fileFormatVersion = fileFormatVersion;
        }

        /// <summary>
        /// Gets the xsd:use value.
        /// </summary>
        public XsdAttributeUse AttributeUse => _attributeUse;

        /// <summary>
        /// Gets the index of the simple data in the SdbSimpleTypeRestriction data array.
        /// </summary>
        public ushort SimpleTypeIndex => _simpleTypeIndex;

        /// <summary>
        /// Gets the file format version where this attribute is allowed.
        /// </summary>
        public byte FileFormatVersion => _fileFormatVersion;
    }
}
