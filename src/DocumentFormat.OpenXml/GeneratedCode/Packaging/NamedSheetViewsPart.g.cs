// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the NamedSheetViewsPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2021)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class NamedSheetViewsPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.namedsheetviews+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2019/04/relationships/namedSheetView";
        private DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NamedSheetViews? _rootElement;

        /// <summary>
        /// Creates an instance of the NamedSheetViewsPart OpenXmlType
        /// </summary>
        internal protected NamedSheetViewsPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NamedSheetViews;
            }
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NamedSheetViews NamedSheetViews
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews.NamedSheetViews>();
                }

                return _rootElement!;
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

        internal override OpenXmlPartRootElement? PartRootElement => NamedSheetViews;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "namedSheetView";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../namedSheetViews";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2021);
        }
    }
}
