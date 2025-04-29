// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Table
    {
        /// <summary>
        /// Gets or sets the TableProperties.
        /// </summary>
        public TableProperties? TableProperties
        {
            get => GetElement(Wordprocessing.TableProperties.ElementType) as TableProperties;
            set => SetElement(value, Wordprocessing.TableProperties.ElementType);
        }

        /// <summary>
        /// Gets or sets the TableGrid.
        /// </summary>
        public TableGrid? TableGrid
        {
            get => GetElement(Wordprocessing.TableGrid.ElementType) as TableGrid;
            set => SetElement(value, Wordprocessing.TableGrid.ElementType);
        }

        /// <summary>
        /// Gets the collection of TableRow elements.
        /// </summary>
        public IEnumerable<TableRow> TableRows
        {
            get
            {
                return Elements<TableRow>()?.OfType<TableRow>() ?? Enumerable.Empty<TableRow>();
            }
        }
    }
}
