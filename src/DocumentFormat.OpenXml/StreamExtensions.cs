// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;

namespace DocumentFormat.OpenXml
{
    internal static class StreamExtensions
    {
        public static MemoryStream CopyToMemoryStream(this Stream stream)
        {
            if (stream.Length > int.MaxValue)
            {
                throw new OpenXmlPackageException(ExceptionMessages.DocumentTooBig);
            }

            var memoryStream = new MemoryStream(Convert.ToInt32(stream.Length));
            stream.CopyTo(memoryStream);

            return memoryStream;
        }

        public static MemoryStream CopyToMemoryStream(this OpenXmlPart part)
        {
            using (var stream = part.GetStream())
            {
                return stream.CopyToMemoryStream();
            }
        }
    }
}
