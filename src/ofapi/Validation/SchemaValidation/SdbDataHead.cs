// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
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
        /// size in byte of the schema constraint datas, exclude the DataHead.
        /// </summary>
        public int DataByteCount { get; set; }

        /// <summary>
        /// The first class ID.
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
            var data = this.GetBytes(this.Signature,
                          this.DataVersion.Bytes(),
                          this.DataByteCount.Bytes(),

                          this.StartClassId.Bytes(),

                          this.ClassIdsCount.Bytes(),
                          this.ClassIdsDataOffset.Bytes(),

                          this.SchemaTypeCount.Bytes(),
                          this.SchemaTypeDataOffset.Bytes(),

                          this.ParticleCount.Bytes(),
                          this.ParticleDataOffset.Bytes(),

                          this.ParticleChildrenIndexCount.Bytes(),
                          this.ParticleChildrenIndexDataOffset.Bytes(),

                          this.AttributeCount.Bytes(),
                          this.AttributeDataOffset.Bytes(),

                          this.SimpleTypeCount.Bytes(),
                          this.SimpleTypeDataOffset.Bytes());

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
            this.Signature = new byte[SignatureSize];
            Array.Copy(value, startIndex, this.Signature, 0, SignatureSize);
            startIndex += SignatureSize;

            for (int i = 0; i < SignatureSize; i++)
            {
                if (this.Signature[i] != SignatureConst[i])
                {
                    // TODO: change to resource string
                    throw new InvalidDataException("Invalide schema constraint data.");
                }
            }

            // !!!!Caution: keep the order of the following code lines!!!!
            this.DataVersion = SdbData.LoadInt(value, ref startIndex);
            this.DataByteCount = SdbData.LoadInt(value, ref startIndex);

            if (this.DataVersion != LatestDataVersion)
            {
                // TODO: change to resource string
                throw new InvalidDataException("Invalide schema constraint data.");
            }

            this.StartClassId = SdbData.LoadInt(value, ref startIndex);

            this.ClassIdsCount = SdbData.LoadInt(value, ref startIndex);
            this.ClassIdsDataOffset = SdbData.LoadInt(value, ref startIndex);

            this.SchemaTypeCount = SdbData.LoadInt(value, ref startIndex);
            this.SchemaTypeDataOffset = SdbData.LoadInt(value, ref startIndex);

            this.ParticleCount = SdbData.LoadInt(value, ref startIndex);
            this.ParticleDataOffset = SdbData.LoadInt(value, ref startIndex);

            this.ParticleChildrenIndexCount = SdbData.LoadInt(value, ref startIndex);
            this.ParticleChildrenIndexDataOffset = SdbData.LoadInt(value, ref startIndex);

            this.AttributeCount = SdbData.LoadInt(value, ref startIndex);
            this.AttributeDataOffset = SdbData.LoadInt(value, ref startIndex);

            this.SimpleTypeCount = SdbData.LoadInt(value, ref startIndex);
            this.SimpleTypeDataOffset = SdbData.LoadInt(value, ref startIndex);
        }

        public override int DataSize
        {
            get { return HeadSize; }
        }
    }
}
