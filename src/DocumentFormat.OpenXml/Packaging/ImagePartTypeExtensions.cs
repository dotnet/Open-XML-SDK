// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;


namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Provides extensions to working with ImagePart and ImagePartType
    /// </summary>
    public static class ImagePartExtensions
    {
        /// <summary>
        /// Extends an overloaded AddImagePart method that
        /// handles the process of determining the ImagePartType
        /// for you based on a provided file extension.
        /// </summary>
        /// <param name="main">The source MainDocumentPart that is adding the ImagePart.</param>
        /// <param name="extension">The file extension of the image.</param>
        public static ImagePart AddImagePart(this MainDocumentPart main, string extension) =>
            main.AddImagePart(GetImagePartType(extension));

        /// <summary>
        /// Given a file extension, retrieve the associated ImagePartType value.
        /// </summary>
        /// <param name="extension">A file extension supported by ImagePartType.</param>    
        public static ImagePartType GetImagePartType(this string extension)
            => extension.ToLower() switch
            {
                ".bmp" => ImagePartType.Bmp,
                ".emf" => ImagePartType.Emf,
                ".ico" => ImagePartType.Icon,
                ".jpg" => ImagePartType.Jpeg,
                ".jpeg" => ImagePartType.Jpeg,
                ".pcx" => ImagePartType.Pcx,
                ".png" => ImagePartType.Png,
                ".svg" => ImagePartType.Svg,
                ".tiff" => ImagePartType.Tiff,
                ".wmf" => ImagePartType.Wmf,
                _ => throw new NotSupportedException($"{extension} is not supported")
            };
    }
}