// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ChartStylePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    [ContentType(ContentTypeConstant)]
    public partial class ChartStylePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.chartstyle+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/chartStyle";
        private DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle _rootElement;

        /// <summary>
        /// Creates an instance of the ChartStylePart OpenXmlType
        /// </summary>
        internal protected ChartStylePart()
        {
        }

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle ChartStyle
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle>();
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
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartStyle;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        internal override OpenXmlPartRootElement PartRootElement => ChartStyle;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "style";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2013);
        }
    }
}
