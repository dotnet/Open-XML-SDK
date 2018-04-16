// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Map OpenXmlElement class ID to schema type in schema.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [DebuggerDisplay("ClassId={ClassId}")]
    internal readonly struct SdbClassIdToSchemaTypeIndex
    {
        public const ushort StartClassId = 10001;

        /// <summary>
        /// Initializes an instance of <see cref="SdbClassIdToSchemaTypeIndex"/>
        /// </summary>
        public SdbClassIdToSchemaTypeIndex(ushort classId, ushort typeIndex)
        {
            ClassId = classId;
            SchemaTypeIndex = typeIndex;
        }

        /// <summary>
        /// Gets class ID (Element Type ID).
        /// </summary>
        public ushort ClassId { get; }

        /// <summary>
        /// Gets the index of the schema type in the SdbSchemaType data array.
        /// </summary>
        public ushort SchemaTypeIndex { get; }
    }
}
