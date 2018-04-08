// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using static DocumentFormat.OpenXml.Validation.Schema.SdbData;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Attribute constraint data.
    /// </summary>
    internal readonly struct SdbAttributeConstraint
    {
        public static readonly int TypeSize =
            sizeof(XsdAttributeUse) +
            sizeof(ushort) +
            sizeof(byte);

        public SdbAttributeConstraint(XsdAttributeUse attributeUse, ushort simpleTypeIndex, byte fileFormatVersion)
        {
            AttributeUse = attributeUse;
            SimpleTypeIndex = simpleTypeIndex;
            FileFormatVersion = fileFormatVersion;
        }

        /// <summary>
        /// Initializes an instance of <see cref="SdbAttributeConstraint"/> that deserializes from data
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbAttributeConstraint(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        private SdbAttributeConstraint(byte[] data, int startIndex)
        {
            AttributeUse = (XsdAttributeUse)LoadByte(data, ref startIndex);
            SimpleTypeIndex = LoadSdbIndex(data, ref startIndex);
            FileFormatVersion = LoadByte(data, ref startIndex);
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

        public static SdbAttributeConstraint Deserialize(byte[] data, int startIndex) => new SdbAttributeConstraint(data, startIndex);

        /// <summary>
        /// Serializes the instance data to a byte array
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbAttributeConstraint(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        public byte[] Serialize()
        {
            return GetBytes(
                TypeSize,
                AttributeUse.Bytes(),
                SimpleTypeIndex.Bytes(),
                FileFormatVersion.Bytes());
        }
    }
}
