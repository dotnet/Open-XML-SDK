// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.Slicer
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Spreadsheet;
    using X14 = DocumentFormat.OpenXml.Office2010.Excel;
    using X15 = DocumentFormat.OpenXml.Office2013.Excel;
    using LogUtil;

    public class TestEntities
    {
        //Slicer names
        private readonly string Slicer1 = "Slicer_1";
        private readonly string Slicer2 = "Slicer_2";
        private readonly string Slicer3 = "Slicer_3";

        /// <summary>
        /// Edit Slicer element
        /// </summary>
        /// <param name="filePath">Editing target file path</param>
        /// <param name="log">Logger</param>
        public void EditElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                //Getting of SlicerCacheParts.
                SlicerCachePart slicerCachePart1 = GetSlicerCachePart(package.WorkbookPart, this.Slicer1);
                SlicerCachePart slicerCachePart2 = GetSlicerCachePart(package.WorkbookPart, this.Slicer2);
                SlicerCachePart slicerCachePart3 = GetSlicerCachePart(package.WorkbookPart, this.Slicer3);

                X15.TableSlicerCache tableSlicerCache1 = slicerCachePart1.RootElement.Descendants<X15.TableSlicerCache>().Single();
                X15.TableSlicerCache tableSlicerCache2 = slicerCachePart2.RootElement.Descendants<X15.TableSlicerCache>().Single();
                X15.TableSlicerCache tableSlicerCache3 = slicerCachePart3.RootElement.Descendants<X15.TableSlicerCache>().Single();

                //Change TableId attribute value of TableSlicerCache.
                tableSlicerCache1.TableId.Value = 2;
                log.Pass("Edited TableSlicerCache attribute of TableId.");

                //Change Column attribute value.

                //Change Column attribute value of TableSlicerCache.
                tableSlicerCache1.Column.Value = 2;
                log.Pass("Edited TableSlicerCache attribute of Column.");

                //Change SortOrder attribute value.

                //Change SortOrder attribute value of TableSlicerCache. Set value is Descending.
                tableSlicerCache1.SortOrder = X14.TabularSlicerCacheSortOrderValues.Descending;
                log.Pass("Edited TableSlicerCache attribute of SortOrder. Set value is Descending.");

                //Change SortOrder attribute value of TableSlicerCache. Set value is Ascending.
                tableSlicerCache2.SortOrder = X14.TabularSlicerCacheSortOrderValues.Ascending;
                log.Pass("Edited TableSlicerCache attribute of SortOrder. Set value is Ascending.");

                //Change CustomListSort attribute value.

                //Change CustomListSort attribute value of TableSlicerCache. Set value is false.
                tableSlicerCache1.CustomListSort = false;
                log.Pass("Edited TableSlicerCache attribute of CustomListSort. Set value is false.");

                //Change CustomListSort attribute value of TableSlicerCache. Set value is true.
                tableSlicerCache2.CustomListSort = true;
                log.Pass("Edited TableSlicerCache attribute of CustomListSort. Set value is true.");

                //Change CrossFilter attribute value.

                //Change CrossFilter attribute value of TableSlicerCache. Set value is None.
                tableSlicerCache1.CrossFilter = X14.SlicerCacheCrossFilterValues.None;
                log.Pass("Edited TableSlicerCache attribute of CrossFilter. Set value is None.");

                //Change CrossFilter attribute value of TableSlicerCache. Set value is ShowItemsWithDataAtTop.
                tableSlicerCache2.CrossFilter = X14.SlicerCacheCrossFilterValues.ShowItemsWithDataAtTop;
                log.Pass("Edited TableSlicerCache attribute of CrossFilter. Set value is ShowItemsWithDataAtTop.");

                //Change CrossFilter attribute value of TableSlicerCache. Set value is ShowItemsWithNoData.
                tableSlicerCache3.CrossFilter = X14.SlicerCacheCrossFilterValues.ShowItemsWithNoData;
                log.Pass("Edited TableSlicerCache attribute of CrossFilter. Set value is ShowItemsWithNoData.");

                X15.TableSlicerCache newTableSlicerCache1 = tableSlicerCache1.Clone() as X15.TableSlicerCache;
                X15.TableSlicerCache newTableSlicerCache2 = tableSlicerCache2.Clone() as X15.TableSlicerCache;
                X15.TableSlicerCache newTableSlicerCache3 = tableSlicerCache3.Clone() as X15.TableSlicerCache;
                //Remove the existing Extension, to set the new Extension.
                slicerCachePart1.RootElement.Descendants<SlicerCacheDefinitionExtension>().Single().Remove();
                slicerCachePart2.RootElement.Descendants<SlicerCacheDefinitionExtension>().Single().Remove();
                slicerCachePart3.RootElement.Descendants<SlicerCacheDefinitionExtension>().Single().Remove();
                SlicerCacheDefinitionExtension extension1 = new SlicerCacheDefinitionExtension() { Uri = "{2F2917AC-EB37-4324-AD4E-5DD8C200BD13}" };
                extension1.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
                extension1.Append(newTableSlicerCache1);
                slicerCachePart1.SlicerCacheDefinition.SlicerCacheDefinitionExtensionList.AppendChild(extension1);

                SlicerCacheDefinitionExtension extension2 = new SlicerCacheDefinitionExtension() { Uri = "{2F2917AC-EB37-4324-AD4E-5DD8C200BD13}" };
                extension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
                extension2.Append(newTableSlicerCache2);
                slicerCachePart2.SlicerCacheDefinition.SlicerCacheDefinitionExtensionList.AppendChild(extension2);

                SlicerCacheDefinitionExtension extension3 = new SlicerCacheDefinitionExtension() { Uri = "{2F2917AC-EB37-4324-AD4E-5DD8C200BD13}" };
                extension3.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
                extension3.Append(newTableSlicerCache3);
                slicerCachePart3.SlicerCacheDefinition.SlicerCacheDefinitionExtensionList.AppendChild(extension3);

                //Append SlicerCacheHideItemsWithNoData element.
                Extension extension = new Extension() { Uri = "{470722E0-AACD-4C17-9CDC-17EF765DBC7E}" };
                extension.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
                extension.AppendChild<X15.SlicerCacheHideItemsWithNoData>(new X15.SlicerCacheHideItemsWithNoData());
                slicerCachePart2.SlicerCacheDefinition.SlicerCacheDefinitionExtensionList.AppendChild<Extension>(extension);

                log.Pass("Added SlicerCacheHideItemsWithNoData element.");
            }
        }

        /// <summary>
        /// Verify the SlicerCachePart element and attribute value.
        /// </summary>
        /// <param name="filePath">Target file path</param>
        /// <param name="log">Logger</param>
        public void VerifyElements(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                //Getting of SlicerCacheParts.
                SlicerCachePart slicerCachePart1 = GetSlicerCachePart(package.WorkbookPart, this.Slicer1);
                SlicerCachePart slicerCachePart2 = GetSlicerCachePart(package.WorkbookPart, this.Slicer2);
                SlicerCachePart slicerCachePart3 = GetSlicerCachePart(package.WorkbookPart, this.Slicer3);

                X15.TableSlicerCache tableSlicerCache1 = slicerCachePart1.RootElement.Descendants<X15.TableSlicerCache>().Single();
                X15.TableSlicerCache tableSlicerCache2 = slicerCachePart2.RootElement.Descendants<X15.TableSlicerCache>().Single();
                X15.TableSlicerCache tableSlicerCache3 = slicerCachePart3.RootElement.Descendants<X15.TableSlicerCache>().Single();

                //Verify TableId attribute value.

                //Verify TableId attribute value of TableSlicerCache.
                log.Verify(tableSlicerCache1.TableId.Value == 2, "Verify TableSlicerCache attribute of TableId.");

                //Verify Column attribute value.

                //Verify Column attribute value of TableSlicerCache.
                log.Verify(tableSlicerCache1.Column.Value == 2, "Verify TableSlicerCache attribute of Column.");

                //Verify SortOrder attribute value.

                //Verify SortOrder attribute value of TableSlicerCache. Value is Descending.
                log.Verify(tableSlicerCache1.SortOrder.Value == X14.TabularSlicerCacheSortOrderValues.Descending, "Verify TableSlicerCache attribute of SortOrder. Value is not Descending.");

                //Verify SortOrder attribute value of TableSlicerCache. Value is Ascending.
                log.Verify(tableSlicerCache2.SortOrder.Value == X14.TabularSlicerCacheSortOrderValues.Ascending, "Verify TableSlicerCache attribute of SortOrder. Value is not Ascending.");

                //Verify CustomListSort attribute value.
                //Verify CustomListSort attribute value of TableSlicerCache. Value is false.
                log.Verify(tableSlicerCache1.CustomListSort.Value == false, "Verify TableSlicerCache attribute of CustomListSort. Value is not false.");

                //Verify CustomListSort attribute value of TableSlicerCache. Value is true.
                log.Verify(tableSlicerCache2.CustomListSort.Value == true, "Verify TableSlicerCache attribute of CustomListSort. Value is not true.");

                //Verify CrossFilter attribute value.
                //Verify CrossFilter attribute value of TableSlicerCache. Value is None.
                log.Verify(tableSlicerCache1.CrossFilter == X14.SlicerCacheCrossFilterValues.None, "Verify TableSlicerCache attribute of CrossFilter. Value is not None");

                //Verify CrossFilter attribute value of TableSlicerCache. Value is ShowItemsWithDataAtTop.
                log.Verify(tableSlicerCache2.CrossFilter == X14.SlicerCacheCrossFilterValues.ShowItemsWithDataAtTop, "Verify TableSlicerCache attribute of CrossFilter. Value is ShowItemsWithDataAtTop.");

                //Verify CrossFilter attribute value of TableSlicerCache. Value is ShowItemsWithNoData.
                log.Verify(tableSlicerCache3.CrossFilter == X14.SlicerCacheCrossFilterValues.ShowItemsWithNoData, "Verify TableSlicerCache attribute of CrossFilter. Value is ShowItemsWithNoData.");

                //Verify SlicerCacheHideItemsWithNoData element exist.
                log.Verify(slicerCachePart2.SlicerCacheDefinition.SlicerCacheDefinitionExtensionList.Descendants<X15.SlicerCacheHideItemsWithNoData>().Count() == 1, "Verify SlicerCacheHideItemsWithNoData exist.");
            }
        }

        /// <summary>
        /// Retrieved by specifying a name from WorkbookPart to SlicerCachePart.
        /// </summary>
        /// <param name="workbookPart">Including SlicerCachePart in WorkbookPart</param>
        /// <param name="slicerName">Slicer is name</param>
        /// <returns>SlicerName match SlicerCachePart</returns>
        private SlicerCachePart GetSlicerCachePart(WorkbookPart workbookPart, string slicerName)
        {
            SlicerCachePart returnSlicerCachePart = null;
            string slicerCacheName = null;

            //Get SlicerCache Name
            foreach (WorksheetPart worksheetPart in workbookPart.WorksheetParts)
            {
                foreach (SlicersPart slicersPart in worksheetPart.SlicersParts)
                {
                    foreach (X14.Slicer slicer in slicersPart.Slicers)
                    {
                        if (slicer.Name == slicerName)
                        {
                            slicerCacheName = slicer.Cache.Value;
                            break;
                        }
                    }
                    if (slicerCacheName != null)
                        break;
                }
                if (slicerCacheName != null)
                    break;
            }

            //Getting name match SlicerCachePart.
            if (slicerCacheName != null)
            {
                foreach (SlicerCachePart slicerCachePart in workbookPart.SlicerCacheParts)
                {
                    if (slicerCachePart.SlicerCacheDefinition.Name == slicerCacheName)
                    {
                        returnSlicerCachePart = slicerCachePart;
                        break;
                    }
                }
            }

            return returnSlicerCachePart;
        }
    }
}
