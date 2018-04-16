// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines WordprocessingDocumentType - type of WordprocessingDocument.
    /// </summary>
    public enum WordprocessingDocumentType
    {
        /// <summary>
        /// Word Document (*.docx).
        /// </summary>
        Document,

        /// <summary>
        /// Word Template (*.dotx).
        /// </summary>
        Template,

        /// <summary>
        /// Word Macro-Enabled Document (*.docm).
        /// </summary>
        MacroEnabledDocument,

        /// <summary>
        /// Word Macro-Enabled Template (*.dotm).
        /// </summary>
        MacroEnabledTemplate,
    }
}
