// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using S = DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentFormat.OpenXml.Tests
{
    public class XlsxTests01
    {
        [Fact]
        public void X008_XlsxCreation_Package_Settings()
        {
            using (var stream = GetStream(TestFiles.Spreadsheet, true))
            using (var package = Package.Open(stream))
            {
                var openSettings = new OpenSettings
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013)
                };

                using (var doc = SpreadsheetDocument.Open(package, openSettings))
                {
                    var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    var cnt = errs.Count();

                    Assert.True(cnt == 1 || cnt == 0);
                }
            }
        }

        [Fact]
        public void X007_SpreadsheetDocument_Open()
        {
            var openSettings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013)
            };

            using (var stream = GetStream(TestFiles.Spreadsheet))
            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 1 || cnt == 0);
            }
        }

        [Fact]
        public void X006_Xlsx_DeleteAdd_CoreExtendedProperties()
        {
            using (var stream = GetStream(TestFiles.Spreadsheet, true))
            using (var doc = SpreadsheetDocument.Open(stream, true))
            {
                var corePart = doc.CoreFilePropertiesPart;
                var appPart = doc.ExtendedFilePropertiesPart;
                doc.DeletePart(corePart);
                doc.DeletePart(appPart);
                doc.AddCoreFilePropertiesPart();
                doc.AddExtendedFilePropertiesPart();
                doc.AddCustomFilePropertiesPart();
                doc.AddDigitalSignatureOriginPart();
                doc.AddExtendedPart("relType", "contentType/xml", ".xml");
                var tnPart = doc.AddThumbnailPart(ThumbnailPartType.Jpeg);
                doc.DeletePart(tnPart);
                tnPart = doc.AddThumbnailPart("image/jpg");

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 1 || cnt == 0);
            }
        }

        [Fact]
        public void X005_XlsxCreation_Package_Settings()
        {
            var openSettings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013)
            };

            using (var stream = GetStream(TestFiles.Spreadsheet, true))
            using (var package = Package.Open(stream))
            using (var doc = SpreadsheetDocument.Open(package, openSettings))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 1 || cnt == 0);
            }
        }

        [Fact]
        public void X004_SpreadsheetDocument_Open()
        {
            var openSettings = new OpenSettings
            {
                MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013)
            };

            using (var stream = GetStream(TestFiles.Spreadsheet, true))
            using (var doc = SpreadsheetDocument.Open(stream, true, openSettings))
            {
                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                var cnt = errs.Count();

                Assert.True(cnt == 1 || cnt == 0);
            }
        }

        [Fact]
        public void X003_XlsxCreation_Stream()
        {
            using (MemoryStream ms = new MemoryStream())
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            using (SpreadsheetDocument doc = SpreadsheetDocument.Create(ms, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookpart = doc.AddWorkbookPart();
                workbookpart.Workbook = new S.Workbook();
                WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new S.Worksheet(new S.SheetData());
                S.Sheets sheets = doc.WorkbookPart.Workbook.AppendChild<S.Sheets>(new S.Sheets());
                S.Sheet sheet = new S.Sheet()
                {
                    Id = doc.WorkbookPart.
                        GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "mySheet"
                };
                sheets.Append(sheet);
                workbookpart.Workbook.Save();

                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Empty(errs);
            }
        }

        [Fact]
        public void X002_XlsxCreation()
        {
            // By default, AutoSave = true, Editable = true, and Type = xlsx.

            using (var ms = new MemoryStream())
            using (var doc = SpreadsheetDocument.Create(ms, SpreadsheetDocumentType.Workbook))
            {
                var workbookpart = doc.AddWorkbookPart();
                workbookpart.Workbook = new S.Workbook();

                var worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new S.Worksheet(new S.SheetData());

                var sheets = doc.WorkbookPart.Workbook.AppendChild(new S.Sheets());
                var sheet = new S.Sheet()
                {
                    Id = doc.WorkbookPart.
                        GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "mySheet"
                };

                sheets.Append(sheet);
                workbookpart.Workbook.Save();

                var v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);

                Assert.Empty(errs);
            }
        }

        [Fact]
        public void X001_XlsxValidation()
        {
            using (var stream = GetStream(TestFiles.Spreadsheet))
            {
                XlsxValidationHelper(stream, 2, 1);
            }
        }

        private static void XlsxValidationHelper(Stream stream, int expectedErrorCount, int expectedErrorCount2)
        {
            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2007);
                var cnt = validator.Validate(doc).Count();

                validator = new OpenXmlValidator(FileFormatVersions.Office2010);
                cnt += validator.Validate(doc).Count();

                validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                cnt += validator.Validate(doc).Count();

                Assert.True(cnt == expectedErrorCount || cnt == expectedErrorCount2);
            }
        }
    }
}
