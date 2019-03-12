// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Map OpenXmlElement class ID to schema type in schema.
    /// </summary>
    /// <remarks>
    /// We cannot use auto-properties here due to failure in .NET Native to compile them. For further details, https://github.com/OfficeDev/Open-XML-SDK/issues/567.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [DebuggerDisplay("ClassId={ClassId}")]
    internal readonly struct SdbClassIdToSchemaTypeIndex
    {
        public const ushort StartClassId = 10001;

        private readonly ushort _classId;
        private readonly ushort _schemaTypeIndex;

        /// <summary>
        /// Initializes an instance of <see cref="SdbClassIdToSchemaTypeIndex"/>
        /// </summary>
        public SdbClassIdToSchemaTypeIndex(ushort classId, ushort typeIndex)
        {
            _classId = classId;
            _schemaTypeIndex = typeIndex;
        }

        /// <summary>
        /// Gets class ID (Element Type ID).
        /// </summary>
        public ushort ClassId => _classId;

        /// <summary>
        /// Gets the index of the schema type in the SdbSchemaType data array.
        /// </summary>
        public ushort SchemaTypeIndex => _schemaTypeIndex;
    }
}
