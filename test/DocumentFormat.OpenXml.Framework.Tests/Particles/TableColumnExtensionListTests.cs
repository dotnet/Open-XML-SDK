// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using ExtensionList = DocumentFormat.OpenXml.Spreadsheet.ExtensionList;
using F = DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;

namespace DocumentFormat.OpenXml.Framework.Tests.Particles
{
    public class TableColumnExtensionListTests
    {
        [Theory]
        [InlineData(TestFiles.Test_question_element_xlsx)]
        public void GetExtensionListChildren(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                TableDefinitionPart tblprt = (TableDefinitionPart)sheet.GetPartById("rId2");
                Assert.NotNull(tblprt);

                TableColumn tc = tblprt.Table.TableColumns.GetFirstChild<TableColumn>();
                Assert.NotNull(tc);

                // Question q1 = tc.ExtensionList.GetChildExtension<Question>();
#pragma warning disable CS0618 // Type or member is obsolete
                Extension e = tc.ExtensionList.GetFirstChild<Extension>();

#pragma warning restore CS0618 // Type or member is obsolete
                TableColumnExtension e2 = tc.TableColumnExtensionList.GetFirstChild<TableColumnExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);

                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e2.Uri);

                F.Question question = e2.GetFirstChild<F.Question>();
                Assert.NotNull(question);

                Assert.NotNull(e);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e.Uri);
                question = e.GetFirstChild<F.Question>();
                Assert.NotNull(question);
            }
        }

        [Theory]
        [InlineData(TestFiles.Test_question_element_set_xlsx)]
        public void SetExtensionListChildren(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                TableDefinitionPart tblprt = (TableDefinitionPart)sheet.GetPartById("rId2");
                Assert.NotNull(tblprt);

                TableColumn tc = tblprt.Table.TableColumns.GetFirstChild<TableColumn>();
                Assert.NotNull(tc);

                ExtensionList eList = new ExtensionList(
                    new Extension() { Uri = "{FCC71383-01E1-4257-9335-427F07BE8D7F}" });

                tc.AddChild(eList);
#pragma warning disable CS0618 // Type or member is obsolete

                Extension e = tc.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                TableColumnExtension e2 = tc.TableColumnExtensionList.GetFirstChild<TableColumnExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e2.Uri);

                Assert.NotNull(e);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e.Uri);
            }
        }

        [Theory]
        [InlineData(TestFiles.Test_question_element_set_xlsx)]
        public void SetExtensionListProperty(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                TableDefinitionPart tblprt = (TableDefinitionPart)sheet.GetPartById("rId2");
                Assert.NotNull(tblprt);

                TableColumn tc = tblprt.Table.TableColumns.GetFirstChild<TableColumn>();
                Assert.NotNull(tc);

                ExtensionList eList = new ExtensionList(
                    new Extension() { Uri = "{FCC71383-01E1-4257-9335-427F07BE8D7F}" });

#pragma warning disable CS0618 // Type or member is obsolete
                tc.ExtensionList = eList;

                Extension e = tc.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                TableColumnExtension e2 = tc.TableColumnExtensionList.GetFirstChild<TableColumnExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e2.Uri);

                Assert.NotNull(e);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e.Uri);
            }
        }

        [Theory]
        [InlineData(TestFiles.Test_question_element_set_xlsx)]
        public void SetTableColumnExtensionListChildren(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                TableDefinitionPart tblprt = (TableDefinitionPart)sheet.GetPartById("rId2");
                Assert.NotNull(tblprt);

                TableColumn tc = tblprt.Table.TableColumns.GetFirstChild<TableColumn>();
                Assert.NotNull(tc);

                TableColumnExtensionList teList = new TableColumnExtensionList(
                    new TableColumnExtension(
                        new Question() { Id = "r8a22544ad01d478e898ac5748745f765" })
                    { Uri = "{FCC71383-01E1-4257-9335-427F07BE8D7F}" });

                // TODO when xsd is updated: Add a TableStyleInfo, ExtensionList, Extension and xlmsforms:syncedQuestionId with the r8a22544ad01d478e898ac5748745f765 id value.
                tc.AddChild(teList);

#pragma warning disable CS0618 // Type or member is obsolete
                Extension e = tc.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                TableColumnExtension e2 = tc.TableColumnExtensionList.GetFirstChild<TableColumnExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);

                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e2.Uri);

                F.Question question = e2.GetFirstChild<F.Question>();
                Assert.NotNull(question);

                Assert.NotNull(e);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e.Uri);
                question = e.GetFirstChild<F.Question>();
                Assert.NotNull(question);
            }
        }

        [Theory]
        [InlineData(TestFiles.Test_question_element_set_xlsx)]
        public void SetTableColumnExtensionListProperty(string name)
        {
            using (var stream = GetStream(name))
            using (SpreadsheetDocument spd = SpreadsheetDocument.Open(stream, false))
            {
                Assert.NotNull(spd);
                Assert.NotNull(spd.WorkbookPart);

                WorksheetPart sheet = (WorksheetPart)spd.WorkbookPart.GetPartById("rId1");
                Assert.NotNull(sheet);

                TableDefinitionPart tblprt = (TableDefinitionPart)sheet.GetPartById("rId2");
                Assert.NotNull(tblprt);

                TableColumn tc = tblprt.Table.TableColumns.GetFirstChild<TableColumn>();
                Assert.NotNull(tc);

                TableColumnExtensionList teList = new TableColumnExtensionList(
                    new TableColumnExtension(
                        new Question() { Id = "r8a22544ad01d478e898ac5748745f765" })
                    { Uri = "{FCC71383-01E1-4257-9335-427F07BE8D7F}" });

                // TODO when xsd is updated: Add a TableStyleInfo, ExtensionList, Extension and xlmsforms:syncedQuestionId with the r8a22544ad01d478e898ac5748745f765 id value.
                tc.TableColumnExtensionList = teList;

#pragma warning disable CS0618 // Type or member is obsolete
                Extension e = tc.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete

                TableColumnExtension e2 = tc.TableColumnExtensionList.GetFirstChild<TableColumnExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);

                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e2.Uri);

                F.Question question = e2.GetFirstChild<F.Question>();
                Assert.NotNull(question);

                Assert.NotNull(e);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e.Uri);
                question = e.GetFirstChild<F.Question>();
                Assert.NotNull(question);
            }
        }
    }
}
