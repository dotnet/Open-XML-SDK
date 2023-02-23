// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// A collection of extensions for <see cref="SpreadsheetDocument"/>
/// </summary>
public static class SpreadsheetDocumentExtensions
{
    /// <summary>
    /// Sets up the <paramref name="spreadsheet"/> to ignore any <see cref="CalculationChainPart"/> relationships if the part is not there.
    /// </summary>
    public static void IgnoreCalcChainIfMissing(this SpreadsheetDocument spreadsheet)
        => spreadsheet.UseIgnoreRelationship("http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain");
}
