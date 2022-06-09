// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
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
        AddIn,
    }
}
