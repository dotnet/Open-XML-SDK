// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal static class SdbData
    {
        public const ushort InvalidId = ushort.MaxValue;

        public static byte[] GetBytes(int dataSize, params byte[][] fieldvalues)
        {
            byte[] value = new byte[dataSize];
            int index = 0;

            foreach (var fieldvalue in fieldvalues)
            {
                fieldvalue.CopyTo(value, index);
                index += fieldvalue.Length;
            }

            return value;
        }

        public static int LoadInt(byte[] bytes, ref int startIndex)
        {
            int result = BitConverter.ToInt32(bytes, startIndex);
            startIndex += sizeof(int);
            return result;
        }

        public static ushort LoadSdbIndex(byte[] bytes, ref int startIndex)
        {
            ushort result = BitConverter.ToUInt16(bytes, startIndex);
            startIndex += sizeof(ushort);
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

        public static byte[] Bytes(this int value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] Bytes(this ushort value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] Bytes(this ParticleType value)
        {
            return new byte[1] { (byte)value };
        }

        public static byte[] Bytes(this XsdAttributeUse value)
        {
            return new byte[1] { (byte)value };
        }

        public static byte[] Bytes(this byte value)
        {
            return new byte[1] { value };
        }
    }
}
