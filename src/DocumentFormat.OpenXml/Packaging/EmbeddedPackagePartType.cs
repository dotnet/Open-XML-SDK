// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
	/// <summary>
	/// Defines EmbeddedPackagePartType - types of EmbeddedPackagePart.
	///
	/// Data from "dev12\msoutilstat\src\metro.cpp":
	///
	/// <![CDATA[
	/// L".bin",    L"image/unknown",
	/// L".docm",    L"image/bmp",
	/// L".docx",    L"image/gif",
	/// L".dotm",    L"image/png",
	/// L".dotx",   L"image/tiff",
	/// L".potm",    L"image/xbm",
	/// L".potx",    L"image/x-icon",
	/// L".ppam",    L"image/x-pcx",
	/// L".ppsm",    L"image/x-pcz",
	/// L".ppsx",    L"image/x-emz",
	/// L".pptm",    L"image/x-wmz",
	/// L".pptx",   L"image/jpeg",
	/// L".sldm",    L"image/x-emf",
	/// L".sldx",    L"image/x-wmf",
	/// L".thmx",    L"image/svg+xml",
	/// L".xlam",    L"image/x-wmz",
	/// L".xlsb",   L"image/jpeg",
	/// L".xlsm",   L"image/jpeg",
	/// L".xlsx",    L"image/x-emf",
	/// L".xltm",    L"image/x-wmf",
	/// L".xltx",    L"image/svg+xml",
	/// ]]>
	/// </summary>
	public enum EmbeddedPackagePartType
	{
		/// <summary>
		/// Office Open XML macro-enabled document (.docm).
		/// </summary>
		Docm,

		/// <summary>
		/// Office Open XML document (.docx).
		/// </summary>
		Docx,

		/// <summary>
		/// Office Open XML macro-enabled document template (.dotm).
		/// </summary>
		Dotm,

		/// <summary>
		/// Office Open XML document template (.dotx).
		/// </summary>
		Dotx,

		/// <summary>
		/// Office Open XML macro-enabled presentation template (.potm).
		/// </summary>
		Potm,

		/// <summary>
		/// Office Open XML presentation template (.potx).
		/// </summary>
		Potx,

		/// <summary>
		/// Office Open XML macro-enabled presentation add-in (.ppam).
		/// </summary>
		Ppam,

		/// <summary>
		/// Office Open XML macroe-enabled show (.ppsm).
		/// </summary>
		Ppsm,

		/// <summary>
		/// Office Open XML show (.ppsx).
		/// </summary>
		Ppsx,

		/// <summary>
		/// Office Open XML macro-enabled presentation (.pptm).
		/// </summary>
		Pptm,

		/// <summary>
		/// Office Open XML presentation (.pptx).
		/// </summary>
		Pptx,

		/// <summary>
		/// Office Open XML macro-enabled slide (.sldm).
		/// </summary>
		Sldm,

		/// <summary>
		/// Office Open XML slide (.sldx).
		/// </summary>
		Sldx,

		/// <summary>
		/// Office Open XML office theme (.thmx).
		/// </summary>
		Thmx,

		/// <summary>
		/// Office Open XML macro-enabled add-in (.xlam).
		/// </summary>
		Xlam,

		/// <summary>
		/// Office Open XML binary workbook (.xlsb).
		/// </summary>
		Xlsb,

		/// <summary>
		/// Office Open XML macro-enabled workbook (.xlsm).
		/// </summary>
		Xlsm,

		/// <summary>
		/// Office Open XML workbook (.xlsx).
		/// </summary>
		Xlsx,

		/// <summary>
		/// Office Open XML macro-enabled workbook template (.xltm).
		/// </summary>
		Xltm,

		/// <summary>
		/// Office Open XML workbook template (.xltx).
		/// </summary>
		Xltx,
	}
}
