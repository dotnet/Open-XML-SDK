// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
	/// <summary>
	/// Defines ImagePartType - types of ImagePart.
	///
	/// <![CDATA[
	/// L".bin",    L"image/unknown",
	/// L".bmp",    L"image/bmp",
	/// L".gif",    L"image/gif",
	/// L".png",    L"image/png",
	/// L".jp2",    L"image/jp2",
	/// L".tif",    L"image/tif",
	/// L".tiff",   L"image/tiff",
	/// L".xbm",    L"image/xbm",
	/// L".ico",    L"image/x-icon",
	/// L".pcx",    L"image/x-pcx",
	/// L".pcz",    L"image/x-pcz",
	/// // Note: EMZ and WMZ should never be used.
	/// L".emz",    L"image/x-emz",
	/// L".wmz",    L"image/x-wmz",
	/// // Note: Jpeg-Wmf are used by thumbnail.  Don't add between them
	/// L".jpeg",   L"image/jpeg",
	/// L".emf",    L"image/x-emf",
	/// L".wmf",    L"image/x-wmf",
	/// L".svg",    L"image/svg+xml",
	/// ]]>
	/// </summary>
	public static class ImagePartType
    {
        /// <summary>
        /// Defines type information for Bmp image part.
        /// </summary>
        public static readonly PartTypeInfo Bmp = new("image/bmp", ".bmp");

        /// <summary>
        /// Defines type information for Gif image part.
        /// </summary>
        public static readonly PartTypeInfo Gif = new("image/gif", ".gif");

        /// <summary>
        /// Defines type information for Png image part.
        /// </summary>
        public static readonly PartTypeInfo Png = new("image/png", ".png");

		/// <summary>
		/// Defines type information for Tif image part.
		/// </summary>
		public static readonly PartTypeInfo Tif = new("image/tif", ".tif");

		/// <summary>
		/// Defines type information for Tiff image part.
		/// </summary>
		public static readonly PartTypeInfo Tiff = new("image/tiff", ".tiff");

        ///// <summary>
        ///// X Bitmap Graphic (.xbm).
        ///// </summary>
        // Xbm,

        /// <summary>
        /// Defines type information for Icon image part.
        /// </summary>
        public static readonly PartTypeInfo Icon = new("image/x-icon", ".ico");

        /// <summary>
        /// Defines type information for Pcx image part.
        /// </summary>
        public static readonly PartTypeInfo Pcx = new("image/x-pcx", ".pcx");

        ///// <summary>
        ///// Compressed Macintosh PICT (.pcz).
        ///// </summary>
        // Pcz,
        // Emz,
        // Wmz,
        ///// <summary>
        ///// Macintosh Quickdraw/PICT Drawing (.pict).
        ///// </summary>
        // Pict,

        /// <summary>
        /// Defines type information for Jpeg image part.
        /// </summary>
        public static readonly PartTypeInfo Jpeg = new("image/jpeg", ".jpg");

		/// <summary>
		/// Defines type information for Jpeg image part.
		/// </summary>
		public static readonly PartTypeInfo Jp2 = new("image/jp2", ".jp2");

		/// <summary>
		/// Defines type information for Emf image part.
		/// </summary>
		public static readonly PartTypeInfo Emf = new("image/x-emf", ".emf");

        /// <summary>
        /// Defines type information for Wmf image part.
        /// </summary>
        public static readonly PartTypeInfo Wmf = new("image/x-wmf", ".wmf");

        /// <summary>
        /// Defines type information for Svg image part.
        /// </summary>
        public static readonly PartTypeInfo Svg = new("image/svg+xml", ".svg");
    }
}
