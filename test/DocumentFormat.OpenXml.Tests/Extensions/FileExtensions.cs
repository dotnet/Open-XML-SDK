// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    public static class FileExtensions
    {
        private static readonly HashSet<string> _wordprocessingExtension = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ".docx",
            ".docm",
            ".dotx",
            ".dotm",
        };

        private static readonly HashSet<string> _spreadsheetExtension = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ".xlam",
            ".xltm",
            ".xlsm",
            ".xltx",
            ".xlsx",
        };

        private static readonly HashSet<string> _presentationExtension = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ".ppam",
            ".pptm",
            ".ppsm",
            ".potm",
            ".pptx",
            ".ppsx",
            ".potx",
        };

        public static OpenXmlPackage Open(this IFile file, bool isEditable)
        {
            return Open(file, isEditable, new OpenSettings());
        }

        public static OpenXmlPackage Open(this IFile file, bool isEditable, OpenSettings settings)
        {
            var extension = Path.GetExtension(file.Path);

            if (_wordprocessingExtension.Contains(extension))
            {
                return WordprocessingDocument.Open(file.Open(), isEditable, settings);
            }
            else if (_spreadsheetExtension.Contains(extension))
            {
                return SpreadsheetDocument.Open(file.Open(), isEditable, settings);
            }
            else if (_presentationExtension.Contains(extension))
            {
                return PresentationDocument.Open(file.Open(), isEditable, settings);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
