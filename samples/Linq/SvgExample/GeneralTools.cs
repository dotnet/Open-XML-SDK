// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using Svg;
using System;
using System.Drawing.Imaging;
using System.IO;

namespace SvgExample
{
    public static class GeneralTools
    {
        public static Stream ReadSvgAsPng(string svgPath)
        {
            var memoryStream = new MemoryStream();

            SvgDocument svgDocument = SvgDocument.Open(svgPath);
            using System.Drawing.Bitmap bitmap = svgDocument.Draw();
            bitmap.Save(memoryStream, ImageFormat.Png);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }

        public static void AddImagePart(SlidePart slidePart, ImagePartType imagePartType, string id, Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            ImagePart imagePart = slidePart.AddImagePart(imagePartType, id);
            imagePart.FeedData(stream);
        }

        public static string GetNewGuidString()
        {
            return string.Concat('{', Guid.NewGuid().ToString().ToUpperInvariant(), '}');
        }
    }
}
