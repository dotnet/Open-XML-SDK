// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Framework.Tests.Particles
{
    public class TableColumnExtensionListTests
    {
        [Theory]
        [InlineData(TestFiles.Test_question_element_xlsx)]
        public void ExtensionListChildren(string name)
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

#pragma warning disable CS0618 // Type or member is obsolete
                Extension e1 = tc.ExtensionList.GetFirstChild<Extension>();
#pragma warning restore CS0618 // Type or member is obsolete
                TableColumnExtension e2 = tc.TableColumnExtensionList.GetFirstChild<TableColumnExtension>();

                // The goal is to have both of these be valid objects.
                Assert.NotNull(e2);

                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e2.Uri);

                Question question = e2.GetFirstChild<Question>();
                Assert.NotNull(question);

                Assert.NotNull(e1);
                Assert.Equal("{FCC71383-01E1-4257-9335-427F07BE8D7F}", e1.Uri);
                question = e1.GetFirstChild<Question>();
                Assert.Null(question);
            }
        }
    }
}
