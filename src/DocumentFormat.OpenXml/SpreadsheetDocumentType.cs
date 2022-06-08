// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines SpreadsheetDocumentType - type of SpreadsheetDocument.
    /// </summary>
    public enum SpreadsheetDocumentType
    {
        /// <summary>
        /// Excel Workbook (*.xlsx).
        /// </summary>
        Workbook,

        /// <summary>
        /// Excel Template (*.xltx).
        /// </summary>
        Template,

        /// <summary>
        /// Excel Macro-Enabled Workbook (*.xlsm).
        /// </summary>
        MacroEnabledWorkbook,

        /// <summary>
        /// Excel Macro-Enabled Template (*.xltm).
        /// </summary>
        MacroEnabledTemplate,

        /// <summary>
        /// Excel Add-In (*.xlam).
        /// </summary>
        AddIn,
    }
}
