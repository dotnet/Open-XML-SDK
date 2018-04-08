// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Text;

using static DocumentFormat.OpenXml.Validation.Schema.SdbData;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// The data head of the binary schema constraint data
    /// </summary>
    internal readonly struct SdbDataHead
    {
        public const int HeadSize = 128;

        private const int SignatureSize = 16;
        private const int LatestDataVersion = 0x00010000;

        private static readonly byte[] SignatureConst = Encoding.ASCII.GetBytes("OPENXML SCHM    ");

        /// <summary>
        /// Initializes an instance of <see cref="SdbDataHead"/> that deserializes from data
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbDataHead(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        private SdbDataHead(byte[] value, int startIndex)
        {
            var signature = new byte[SignatureSize];
            Array.Copy(value, startIndex, signature, 0, SignatureSize);
            startIndex += SignatureSize;

            for (int i = 0; i < SignatureSize; i++)
            {
                if (signature[i] != SignatureConst[i])
                {
                    // TODO: change to resource string
                    throw new InvalidDataException("Invalid schema constraint data.");
                }
            }

            DataVersion = LoadInt(value, ref startIndex);
            DataByteCount = LoadInt(value, ref startIndex);

            if (DataVersion != LatestDataVersion)
            {
                // TODO: change to resource string
                throw new InvalidDataException("Invalid schema constraint data.");
            }

            StartClassId = LoadInt(value, ref startIndex);

            ClassIdsCount = LoadInt(value, ref startIndex);
            ClassIdsDataOffset = LoadInt(value, ref startIndex);

            SchemaTypeCount = LoadInt(value, ref startIndex);
            SchemaTypeDataOffset = LoadInt(value, ref startIndex);

            ParticleCount = LoadInt(value, ref startIndex);
            ParticleDataOffset = LoadInt(value, ref startIndex);

            ParticleChildrenIndexCount = LoadInt(value, ref startIndex);
            ParticleChildrenIndexDataOffset = LoadInt(value, ref startIndex);

            AttributeCount = LoadInt(value, ref startIndex);
            AttributeDataOffset = LoadInt(value, ref startIndex);

            SimpleTypeCount = LoadInt(value, ref startIndex);
            SimpleTypeDataOffset = LoadInt(value, ref startIndex);
        }

        public int DataVersion { get; }

        public int DataByteCount { get; }

        public int StartClassId { get; }

        public int ClassIdsCount { get; }

        public int ClassIdsDataOffset { get; }

        public int SchemaTypeCount { get; }

        public int SchemaTypeDataOffset { get; }

        public int ParticleCount { get; }

        public int ParticleDataOffset { get; }

        public int ParticleChildrenIndexCount { get; }

        public int ParticleChildrenIndexDataOffset { get; }

        public int AttributeCount { get; }

        public int AttributeDataOffset { get; }

        public int SimpleTypeCount { get; }

        public int SimpleTypeDataOffset { get; }

        public static SdbDataHead Deserialize(byte[] value, int startIndex) => new SdbDataHead(value, startIndex);

        /// <summary>
        /// Serializes the instance data to a byte array
        /// </summary>
        /// <remarks>
        /// The order of <see cref="SdbDataHead(byte[], int)"/> and <see cref="Serialize"/> must remain
        /// in sync to facilitate serialization and deserialization of binary data
        /// </remarks>
        public byte[] Serialize()
        {
            return GetBytes(
                HeadSize,
                SignatureConst,
                DataVersion.Bytes(),
                DataByteCount.Bytes(),
                StartClassId.Bytes(),
                ClassIdsCount.Bytes(),
                ClassIdsDataOffset.Bytes(),
                SchemaTypeCount.Bytes(),
                SchemaTypeDataOffset.Bytes(),
                ParticleCount.Bytes(),
                ParticleDataOffset.Bytes(),
                ParticleChildrenIndexCount.Bytes(),
                ParticleChildrenIndexDataOffset.Bytes(),
                AttributeCount.Bytes(),
                AttributeDataOffset.Bytes(),
                SimpleTypeCount.Bytes(),
                SimpleTypeDataOffset.Bytes());
        }
    }
}
