// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Text;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    // TODO: consider a hash verify for the data
    // System.Security.Cryptography.MD5CryptoServiceProvider for MD5 hash
    // or System.Security.Cryptography.SHA256 hash

    internal class SdbDataHead : SdbData
    {
        public const int HeadSize = 128;
        public const int SignatureSize = 16;
        public const int LatestDataVersion = 0x00010000;

        public static byte[] SignatureConst
        {
            get
            {
                byte[] signatureConst = Encoding.ASCII.GetBytes("OPENXML SCHM    ");
                return signatureConst;
            }
        }

        public byte[] Signature { get; set; }

        //public byte[]
        public int DataVersion { get; set; }

        /// <summary>
        /// Gets or sets size in byte of the schema constraint data, exclude the DataHead.
        /// </summary>
        public int DataByteCount { get; set; }

        /// <summary>
        /// Gets or sets the first class ID.
        /// </summary>
        public int StartClassId { get; set; }

        public int ClassIdsCount { get; set; }

        public int ClassIdsDataOffset { get; set; }

        public int SchemaTypeCount { get; set; }

        public int SchemaTypeDataOffset { get; set; }

        public int ParticleCount { get; set; }

        public int ParticleDataOffset { get; set; }

        public int ParticleChildrenIndexCount { get; set; }

        public int ParticleChildrenIndexDataOffset { get; set; }

        public int AttributeCount { get; set; }

        public int AttributeDataOffset { get; set; }

        public int SimpleTypeCount { get; set; }

        public int SimpleTypeDataOffset { get; set; }

        /// <summary>
        /// Convert the data of this class (all fields) into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public override byte[] GetBytes()
        {
            byte[] headbytes = new byte[HeadSize];

            // !!!!Caution: keep the order of the following code lines!!!!
            var data = GetBytes(Signature,
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

            data.CopyTo(headbytes, 0);

            return headbytes;
        }

        /// <summary>
        /// Load the fields data from byte data.
        /// </summary>
        /// <param name="value">The byte data array.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public override void LoadFromBytes(byte[] value, int startIndex)
        {
            Signature = new byte[SignatureSize];
            Array.Copy(value, startIndex, Signature, 0, SignatureSize);
            startIndex += SignatureSize;

            for (int i = 0; i < SignatureSize; i++)
            {
                if (Signature[i] != SignatureConst[i])
                {
                    // TODO: change to resource string
                    throw new InvalidDataException("Invalid schema constraint data.");
                }
            }

            // !!!!Caution: keep the order of the following code lines!!!!
            DataVersion = SdbData.LoadInt(value, ref startIndex);
            DataByteCount = SdbData.LoadInt(value, ref startIndex);

            if (DataVersion != LatestDataVersion)
            {
                // TODO: change to resource string
                throw new InvalidDataException("Invalid schema constraint data.");
            }

            StartClassId = SdbData.LoadInt(value, ref startIndex);

            ClassIdsCount = SdbData.LoadInt(value, ref startIndex);
            ClassIdsDataOffset = SdbData.LoadInt(value, ref startIndex);

            SchemaTypeCount = SdbData.LoadInt(value, ref startIndex);
            SchemaTypeDataOffset = SdbData.LoadInt(value, ref startIndex);

            ParticleCount = SdbData.LoadInt(value, ref startIndex);
            ParticleDataOffset = SdbData.LoadInt(value, ref startIndex);

            ParticleChildrenIndexCount = SdbData.LoadInt(value, ref startIndex);
            ParticleChildrenIndexDataOffset = SdbData.LoadInt(value, ref startIndex);

            AttributeCount = SdbData.LoadInt(value, ref startIndex);
            AttributeDataOffset = SdbData.LoadInt(value, ref startIndex);

            SimpleTypeCount = SdbData.LoadInt(value, ref startIndex);
            SimpleTypeDataOffset = SdbData.LoadInt(value, ref startIndex);
        }

        public override int DataSize
        {
            get { return HeadSize; }
        }
    }
}
