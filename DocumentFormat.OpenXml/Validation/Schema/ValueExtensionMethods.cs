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
    /// Define some extension methods to make coding clear.
    /// </summary>
    internal static class ValueExtensionMethods
    {
        // serialize methods
        public static byte[] Bytes(this int value)
        {
            return BitConverter.GetBytes(value);
        }

        public static byte[] Bytes(this SdbIndex value)
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
            return new byte[1] { (byte)value };
        }
    }
}
