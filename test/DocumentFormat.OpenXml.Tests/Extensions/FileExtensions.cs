// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using OxTest;
using System;
using System.Collections.Generic;
using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    public static class FileExtensions
    {
        private static readonly HashSet<string> _wordprocessingExtension = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".docx", ".docm", ".dotx", ".dotm" };
        private static readonly HashSet<string> _spreadsheetExtension = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".xlam", ".xltm", ".xlsm", ".xltx", ".xlsx" };
        private static readonly HashSet<string> _presentationExtension = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".ppam", ".pptm", ".ppsm", ".potm", ".pptx", ".ppsx", ".potx" };

        /// <summary> Check if the file is of OpenXml package extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml package extension, otherwise return false.</returns>
        public static bool IsOpenXmlFile(this FileInfo file)
        {
            return IsWordprocessingFile(file)
                || IsSpreadsheetFile(file)
                || IsPresentationFile(file);
        }

        /// <summary> Check if the file is of OpenXml Wordprocessing document extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml Wordprocessing document extension, otherwise return false.</returns>
        public static bool IsWordprocessingFile(this FileInfo file)
        {
            return _wordprocessingExtension.Contains(file.Extension);
        }

        public static bool IsWordprocessingFile(this IFile file)
        {
            return _wordprocessingExtension.Contains(System.IO.Path.GetExtension(file.Path));
        }

        /// <summary> Check if the file is of OpenXml Speadsheet document extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml Speadsheet document extension, otherwise return false.</returns>
        public static bool IsSpreadsheetFile(this FileInfo file)
        {
            return _spreadsheetExtension.Contains(file.Extension);
        }

        public static bool IsSpreadsheetFile(this IFile file)
        {
            return _spreadsheetExtension.Contains(System.IO.Path.GetExtension(file.Path));
        }

        /// <summary> Check if the file is of OpenXml Presentation document extension.</summary>
        /// <param name="file">current file</param>
        /// <returns>True if it's with OpenXml Presentation document extension, otherwise return false.</returns>
        public static bool IsPresentationFile(this FileInfo file)
        {
            return _presentationExtension.Contains(file.Extension);
        }

        public static bool IsPresentationFile(this IFile file)
        {
            return _presentationExtension.Contains(System.IO.Path.GetExtension(file.Path));
        }

        /// <summary> Get a copy of pass in file </summary>
        /// <param name="file">File to be copied</param>
        /// <returns>Copy of pass in file</returns>
        public static FileInfo GetCopy(this FileInfo file)
        {
            if (!file.Exists)
            {
                throw new FileNotFoundException(string.Format("Specified file {0} does not exist.", file.Name));
            }

            var copy = System.IO.Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + file.Extension);

            file.CopyTo(copy, true);

            return new FileInfo(copy);
        }

        internal static OpenXmlPackage Open(this IFile file, bool isEditable)
        {
            return Open(file, isEditable, new OpenSettings());
        }

        internal static OpenXmlPackage Open(this IFile file, bool isEditable, OpenSettings settings)
        {
            if (file.IsWordprocessingFile())
            {
                return WordprocessingDocument.Open(file.Open(), isEditable, settings);
            }
            else if (file.IsSpreadsheetFile())
            {
                return SpreadsheetDocument.Open(file.Open(), isEditable, settings);
            }
            else if (file.IsPresentationFile())
            {
                return PresentationDocument.Open(file.Open(), isEditable, settings);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Open specified existing OpenXmlPackage.
        /// </summary>
        /// <param name="file">File to be opened</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <returns>OpenXmlPackage instance for opened package</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable)
        {
            return OpenPackage(file, writable, new OpenSettings());
        }

        /// <summary>
        /// Open specified exsting package.
        /// </summary>
        /// <param name="file">File to be opened.</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <param name="autosave">Save changes automatically when closing package.</param>
        /// <returns>OpenXmlPackage instance for opened package</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable, bool autosave)
        {
            return OpenPackage(file, writable, new OpenSettings { AutoSave = autosave });
        }

        /// <summary>
        /// Open specified existing package.
        /// </summary>
        /// <param name="file">File to be opened.</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <returns>OpenXmlPackage instance for opened package.</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable, FileFormatVersions format, MarkupCompatibilityProcessMode mcProcessMode)
        {
            var settings = new OpenSettings()
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mcProcessMode, format)
            };

            return OpenPackage(file, writable, settings);
        }

        /// <summary>
        /// Open specified existing package.
        /// </summary>
        /// <param name="file">File to be opened.</param>
        /// <param name="writable">Open package in read/write mode if true, false for readonly.</param>
        /// <param name="settings">Settings on AutoSave, MaxCharactersInPart, MarkupCompatibilityProcessSettings and ProcessMCInWholePackage.</param>
        /// <returns>OpenXmlPackage instance for opened package.</returns>
        public static OpenXmlPackage OpenPackage(this FileInfo file, bool writable, OpenSettings settings)
        {
            if (!file.Exists)
            {
                throw new FileNotFoundException(string.Format("Specified file {0} does not exist.", file.Name));
            }

            if (IsWordprocessingFile(file))
            {
                return WordprocessingDocument.Open(file.FullName, writable, settings);
            }
            else if (IsSpreadsheetFile(file))
            {
                return SpreadsheetDocument.Open(file.FullName, writable, settings);
            }
            else if (IsPresentationFile(file))
            {
                return PresentationDocument.Open(file.FullName, writable, settings);
            }
            else
            {
                throw new Exception("Not Supported Document Type!");
            }
        }

        public static OpenXmlPackage CreatePackage(this FileInfo file, Boolean overwiteIfExist)
        {
            if (file.Exists)
            {
                throw new InvalidOperationException(String.Format("The file {0} exists!!", file.FullName));
            }

            if (IsWordprocessingFile(file))
            {
                return WordprocessingDocument.Create(file.FullName, WordprocessingDocumentType.Document);
            }
            else if (IsSpreadsheetFile(file))
            {
                return SpreadsheetDocument.Create(file.FullName, SpreadsheetDocumentType.Workbook);
            }
            else if (IsPresentationFile(file))
            {
                return PresentationDocument.Create(file.FullName, PresentationDocumentType.Presentation);
            }
            else
            {
                throw new Exception("Not Supported Document Type!");
            }
        }

        public static void CreateIfNotExist(this DirectoryInfo dir)
        {
            if (dir == null)
                throw new ArgumentNullException();

            if (!dir.Exists)
            {
                dir.Parent.CreateIfNotExist();
                dir.Create();
            }
        }
    }
}
