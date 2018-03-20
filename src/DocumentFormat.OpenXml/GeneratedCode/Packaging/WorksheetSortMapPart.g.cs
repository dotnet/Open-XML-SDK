// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WorksheetSortMapPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class WorksheetSortMapPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.wsSortMap+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/wsSortMap";
        private DocumentFormat.OpenXml.Office.Excel.WorksheetSortMap _rootElement;

        /// <summary>
        /// Creates an instance of the WorksheetSortMapPart OpenXmlType
        /// </summary>
        internal protected WorksheetSortMapPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office.Excel.WorksheetSortMap;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        internal override OpenXmlPartRootElement PartRootElement => WorksheetSortMap;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "wsSortMap";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office.Excel.WorksheetSortMap WorksheetSortMap
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office.Excel.WorksheetSortMap>();
                }

                return _rootElement;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }
    }
}
