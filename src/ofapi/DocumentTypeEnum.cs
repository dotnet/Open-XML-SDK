// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;

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
        MacroEnabledTemplate
    }

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

    /// <summary>
    /// Defines PresentationDocumentType - type of PresentationDocument.
    /// </summary>
    public enum PresentationDocumentType
    {
        /// <summary>
        /// PowerPoint Presentation (*.pptx).
        /// </summary>
        Presentation,

        /// <summary>
        /// PowerPoint Template (*.potx).
        /// </summary>
        Template,

        /// <summary>
        /// PowerPoint Show (*.ppsx).
        /// </summary>
        Slideshow,

        /// <summary>
        /// PowerPoint Macro-Enabled Presentation (*.pptm).
        /// </summary>
        MacroEnabledPresentation,

        /// <summary>
        /// PowerPoint Macro-Enabled Template (*.potm).
        /// </summary>
        MacroEnabledTemplate,

        /// <summary>
        /// PowerPoint Macro-Enabled Show (*.ppsm).
        /// </summary>
        MacroEnabledSlideshow,

        /// <summary>
        /// PowerPoint Add-In (*.ppam).
        /// </summary>
        AddIn        
    }
}
