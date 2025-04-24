// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class TableRowTest
    {
        [Fact]
        public void TableCellTest()
        {
            // Arrange
            Table table = new Table();

            // Create table rows and cells
            TableRow tr = table.AppendChild(new TableRow());
            TableCell tc1 = tr.AppendChild(new TableCell(new TableCellProperties(
                new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" })));
            tc1.AppendChild(new Paragraph(new Run(new Text("Text to test"))));

            // Assert
            foreach (var cell in tr.TableCell.ToList())
            {
                Assert.IsType<TableCell>(cell);
                Assert.Equal(tc1, cell);
                Assert.Equal("Text to test", cell.InnerText);
            }
        }
    }
}
