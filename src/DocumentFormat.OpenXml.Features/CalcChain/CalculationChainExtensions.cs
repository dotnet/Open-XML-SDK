// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml;

/// <summary>
/// A collection of extension methods to add support for tracking <see cref="CalculationChain"/> changes.
/// </summary>
public static class CalculationChainExtensions
{
    /// <summary>
    /// Adds calculation chain tracking that can be controlled via <see cref="ICalculationChainFeature"/> accessible via <see cref="SpreadsheetDocument.Features"/>.
    /// </summary>
    /// <param name="doc">Document to add calculation chain tracking to.</param>
    public static void AddCalculationChainChangeTracking(this SpreadsheetDocument doc)
    {
        if (doc is null)
        {
            throw new ArgumentNullException(nameof(doc));
        }

        if (doc.Features.Get<ICalculationChainFeature>() is not null)
        {
            return;
        }

        var calcChain = new CalcChainFeature(doc);

        doc.AddElementEventFeature();

        var events = doc.Features.GetRequired<IElementEventFeature>();

        events.Change += calcChain.Change;

        doc.Features.Set<ICalculationChainFeature>(calcChain);
    }

    private sealed class CalcChainFeature : ICalculationChainFeature
    {
        private readonly SpreadsheetDocument _doc;

        public CalcChainFeature(SpreadsheetDocument doc)
        {
            _doc = doc;
        }

        public bool IsPaused { get; set; }

        IEnumerable<CalculationCell> ICalculationChainFeature.Chain
        {
            get
            {
                if (_doc.WorkbookPart is not { } workbook)
                {
                    yield break;
                }

                if (workbook.CalculationChainPart is not { } part)
                {
                    yield break;
                }

                if (part.CalculationChain is not { } chain)
                {
                    yield break;
                }

                foreach (var child in chain.ChildElements)
                {
                    if (child is CalculationCell cell)
                    {
                        yield return cell;
                    }
                }
            }
        }

        internal void Change(FeatureEventArgs<PartElementEventArgs> args)
        {
            if (IsPaused)
            {
                return;
            }

            if (args.Type is EventType.Added or EventType.Removing &&
                args.Argument.Element is CellType { CellReference: { HasValue: true } r, CellFormula: { } } c)
            {
                Handle(c, r, args.Type == EventType.Added);
            }
        }

        private void Handle(CellType c, StringValue r, bool isAdding)
        {
            var worksheet = GetWorksheet(c);

            if (worksheet is null)
            {
                return;
            }

            var chain = GetCalculationChain();

            var existing = Find(chain, r);

            if (!isAdding && existing is not null)
            {
                existing.Remove();
            }
            else if (isAdding && existing is null)
            {
                AddCalculationCell(chain, c, r);
            }
        }

        // TODO: What else do we want to set here?
        private static void AddCalculationCell(CalculationChain chain, CellType c, StringValue r)
        {
            var cell = new CalculationCell { CellReference = r };
            chain.AddChild(cell);
        }

        private static CalculationCell? Find(CalculationChain chain, StringValue r)
        {
            foreach (var child in chain.ChildElements)
            {
                if (child is CalculationCell c && string.Equals(c.CellReference, r, StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }
            }

            return null;
        }

        private static WorksheetPart? GetWorksheet(CellType c)
        {
            OpenXmlElement? element = c;

            while (element is not null)
            {
                if (element is Worksheet w)
                {
                    return w.WorksheetPart;
                }

                element = element.Parent;
            }

            return null;
        }

        private CalculationChain GetCalculationChain()
        {
            var workbook = _doc.WorkbookPart ?? _doc.AddWorkbookPart();
            var part = workbook.CalculationChainPart ?? workbook.AddNewPart<CalculationChainPart>();

            return part.CalculationChain ??= new CalculationChain();
        }
    }
}
