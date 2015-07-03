// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Open XML document type.
    /// </summary>
    internal enum OpenXmlDocumentType
    {
        Invalid,
        Wordprocessing,
        Spreadsheet,
        Presentation,
    }

    /// <summary>
    /// Detector for Open XML document.
    /// </summary>
    internal static class DocumentTypeDetector
    {
        private const string _mainPartRelationshipType = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
        private static Dictionary<string, OpenXmlDocumentType> _mainPartContentTypes;

        /// <summary>
        /// All known content types for main part in Open XML document.
        /// </summary>
        internal static Dictionary<string, OpenXmlDocumentType> MainPartContentTypes
        {
            get
            {
                if (_mainPartContentTypes == null)
                {
                    var tempData = new Dictionary<string, OpenXmlDocumentType>();

                    // known content types for Office 2007 wordprocessing document 
                    tempData.Add(@"application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml", OpenXmlDocumentType.Wordprocessing);
                    tempData.Add(@"application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml", OpenXmlDocumentType.Wordprocessing);
                    tempData.Add(@"application/vnd.ms-word.document.macroEnabled.main+xml", OpenXmlDocumentType.Wordprocessing);
                    tempData.Add(@"application/vnd.ms-word.template.macroEnabledTemplate.main+xml", OpenXmlDocumentType.Wordprocessing);

                    // known content types for Office 2007 spreadsheet document 
                    tempData.Add(@"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml", OpenXmlDocumentType.Spreadsheet);
                    tempData.Add(@"application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml", OpenXmlDocumentType.Spreadsheet);
                    tempData.Add(@"application/vnd.ms-excel.sheet.macroEnabled.main+xml", OpenXmlDocumentType.Spreadsheet);
                    tempData.Add(@"application/vnd.ms-excel.template.macroEnabled.main+xml", OpenXmlDocumentType.Spreadsheet);
                    tempData.Add(@"application/vnd.ms-excel.addin.macroEnabled.main+xml", OpenXmlDocumentType.Spreadsheet);

                    // known content types for Office 2007 presentation document 
                    tempData.Add(@"application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml", OpenXmlDocumentType.Presentation);
                    tempData.Add(@"application/vnd.openxmlformats-officedocument.presentationml.template.main+xml", OpenXmlDocumentType.Presentation);
                    tempData.Add(@"application/vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml", OpenXmlDocumentType.Presentation);
                    tempData.Add(@"application/vnd.ms-powerpoint.presentation.macroEnabled.main+xml", OpenXmlDocumentType.Presentation);
                    tempData.Add(@"application/vnd.ms-powerpoint.template.macroEnabled.main+xml", OpenXmlDocumentType.Presentation);
                    tempData.Add(@"application/vnd.ms-powerpoint.slideshow.macroEnabled.main+xml", OpenXmlDocumentType.Presentation);
                    tempData.Add(@"application/vnd.ms-powerpoint.addin.macroEnabled.main+xml", OpenXmlDocumentType.Presentation);

                    _mainPartContentTypes = tempData;
                }

                return _mainPartContentTypes;
            }
        }

        /// <summary>
        /// Detect the document type.
        /// </summary>
        /// <param name="openXmlPackage">The Open XML package to be detected.</param>
        /// <returns>The type of the Open XML package.</returns>
        internal static OpenXmlDocumentType GetDocumentType(OpenXmlPackage openXmlPackage)
        {
            if (openXmlPackage is WordprocessingDocument)
            {
                return OpenXmlDocumentType.Wordprocessing;
            }
            else if (openXmlPackage is SpreadsheetDocument)
            {
                return OpenXmlDocumentType.Spreadsheet;
            }
            else if (openXmlPackage is PresentationDocument)
            {
                return OpenXmlDocumentType.Presentation;
            }
            else
            {
                return OpenXmlDocumentType.Invalid;
            }
        }
    }
}
