// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

/**********************************************************
 * Define data struct for schema constraint binary database
 **********************************************************/

using System;

using SdbIndex = System.UInt16;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Base class for fixed size data.
    /// </summary>
    internal abstract class SdbData
    {
        public const SdbIndex InvalidId = SdbIndex.MaxValue;
        public const int MaxSdbIndex = SdbIndex.MaxValue;

        #region abstract methods

        /// <summary>
        /// Gets the size in bytes of this data structure.
        /// </summary>
        public abstract int DataSize { get; }

        /// <summary>
        /// Serialize the data into byte data.
        /// </summary>
        /// <returns>Byte data.</returns>
        public abstract byte[] GetBytes();

        /// <summary>
        /// Deserialize the data from byte data.
        /// </summary>
        /// <param name="value">The byte data.</param>
        /// <param name="startIndex">The offset the data begins at.</param>
        public abstract void LoadFromBytes(byte[] value, int startIndex);

        #endregion

        /// <summary>
        /// Helper function to be called by derived classes.
        /// </summary>
        /// <param name="fieldvalues"></param>
        /// <returns></returns>
        protected byte[] GetBytes(params byte[][] fieldvalues)
        {
            byte[] value = new byte[this.DataSize];
            int index = 0;

            foreach (var fieldvalue in fieldvalues)
            {
                fieldvalue.CopyTo(value, index);
                index += fieldvalue.Length;
            }

            return value;
        }

        #region Deserialize helper functions
        // deserialize helper functions

        public static int LoadInt(byte[] bytes, ref int startIndex)
        {
            int result = BitConverter.ToInt32(bytes, startIndex);
            startIndex += sizeof(int);
            return result;
        }

        public static SdbIndex LoadSdbIndex(byte[] bytes, ref int startIndex)
        {
            SdbIndex result = BitConverter.ToUInt16(bytes, startIndex);
            startIndex += sizeof(SdbIndex);
            return result;
        }

        public static ushort LoadUInt16(byte[] bytes, ref int startIndex)
        {
            ushort result = BitConverter.ToUInt16(bytes, startIndex);
            startIndex += sizeof(ushort);
            return result;
        }

        public static byte LoadByte(byte[] bytes, ref int startIndex)
        {
            startIndex++;
            return bytes[startIndex - 1];
        }

        #endregion
    }
}
