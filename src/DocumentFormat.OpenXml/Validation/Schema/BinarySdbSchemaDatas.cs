// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal partial class BinarySdbSchemaDatas : SdbSchemaDatas
    {
        private FileFormatVersions _fileFormat;

        public BinarySdbSchemaDatas(FileFormatVersions fileFormat)
        {
            Debug.Assert(fileFormat.Any());

            SdbDataHead = new SdbDataHead();
            _fileFormat = fileFormat;

            var name = $"DocumentFormat.OpenXml.GeneratedCode.{fileFormat}.constraints";

#if DEBUG
            var names = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceNames();
#endif

            using (var schema = typeof(ValidationResources).GetTypeInfo().Assembly.GetManifestResourceStream(name))
            {
                if (schema == null)
                {
                    var message = string.Format(System.Globalization.CultureInfo.CurrentUICulture,
                        ExceptionMessages.FileFormatNotSupported,
                        fileFormat);

                    throw new ArgumentOutOfRangeException(nameof(fileFormat), message);
                }

                Load(schema);
            }
        }

        /// <summary>
        /// Load the schema constraint data from the stream.
        /// </summary>
        /// <param name="dataStream">The data stream.</param>
        internal void Load(Stream dataStream)
        {
            Debug.Assert(dataStream != null);
            Debug.Assert(dataStream.CanRead);
            Debug.Assert(dataStream.CanSeek);
            Debug.Assert(dataStream.Length > SdbDataHead.HeadSize);

            byte[] headBytes = new byte[SdbDataHead.HeadSize];

            dataStream.Read(headBytes, 0, SdbDataHead.HeadSize);
            SdbDataHead.LoadFromBytes(headBytes, 0);

#if DEBUG
            CheckDataHead((int)dataStream.Length);
#endif

            byte[] dataBytes;
            int count;

            // class ID map
            count = SdbDataHead.ClassIdsCount * SdbClassIdToSchemaTypeIndex.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            SdbClassIdMap = new SdbDataArray<SdbClassIdToSchemaTypeIndex>(dataBytes, SdbDataHead.ClassIdsCount);

            // schema types
            count = SdbDataHead.SchemaTypeCount * SdbSchemaType.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            SdbSchemaTypes = new SdbDataArray<SdbSchemaType>(dataBytes, SdbDataHead.SchemaTypeCount);

            // particle constraints
            count = SdbDataHead.ParticleCount * SdbParticleConstraint.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            SdbParticles = new SdbDataArray<SdbParticleConstraint>(dataBytes, SdbDataHead.ParticleCount);

            // particle children index
            count = SdbDataHead.ParticleChildrenIndexCount * SdbParticleChildrenIndex.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            SdbParticleIndexs = new SdbDataArray<SdbParticleChildrenIndex>(dataBytes, SdbDataHead.ParticleChildrenIndexCount);

            // attribute constraints
            count = SdbDataHead.AttributeCount * SdbAttributeConstraint.TypeSize;
            dataBytes = new byte[count];
            dataStream.Read(dataBytes, 0, count);
            SdbAttributes = new SdbDataArray<SdbAttributeConstraint>(dataBytes, SdbDataHead.AttributeCount);

            // simple type constraints
            dataStream.Seek(SdbDataHead.SimpleTypeDataOffset, SeekOrigin.Begin);
            SimpleTypeRestrictions = Restrictions.SimpleTypeRestrictions.Deserialize(dataStream, _fileFormat);

#if DEBUG
            Assert(SdbDataHead.SimpleTypeCount == SimpleTypeRestrictions.SimpleTypeCount);

            CheckData();
#endif
        }

        /// <summary>
        /// Get a SdbClassIdToSchemaTypeIndex data for the specified class ID.
        /// </summary>
        /// <param name="classId">The class ID.</param>
        /// <returns>A SdbClassIdToSchemaTypeIndex data.</returns>
        private SdbClassIdToSchemaTypeIndex GetClassIdData(ushort classId)
        {
            int index = SdbClassIdToSchemaTypeIndex.ArrayIndexFromClassId(classId);
            return SdbClassIdMap[index];
        }
    }
}
