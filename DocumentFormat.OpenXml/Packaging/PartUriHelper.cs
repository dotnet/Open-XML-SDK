// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    internal class PartUriHelper
    {
        private Dictionary<string, int> _sequenceNumbers = new Dictionary<string, int>(20);
        private Dictionary<string, int> _reservedUri = new Dictionary<string, int>();

        //List of contentTypes that need to have a 1 appended to the name
        //for the first item in the package. Section numbers in comments
        //refer to the ISO/IEC 29500 standard.
        private static readonly HashSet<string> _numberedContentTypes = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            //11.3 WordprocessingML Parts
            "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml",
            "application/vnd.openxmlformats-officedocument.wordprocessingml.header+xml",
            //12.3 SpreadsheetML Parts
            "application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml",
            "application/vnd.openxmlformats-officedocument.drawing+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml",
            "application/vnd.openxmlformats-officedocument.drawing+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheetMetadata+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionLog+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml",
            //13.3 PresentationML Parts
            "application/vnd.openxmlformats-officedocument.presentationml.comments+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.notesSlide+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.slide+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.slideLayout+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml",
            "application/vnd.openxmlformats-officedocument.presentationml.tags+xml",
            //14.2 DrawingML Parts
            "application/vnd.openxmlformats-officedocument.drawingml.chart+xml",
            "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml",
            "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml",
            "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml",
            "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml",
            "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml",
            "application/vnd.openxmlformats-officedocument.theme+xml",
            "application/vnd.openxmlformats-officedocument.themeOverride+xml",
            //15.2 Shared Parts
            "application/vnd.openxmlformats-officedocument.customXmlProperties+xml",
            "application/vnd.openxmlformats-officedocument.spreadsheetml.printerSettings",
            "application/vnd.openxmlformats-officedocument.wordprocessingml.printerSettings",
            "application/vnd.openxmlformats-officedocument.presentationml.printerSettings"
        };

        public PartUriHelper()
        {
        }

        private bool IsReservedUri(Uri uri)
        {
            string uriString = uri.OriginalString.ToUpperInvariant();
            return this._reservedUri.ContainsKey(uriString);
        }

        internal void AddToReserveUri(Uri partUri)
        {
            string uriString = partUri.OriginalString.ToUpperInvariant();
            this._reservedUri.Add(uriString, 0);
        }

        internal void ReserveUri(string contentType, Uri partUri)
        {
            GetNextSequenceNumber(contentType);
            this.AddToReserveUri(PackUriHelper.GetNormalizedPartUri(partUri));
        }

        internal Uri GetUniquePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt)
        {
            Uri partUri;

            do
            {
                string sequenceNumber = this.GetNextSequenceNumber(contentType);
                string path = Path.Combine(targetPath, targetName + sequenceNumber + targetExt);

                Uri uri = new Uri(path, UriHelper.RelativeOrAbsolute);
                partUri = PackUriHelper.ResolvePartUri(parentUri, uri);
                // partUri = PackUriHelper.GetNormalizedPartUri(PackUriHelper.CreatePartUri(uri));
            } while (this.IsReservedUri(partUri));

            this.AddToReserveUri(partUri);

            // do not need to add to the _existedNames
            return partUri;
        }

        internal Uri GetUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
        {
            Uri partUri;

            partUri = PackUriHelper.ResolvePartUri(parentUri, targetUri);

            if (this.IsReservedUri(partUri))
            {
                // already have one, create new
                string targetPath = ".";
                string targetName = Path.GetFileNameWithoutExtension(targetUri.OriginalString);
                string targetExt = Path.GetExtension(targetUri.OriginalString);

                partUri = GetUniquePartUri(contentType, partUri, targetPath, targetName, targetExt);
            }
            else
            {
                // not used, can use it.
                this.AddToReserveUri(partUri);
            }

            return partUri;
        }

        private string GetNextSequenceNumber(string contentType)
        {
            if (this._sequenceNumbers.ContainsKey(contentType))
            {
                this._sequenceNumbers[contentType] += 1;
                // use the default read-only NumberFormatInfo that is culture-independent (invariant).
                return this._sequenceNumbers[contentType].ToString(NumberFormatInfo.InvariantInfo);
            }
            else
            {
                this._sequenceNumbers.Add(contentType, 1);

                //Certain contentTypes need to be numbered starting with 1.
                return _numberedContentTypes.Contains(contentType) ? "1" : "";
            }
        }
    }
}
