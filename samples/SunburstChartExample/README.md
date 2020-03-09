# Sunburst Chart Presentation Example

The sample code in this folder is an example of how to generate the Office 2016 Sunburst chart type using the SDK.

The important function in program.cs is in:

```csharp
        private void CreateParts(PresentationDocument document)
```

And in there, find:

```csharp
            // This is the generation of the new Sunburst ChartPart
            ExtendedChartPart chartPart1 = slidePart1.AddNewPart<ExtendedChartPart>("rId2");
            GenerateExtendedChartPart1Content(chartPart1);
```

Pay attention to the `C16` namespace prefix being used. Many of the chart types (classes) in the `C` (2007) namespace are the same as those in the newer `C16` (2016) but will have slight or considerable differences.