// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Represents a table row in a Wordprocessing document.
    /// </summary>
    public partial class TableRow
    {
        /// <summary>
        /// Gets the collection of table cells within the table row.
        /// </summary>
        public IEnumerable<TableCell> TableCells
        {
            get
            {
                return Elements<TableCell>()?.OfType<TableCell>() ?? Enumerable.Empty<TableCell>();
            }
        }
    }
}
