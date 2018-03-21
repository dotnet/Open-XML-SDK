// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the SlicersPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2010)]
    [ContentType(ContentTypeConstant)]
    public partial class SlicersPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.slicer+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2007/relationships/slicer";
        private DocumentFormat.OpenXml.Office2010.Excel.Slicers _rootElement;

        /// <summary>
        /// Creates an instance of the SlicersPart OpenXmlType
        /// </summary>
        internal protected SlicersPart()
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
                _rootElement = value as DocumentFormat.OpenXml.Office2010.Excel.Slicers;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        internal override OpenXmlPartRootElement PartRootElement => Slicers;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2010.Excel.Slicers Slicers
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2010.Excel.Slicers>();
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

        /// <inheritdoc/>
        internal sealed override string TargetName => "slicer";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../slicers";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2010);
        }
    }
}
