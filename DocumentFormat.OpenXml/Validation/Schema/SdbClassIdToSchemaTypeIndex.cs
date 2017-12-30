// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

/**********************************************************
 * Define data struct for schema constraint binary database
 **********************************************************/

using System.Diagnostics;

using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Map OpenXmlElement class ID to schema type in schema.
    /// </summary>
    [DebuggerDisplay("ClassId={ClassId}")]
    internal class SdbClassIdToSchemaTypeIndex : SdbData
    {
        /// <summary>
        /// Start ID of class ID.
        /// </summary>
        public const SdbIndex StartClassId = 10001;

        public const SdbIndex InvalidSchemaTypeIndex = SdbIndex.MaxValue;

        /// <summary>
        /// Gets or sets class ID (Element Type ID).
        /// </summary>
        public SdbIndex ClassId { get; set; }

        /// <summary>
        /// Gets or sets the index of the schema type in the SdbSchemaType data array.
        /// </summary>
        public SdbIndex SchemaTypeIndex { get; set; }

        /// <summary>
        /// Initializes a new instance of the SdbClassIdToSchemaTypeIndex.
        /// </summary>
        public SdbClassIdToSchemaTypeIndex()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SdbClassIdToSchemaTypeIndex.
        /// </summary>
        /// <param name="classId"></param>
        /// <param name="schemaTypeIndex"></param>
        public SdbClassIdToSchemaTypeIndex(SdbIndex classId, SdbIndex schemaTypeIndex)
        {
            this.ClassId = classId;
            this.SchemaTypeIndex = schemaTypeIndex;
        }

        /// <summary>
        /// Return the index of the data in the data array. The data array is sorted by the class ID and the class ID is continuous.
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public static SdbIndex ArrayIndexFromClassId(SdbIndex classId)
        {
            Debug.Assert(classId >= StartClassId);
            return (SdbIndex)(classId - StartClassId);
        }

        /// <summary>
        /// Gets the size in bytes of this data structure.
        /// </summary>
        public static int TypeSize => sizeof(SdbIndex) * 2;

        #region Override SdbData Members

        /// <summary>
        /// Gets the size in bytes of this data structure.
        /// </summary>
        public override int DataSize => TypeSize;

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            return this.GetBytes(this.ClassId.Bytes(),
                                 this.SchemaTypeIndex.Bytes());
        }

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            // !!!!Caution: keep the order of the following code lines!!!!
            this.ClassId = LoadSdbIndex(value, ref startIndex);
            this.SchemaTypeIndex = LoadSdbIndex(value, ref startIndex);
        }

        #endregion
    }
}
