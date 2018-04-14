// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// A proxy class for <see cref="System.Runtime.InteropServices.Marshal"/> that provides generic overloads for .NET 3.5
    /// and 4.0 as the non-generic overloads are obsolete on newer versions of the framework
    /// </summary>
    internal static class Marshal
    {
        public static int SizeOf<T>()
            where T : struct
        {
            return System.Runtime.InteropServices.Marshal.SizeOf(typeof(T));
        }

        public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
        {
            System.Runtime.InteropServices.Marshal.Copy(source, startIndex, destination, length);
        }

        public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
        {
            System.Runtime.InteropServices.Marshal.Copy(source, destination, startIndex, length);
        }

        public static IntPtr AllocHGlobal(int cb)
        {
            return System.Runtime.InteropServices.Marshal.AllocHGlobal(cb);
        }

        public static void FreeHGlobal(IntPtr hglobal)
        {
            System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal);
        }

        public static T PtrToStructure<T>(IntPtr ptr)
        {
            return (T)System.Runtime.InteropServices.Marshal.PtrToStructure(ptr, typeof(T));
        }
    }
}
