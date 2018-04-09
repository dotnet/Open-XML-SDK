// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;

using static DocumentFormat.OpenXml.Validation.Schema.SdbData;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Map OpenXmlElement class ID to schema type in schema.
    /// </summary>
    [DebuggerDisplay("ClassId={ClassId}")]
    internal readonly struct SdbClassIdToSchemaTypeIndex
    {
        public static readonly int TypeSize = sizeof(ushort) * 2;

        /// <summary>
        /// Initializes an instance of <see cref="SdbClassIdToSchemaTypeIndex"/>
        /// </summary>
        public SdbClassIdToSchemaTypeIndex(ushort classId, ushort typeIndex)
        {
            ClassId = classId;
            SchemaTypeIndex = typeIndex;
        }

        /// <summary>
        /// Initializes an instance of <see cref="SdbClassIdToSchemaTypeIndex"/> that deserializes from data
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbClassIdToSchemaTypeIndex(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        private SdbClassIdToSchemaTypeIndex(byte[] data, int startIndex)
        {
            ClassId = LoadSdbIndex(data, ref startIndex);
            SchemaTypeIndex = LoadSdbIndex(data, ref startIndex);
        }

        /// <summary>
        /// Gets class ID (Element Type ID).
        /// </summary>
        public ushort ClassId { get; }

        /// <summary>
        /// Gets the index of the schema type in the SdbSchemaType data array.
        /// </summary>
        public ushort SchemaTypeIndex { get; }

#if DEBUG
        public const ushort StartClassId = 10001;

        /// <summary>
        /// Return the index of the data in the data array. The data array is sorted by the class ID and the class ID is continuous.
        /// </summary>
        public static ushort ArrayIndexFromClassId(ushort classId)
        {
            Debug.Assert(classId >= StartClassId);
            return (ushort)(classId - StartClassId);
        }
#endif

        public static SdbClassIdToSchemaTypeIndex Deserialize(byte[] data, int startIndex) => new SdbClassIdToSchemaTypeIndex(data, startIndex);

        /// <summary>
        /// Serializes the instance data to a byte array
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbClassIdToSchemaTypeIndex(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        public byte[] Serialize()
        {
            return GetBytes(
                TypeSize,
                ClassId.Bytes(),
                SchemaTypeIndex.Bytes());
        }
    }
}
