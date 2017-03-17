// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.WorkBookPr
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Spreadsheet;
    using X15 = DocumentFormat.OpenXml.Office2013.Excel;
    using X15ac = DocumentFormat.OpenXml.Office2013.ExcelAc;
    using LogUtil;

    public class TestEntities
    {
        private string workbookPrExtUri { get; set; }
        private string AbsolutePathUri { get; set; }

        public TestEntities(string filePath)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                X15.WorkbookProperties workbookProperties = package.WorkbookPart.Workbook.Descendants<X15.WorkbookProperties>().FirstOrDefault();
                if (workbookProperties == null)
                    throw new Exception("Unable to obtain the X15.WorkbookProperties.");

                WorkbookExtension workbookExtension = (WorkbookExtension)workbookProperties.Parent;
                this.workbookPrExtUri = workbookExtension.Uri;

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                if (absolutePath == null)
                    throw new Exception("Unable to obtain the X15ac.AbsolutePath.");

                this.AbsolutePathUri = absolutePath.Url;
            }
        }

        /// <summary>
        /// Editing workbookPr element
        /// </summary>
        /// <param name="filePath">Target Excel file path</param>
        /// <param name="log">Logger</param>
        public void EditElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                X15.WorkbookProperties workbookProperties = workbookExtensionList.Descendants<X15.WorkbookProperties>().Single();
                workbookProperties.ChartTrackingReferenceBase.Value = false;

                log.Pass("Edited ChartTrackingReferenceBase value.");

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                log.Verify(absolutePath != null, "Unable to obtain the X15ac.AbsolutePath.");
                absolutePath.Url = "";
            }
        }

        /// <summary>
        /// Verifying the workbookPr element the existence
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void VerifyElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                X15.WorkbookProperties workbookProperties = workbookExtensionList.Descendants<X15.WorkbookProperties>().Single();

                log.Verify(workbookProperties.ChartTrackingReferenceBase.Value == false, "UnChanged in the ChartTrackingReferenceBase attribute value on workbookPr element.");

                X15ac.AbsolutePath absolutePath = package.WorkbookPart.Workbook.AbsolutePath;
                log.Verify(absolutePath != null, "Unable to obtain the X15ac.AbsolutePath.");
                log.Verify(absolutePath.Url == "", "X15ac.AbsolutePath uri value is not change.");
            }
        }

        /// <summary>
        /// Deleting workbookPr element
        /// </summary>
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void DeleteElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                WorkbookExtensionList workbookExtensionList = package.WorkbookPart.Workbook.Descendants<WorkbookExtensionList>().Single();
                X15.WorkbookProperties workbookProperties = workbookExtensionList.Descendants<X15.WorkbookProperties>().Single();
                workbookProperties.Remove();

                WorkbookExtension workbookExtension = workbookExtensionList.Descendants<WorkbookExtension>().Where(e => e.Uri == this.workbookPrExtUri).Single();
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
        /// <param name="filePath">Target Excel file path</param>
        /// <param name="log">Logger</param>
        public void VerifyDeleteElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                int workbookExtensionNum = package.WorkbookPart.Workbook.Descendants<WorkbookExtension>().Where(e => e.Uri == this.workbookPrExtUri).Count();
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
        /// <param name="filePath">Target excel faile path</param>
        /// <param name="log">Logger</param>
        public void AddElement(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
            {
                package.WorkbookPart.Workbook.AbsolutePath = null;
                X15ac.AbsolutePath absolutePath = new X15ac.AbsolutePath() { Url = this.AbsolutePathUri };
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
                WorkbookExtension workbookExtension = new WorkbookExtension() { Uri = this.workbookPrExtUri };
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
        /// <param name="filePath">Target Excel faile path</param>
        /// <param name="log">Logger</param>
        public void VerifyAddElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013) }))
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
