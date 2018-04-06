﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using LogUtil;
using System;
using System.IO;
using System.Linq;
using Xunit;

using X15 = DocumentFormat.OpenXml.Office2013.Excel;
using X15ac = DocumentFormat.OpenXml.Office2013.ExcelAc;

namespace DocumentFormat.OpenXml.Tests.WorkBookPr
{
    public class TestEntities
    {
        private string workbookPrExtUri { get; set; }

        private string AbsolutePathUri { get; set; }

        public TestEntities(Stream stream)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                X15.WorkbookProperties workbookProperties = package.WorkbookPart.Workbook.Descendants<X15.WorkbookProperties>().FirstOrDefault();
                if (workbookProperties == null)
                    throw new Exception("Unable to obtain the X15.WorkbookProperties.");

                WorkbookExtension workbookExtension = (WorkbookExtension)workbookProperties.Parent;
                workbookPrExtUri = workbookExtension.Uri;

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                if (absolutePath == null)
                    throw new Exception("Unable to obtain the X15ac.AbsolutePath.");

                AbsolutePathUri = absolutePath.Url;
            }
        }

        /// <summary>
        /// Editing workbookPr element
        /// </summary>
        public void EditElements(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                X15.WorkbookProperties workbookProperties = workbookExtensionList.Descendants<X15.WorkbookProperties>().Single();
                workbookProperties.ChartTrackingReferenceBase.Value = false;

                log.Pass("Edited ChartTrackingReferenceBase value.");

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                log.Verify(absolutePath != null, "Unable to obtain the X15ac.AbsolutePath.");
                absolutePath.Url = string.Empty;
            }
        }

        /// <summary>
        /// Verifying the workbookPr element the existence
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void VerifyElements(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                X15.WorkbookProperties workbookProperties = workbookExtensionList.Descendants<X15.WorkbookProperties>().Single();

                log.Verify(workbookProperties.ChartTrackingReferenceBase.Value == false, "UnChanged in the ChartTrackingReferenceBase attribute value on workbookPr element.");

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                Assert.NotNull(absolutePath);
                Assert.Equal(string.Empty, absolutePath.Url);
            }
        }

        /// <summary>
        /// Deleting workbookPr element
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void DeleteElements(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                X15.WorkbookProperties workbookProperties = workbookExtensionList.Descendants<X15.WorkbookProperties>().Single();
                workbookProperties.Remove();

                WorkbookExtension workbookExtension = workbookExtensionList.Descendants<WorkbookExtension>().Where(e => e.Uri == workbookPrExtUri).Single();
                workbookExtension.Remove();

                log.Pass("Deleted workbookPr element.");

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                absolutePath.Remove();
                log.Pass("Deleted AbsolutePath element.");
            }
        }

        /// <summary>
        /// Verifying the workbookPr element the deleting
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void VerifyDeleteElements(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                int workbookExtensionNum = package.WorkbookPart.Workbook.Descendants<WorkbookExtension>().Where(e => e.Uri == workbookPrExtUri).Count();
                log.Verify(workbookExtensionNum == 0, "WorkbookExtension element is not deleted.");

                int workbookPrCount = package.WorkbookPart.Workbook.Descendants<X15.WorkbookProperties>().Count();
                log.Verify(workbookPrCount == 0, "workbookPr element is not deleted.");

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                log.Verify(absolutePath == null, "X15ac.AbsolutePath element is not deleted.");
            }
        }

        /// <summary>
        /// Append the workbookpr element
        /// </summary>
        /// <param name="stream">Target excel stream</param>
        /// <param name="log">Logger</param>
        public void AddElement(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                package.WorkbookPart.Workbook.AbsolutePath = null;
                X15ac.AbsolutePath absolutePath = new X15ac.AbsolutePath() { Url = AbsolutePathUri };
                absolutePath.AddNamespaceDeclaration("x15ac", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/ac");

                AlternateContentChoice alternateContentChoice = new AlternateContentChoice() { Requires = "x15" };
                alternateContentChoice.Append(absolutePath);
                log.Pass("Added AbsolutePath element.");

                AlternateContent alternateContent = new AlternateContent();
                alternateContent.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
                alternateContent.Append(alternateContentChoice);

                package.WorkbookPart.Workbook.InsertAfter(alternateContent, package.WorkbookPart.Workbook.Descendants<WorkbookProperties>().First());
                log.Pass("Added AlternateContentChoice element.");

                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                WorkbookExtension workbookExtension = new WorkbookExtension() { Uri = workbookPrExtUri };
                workbookExtension.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");

                X15.WorkbookProperties workbookProperties = new X15.WorkbookProperties();
                workbookProperties.ChartTrackingReferenceBase = false;

                workbookExtension.AppendChild<X15.WorkbookProperties>(workbookProperties);
                workbookExtensionList.AppendChild<WorkbookExtension>(workbookExtension);

                log.Pass("Added workbookPr element.");
            }
        }

        /// <summary>
        /// Verifying the workbookPr element the appending
        /// </summary>
        /// <param name="stream">Target Excel stream</param>
        /// <param name="log">Logger</param>
        public void VerifyAddElements(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                int workbookPrNum = workbookExtensionList.Descendants<X15.WorkbookProperties>().Count();
                log.Verify(workbookPrNum == 1, "Missing workbookPr element.");

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                log.Verify(absolutePath != null, "Missing X15ac.AbsolutePath element.");
            }
        }
    }
}
