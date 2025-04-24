// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

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
        public IEnumerable<TableRow>? TableRow
        {
            get
            {
                foreach (var element in Elements<TableRow>())
                {
                    yield return element;
                }
            }
        }
    }
}
