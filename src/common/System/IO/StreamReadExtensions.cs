// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.IO
{
#if !NET7_0_OR_GREATER
    internal static class StreamReadExtensions
    {
        public static void ReadExactly(this Stream source, byte[] destination)
        {
            var totalRead = 0;
            while (totalRead < destination.Length)
            {
                var bytesRead = source.Read(destination, totalRead, destination.Length - totalRead);
                if (bytesRead == 0)
                {
                    break;
                }

                totalRead += bytesRead;
            }
        }
    }
#endif
}
