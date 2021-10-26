// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml
{
    internal static class StreamCopyExtensions
    {
        public static void CopyTo(this Stream source, Stream destination)
        {
            const int BufferSize = 4096;

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var buffer = new byte[BufferSize];
            int bytesRead;

            while ((bytesRead = source.Read(buffer, 0, BufferSize)) > 0)
            {
                destination.Write(buffer, 0, bytesRead);
            }
        }
    }
}
