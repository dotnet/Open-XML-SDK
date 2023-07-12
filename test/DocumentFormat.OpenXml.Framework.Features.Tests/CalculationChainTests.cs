// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Features;

public class CalculationChainTests
{
    [Fact]
    public void FeatureIsAvailable()
    {
        // Arrange
        using var doc = SpreadsheetDocument.Create(new MemoryStream(), SpreadsheetDocumentType.Workbook);

        // Act
        doc.AddCalculationChainChangeTracking();
        var feature = doc.Features.Get<ICalculationChainFeature>();

        // Assert
        Assert.NotNull(feature);
        Assert.Empty(feature.Chain);
        Assert.False(feature.IsPaused);
    }

    [Fact]
    public void AddsNewFormula()
    {
        // Arrange
        const string CellReference = "A2";
        const string Formula = "1+2";

        using var doc = SpreadsheetDocument.Create(new MemoryStream(), SpreadsheetDocumentType.Workbook);

        doc.AddCalculationChainChangeTracking();
        var feature = doc.Features.Get<ICalculationChainFeature>();

        var row = AddNewRowToDoc(doc);

        // Act
        var cell = new Cell(new CellFormula(Formula))
        {
            CellReference = CellReference,
        };
        row.AppendChild(cell);

        // Assert
        Assert.NotNull(feature);
        Assert.Collection(
            feature.Chain,
            item =>
            {
                Assert.Equal(CellReference, item.CellReference);
            });
        Assert.Equal(feature.Chain, doc.WorkbookPart!.CalculationChainPart!.CalculationChain.ChildElements);
        Assert.False(feature.IsPaused);
    }

    [Fact]
    public void RemoveFromCalcChainWhenFormulaIsRemoved()
    {
        // Arrange
        const string CellReference = "A2";
        const string Formula = "1+2";

        using var doc = SpreadsheetDocument.Create(new MemoryStream(), SpreadsheetDocumentType.Workbook);

        doc.AddCalculationChainChangeTracking();
        var feature = doc.Features.Get<ICalculationChainFeature>();
        Assert.NotNull(feature);

        var row = AddNewRowToDoc(doc);
        var cell = new Cell(new CellFormula(Formula))
        {
            CellReference = CellReference,
        };
        row.AppendChild(cell);
        Assert.NotEmpty(feature.Chain);

        // Act
        row.RemoveChild(cell);

        // Assert
        Assert.Empty(feature.Chain);
        Assert.Empty(doc.WorkbookPart!.CalculationChainPart!.CalculationChain.ChildElements);
        Assert.False(feature.IsPaused);
    }

    private static Row AddNewRowToDoc(SpreadsheetDocument doc)
    {
        var workbook = doc.WorkbookPart ?? doc.AddWorkbookPart();
        var worksheetPart = workbook.AddNewPart<WorksheetPart>();

        var worksheet = new Worksheet();
        worksheetPart.Worksheet = worksheet;

        var data = worksheet.AppendChild(new SheetData());

        return data.AppendChild(new Row());
    }
}
