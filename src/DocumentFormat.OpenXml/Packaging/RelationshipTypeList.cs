// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class RelationshipTypeList
    {
        private static Dictionary<string, int> _list;

        public static Dictionary<string, int> IsoKnownRelationships
        {
            get
            {
                if (_list == null)
                {
                    _list = new Dictionary<string, int>();

                    _list.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties", 1);
                    _list.Add("http://schemas.openxmlformats.org/package/2006/relationships/metadata/thumbnail", 1);
                    _list.Add("http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/origin", 1);
                    _list.Add("http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/aFChunk", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/comments", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/glossaryDocument", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/header", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/numbering", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/calcChain", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartsheet", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/connections", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customProperty", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/xmlMaps", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/dialogsheet", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/drawing", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLink", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/sheetMetadata", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotTable", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheDefinition", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/pivotCacheRecords", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/queryTable", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/sharedStrings", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionHeaders", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/revisionLog", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/usernames", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableSingleCells", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/table", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/volatileDependencies", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/commentAuthors", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/handoutMaster", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesSlide", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/presProps", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideLayout", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideMaster", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/slideUpdateInfo", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/viewProps", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/control", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/font", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/printerSettings", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/video", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", 1);
                    _list.Add("http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", 1);
                }

                return _list;
            }
        }
    }
}
