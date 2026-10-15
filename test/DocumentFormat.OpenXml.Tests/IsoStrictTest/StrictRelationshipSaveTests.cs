// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// Saving a Strict package writes every relationship with its transitional type, and does not restore
    /// a relationship that was removed after the package was opened.
    /// </summary>
    public class StrictRelationshipSaveTests
    {
        private const string StrictRelationships = "http://purl.oclc.org/ooxml/officeDocument/relationships";
        private const string StrictMain = "http://purl.oclc.org/ooxml/spreadsheetml/main";

        [Fact]
        public void DeletedWorksheetRelationshipIsNotRestoredOnSave()
        {
            using var stream = GetStream(TestDataStorage.O14ISOStrict.Excel.File2D_Rotation_O12_XL_OartEffects_xlsx, true);

            using (var doc = SpreadsheetDocument.Open(stream, true))
            {
                var workbookPart = doc.WorkbookPart;
                var sheet3 = workbookPart.WorksheetParts.Single(p => p.Uri.OriginalString.EndsWith("sheet3.xml", StringComparison.Ordinal));

                workbookPart.DeletePart(sheet3);
            }

            AssertNoDanglingRelationships(stream);

            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(doc.WorkbookPart.Workbook);
                Assert.Equal(2, doc.WorkbookPart.WorksheetParts.Count());
            }
        }

        [Fact]
        public void DeletedCalculationChainRelationshipIsNotRestoredOnSave()
        {
            using var stream = CreateStrictWorkbook();

            using (var doc = SpreadsheetDocument.Open(stream, true))
            {
                var workbookPart = doc.WorkbookPart;
                workbookPart.DeletePart(workbookPart.CalculationChainPart);
            }

            AssertNoDanglingRelationships(stream);

            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(doc.WorkbookPart.Workbook);
                Assert.Null(doc.WorkbookPart.CalculationChainPart);
            }
        }

        [Fact]
        public void DeletedPackageRelationshipIsNotRestoredOnSave()
        {
            using var stream = CreateStrictWorkbook();

            using (var doc = SpreadsheetDocument.Open(stream, true))
            {
                doc.DeletePart(doc.ExtendedFilePropertiesPart);
            }

            AssertNoDanglingRelationships(stream);

            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(doc.WorkbookPart.Workbook);
                Assert.Null(doc.ExtendedFilePropertiesPart);
            }
        }

        [Fact]
        public void IgnoredRelationshipIsTranslatedOnSave()
        {
            using var stream = CreateStrictWorkbook();

            using (var doc = SpreadsheetDocument.Open(stream, true))
            {
                doc.IgnoreCalculationChainPartRelationship();
            }

            AssertAllRelationshipsTransitional(stream);
            AssertNoDanglingRelationships(stream);
        }

        [Fact]
        public void ReusedRelationshipIdIsNotOverwrittenOnSave()
        {
            using var stream = CreateStrictWorkbook();

            using (var doc = SpreadsheetDocument.Open(stream, true))
            {
                var workbookPart = doc.WorkbookPart;
                var calcChainId = workbookPart.GetIdOfPart(workbookPart.CalculationChainPart);

                workbookPart.DeletePart(workbookPart.CalculationChainPart);
                workbookPart.AddNewPart<WorksheetPart>(calcChainId).Worksheet = new Spreadsheet.Worksheet(new Spreadsheet.SheetData());
            }

            AssertNoDanglingRelationships(stream);

            using (var package = Package.Open(stream, FileMode.Open, FileAccess.Read))
            {
                var workbook = package.GetPart(new Uri("/xl/workbook.xml", UriKind.Relative));
                var reused = workbook.GetRelationship("rId3");

                Assert.Equal("http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet", reused.RelationshipType);
            }
        }

        [Fact]
        public void AllRelationshipsAreTranslatedWhenNothingWasAccessed()
        {
            using var stream = CreateStrictWorkbook();

            using (SpreadsheetDocument.Open(stream, true))
            {
            }

            AssertAllRelationshipsTransitional(stream);
        }

        private static void AssertAllRelationshipsTransitional(Stream stream)
        {
            stream.Position = 0;

            using (var package = Package.Open(stream, FileMode.Open, FileAccess.Read))
            {
                var relationships = package.GetRelationships()
                    .Concat(package.GetParts().Where(p => !p.Uri.OriginalString.EndsWith(".rels", StringComparison.Ordinal)).SelectMany(p => p.GetRelationships()));

                Assert.All(relationships, r => Assert.StartsWith("http://schemas.openxmlformats.org/", r.RelationshipType, StringComparison.Ordinal));
            }

            stream.Position = 0;
        }

        private static void AssertNoDanglingRelationships(Stream stream)
        {
            stream.Position = 0;

            using var package = Package.Open(stream, FileMode.Open, FileAccess.Read);

            var packageRoot = new Uri("/", UriKind.Relative);

            foreach (var relationship in package.GetRelationships().Where(r => r.TargetMode == TargetMode.Internal))
            {
                var target = PackUriHelper.ResolvePartUri(packageRoot, relationship.TargetUri);

                Assert.True(package.PartExists(target), $"package {relationship.Id} points to missing part {target}");
            }

            foreach (var part in package.GetParts().Where(p => !p.Uri.OriginalString.EndsWith(".rels", StringComparison.Ordinal)))
            {
                foreach (var relationship in part.GetRelationships().Where(r => r.TargetMode == TargetMode.Internal))
                {
                    var target = PackUriHelper.ResolvePartUri(part.Uri, relationship.TargetUri);

                    Assert.True(package.PartExists(target), $"{part.Uri} {relationship.Id} points to missing part {target}");
                }
            }

            stream.Position = 0;
        }

        private static MemoryStream CreateStrictWorkbook()
        {
            var stream = new MemoryStream();

            using (var package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite))
            {
                var workbook = AddPart(package, "/xl/workbook.xml", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml", $"<workbook xmlns=\"{StrictMain}\" xmlns:r=\"{StrictRelationships}\" conformance=\"strict\"><sheets><sheet name=\"Sheet1\" sheetId=\"1\" r:id=\"rId1\"/></sheets></workbook>");
                AddPart(package, "/xl/worksheets/sheet1.xml", "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml", $"<worksheet xmlns=\"{StrictMain}\"><sheetData/></worksheet>");
                AddPart(package, "/xl/calcChain.xml", "application/vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml", $"<calcChain xmlns=\"{StrictMain}\"><c r=\"A1\" i=\"1\"/></calcChain>");
                var app = AddPart(package, "/docProps/app.xml", "application/vnd.openxmlformats-officedocument.extended-properties+xml", "<Properties xmlns=\"http://purl.oclc.org/ooxml/officeDocument/extendedProperties\"/>");

                package.CreateRelationship(workbook.Uri, TargetMode.Internal, StrictRelationships + "/officeDocument", "rId1");
                package.CreateRelationship(app.Uri, TargetMode.Internal, StrictRelationships + "/extendedProperties", "rId2");
                workbook.CreateRelationship(new Uri("worksheets/sheet1.xml", UriKind.Relative), TargetMode.Internal, StrictRelationships + "/worksheet", "rId1");
                workbook.CreateRelationship(new Uri("calcChain.xml", UriKind.Relative), TargetMode.Internal, StrictRelationships + "/calcChain", "rId3");
            }

            stream.Position = 0;
            return stream;
        }

        private static PackagePart AddPart(Package package, string uri, string contentType, string xml)
        {
            var part = package.CreatePart(new Uri(uri, UriKind.Relative), contentType);
            var bytes = Encoding.UTF8.GetBytes(xml);

            using (var partStream = part.GetStream(FileMode.Create, FileAccess.Write))
            {
                partStream.Write(bytes, 0, bytes.Length);
            }

            return part;
        }
    }
}
