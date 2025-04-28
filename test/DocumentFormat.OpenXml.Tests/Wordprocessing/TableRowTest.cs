// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class TableRowTest
    {
        [Fact]
        public void TableCellsTest()
        {
            // Arrange
            Table table = new Table();

            // Create table rows and cells
            TableRow tr = table.AppendChild(new TableRow());
            TableCell tc1 = tr.AppendChild(new TableCell(new TableCellProperties(
                new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" })));
            tc1.AppendChild(new Paragraph(new Run(new Text("Text 0"))));

            TableCell tc2 = tr.AppendChild(new TableCell(new TableCellProperties(
               new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" })));
            tc2.AppendChild(new Paragraph(new Run(new Text("Text 1"))));

            int i = 0;

            // List to store row cells
            List<TableCell> cells = new List<TableCell> { tc1, tc2 };

            // Assert
            foreach (var cell in tr.TableCells.ToList())
            {
                Assert.IsType<TableCell>(cell);
                Assert.Equal(cells[i], cell);
                Assert.Equal("Text " + i.ToString(), cell.InnerText);
                i++;
            }
        }

        [Fact]
        public void TableRowsShouldBeEmptyRowsAreAdded()
        {
            // Arrange
            Table table = new Table();
            TableRow tr = table.AppendChild(new TableRow());

            // Assert
            Assert.NotNull(tr.TableCells);
            Assert.Empty(tr.TableCells);
        }
    }
}
