// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features;

/// <summary>
/// A feature to track and update the <see cref="CalculationChainPart"/>.
/// </summary>
public interface ICalculationChainFeature
{
    /// <summary>
    /// Gets the current <see cref="CalculationCell"/> entries registered in the <see cref="CalculationChainPart" />.
    /// </summary>
    public IEnumerable<CalculationCell> Chain { get; }

    /// <summary>
    /// Gets or sets a value indicating whether the calculation chain is auto updated.
    /// </summary>
    bool IsPaused { get; set; }
}
