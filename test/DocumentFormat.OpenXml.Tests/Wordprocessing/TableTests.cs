// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class TableTests
    {
        [Fact]
        public void TablePropertiesGetterAndSetterTest()
        {
            // Arrange
            var table = new Table();
            var tableProperties = new TableProperties(new TableBorders(
            new TopBorder()
            {
                Val =
                new EnumValue<BorderValues>(BorderValues.Single),
                Size = 24,
            },
            new BottomBorder()
            {
                Val =
                new EnumValue<BorderValues>(BorderValues.Single),
                Size = 24,
            }));

            // Act
            table.AppendChild(tableProperties);

            // Assert
            Assert.NotNull(table.TableProperties);
            Assert.Equal(tableProperties, table.TableProperties);
        }

        [Fact]
        public void TableGridsGetterAndSetterTest()
        {
            // Arrange
            var table = new Table();
            var tableGrid = new TableGrid(new GridColumn(), new GridColumn(), new GridColumn());
            TableGrid tableGrid1 = new TableGrid();

            // Act
            table.AppendChild(tableGrid);

            // Assert
            Assert.NotNull(table.TableGrid);
            Assert.Equal(tableGrid, table.TableGrid);
        }

        [Fact]
        public void TableRowsTest()
        {
            // Arrange
            Table table = new Table();

            // Create table row and cells
            TableRow tr = table.AppendChild(new TableRow());
            TableCell tc1 = tr.AppendChild(new TableCell(new TableCellProperties(
                new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" })));
            tc1.AppendChild(new Paragraph(new Run(new Text("Text 1"))));

            // Specify the table cell content.
            TableCell tc2 = tr.AppendChild(new TableCell(new TableCellProperties(
                new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" })));
            tc2.AppendChild(new Paragraph(new Run(new Text("Text 2"))));

            // Create table row and cells
            TableRow tr2 = table.AppendChild(new TableRow());
            TableCell tc3 = tr2.AppendChild(new TableCell(new TableCellProperties(
                new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" })));
            tc3.AppendChild(new Paragraph(new Run(new Text("Text 3"))));

            // Specify the table cell content.
            TableCell tc4 = tr2.AppendChild(new TableCell(new TableCellProperties(
                new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" })));
            tc4.AppendChild(new Paragraph(new Run(new Text("Text 4"))));

            // List to store table rows
            List<TableRow> rows = [tr, tr2];
            table.TableRows.ToList().Append(new TableRow());

            // Assert
            Assert.NotNull(table.TableRows);
            Assert.Equal(rows.Count, table.TableRows.Count());
            int i = 0;
            foreach (var row in table.TableRows.ToList())
            {
                Assert.IsType<TableRow>(row);
                Assert.Equal(rows[i], row);
                i++;
            }

            Assert.Equal(rows.Count, table.TableRows.Count());
        }

        [Fact]
        public void TableRowsShouldBeEmptyWhenNoCellsAreAdded()
        {
            // Arrange
            Table table = new Table();

            // Assert
            Assert.NotNull(table.TableRows);
            Assert.Empty(table.TableRows);
        }
    }
}
