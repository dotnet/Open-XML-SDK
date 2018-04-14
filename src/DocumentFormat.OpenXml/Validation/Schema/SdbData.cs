// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Runtime.InteropServices;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    internal static class SdbData
    {
        public const ushort InvalidId = ushort.MaxValue;

        public static void Serialize<T>(T[] data, Stream stream)
            where T : struct
        {
            var bytes = Serialize(data);
            stream.Write(bytes, 0, bytes.Length);
        }

        public static void Serialize<T>(T instance, Stream stream)
            where T : struct
        {
            Serialize(new[] { instance }, stream);
        }

        public static byte[] Serialize<T>(T[] data)
            where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var length = size * data.Length;
            var bytes = new byte[length];
            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            try
            {
                Marshal.Copy(handle.AddrOfPinnedObject(), bytes, 0, length);
                return bytes;
            }
            finally
            {
                handle.Free();
            }
        }

        public static T Deserialize<T>(Stream stream)
            where T : struct
        {
            var size = Marshal.SizeOf<T>();

            var bytes = new byte[size];
            var read = stream.Read(bytes, 0, size);

            if (read != size)
            {
                throw new InvalidDataException();
            }

            var ptr = Marshal.AllocHGlobal(size);

            try
            {
                Marshal.Copy(bytes, 0, ptr, size);
                return Marshal.PtrToStructure<T>(ptr);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static T[] Deserialize<T>(Stream stream, in SdbSpan span)
            where T : struct
        {
            if (span.Offset != stream.Position)
            {
                throw new InvalidDataException();
            }

            var bytes = new byte[span.Length];
            var read = stream.Read(bytes, 0, span.Length);

            if (read != span.Length)
            {
                throw new InvalidDataException();
            }

            var size = Marshal.SizeOf<T>();
            var array = new T[span.Count];
            var handle = GCHandle.Alloc(array, GCHandleType.Pinned);

            try
            {
                Marshal.Copy(bytes, 0, handle.AddrOfPinnedObject(), span.Length);
                return array;
            }
            finally
            {
                handle.Free();
            }
        }
    }
}
