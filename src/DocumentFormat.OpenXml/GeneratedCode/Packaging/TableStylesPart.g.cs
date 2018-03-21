// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the TableStylesPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class TableStylesPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.tableStyles+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tableStyles";
        private DocumentFormat.OpenXml.Drawing.TableStyleList _rootElement;

        /// <summary>
        /// Creates an instance of the TableStylesPart OpenXmlType
        /// </summary>
        internal protected TableStylesPart()
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
                _rootElement = value as DocumentFormat.OpenXml.Drawing.TableStyleList;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        internal override OpenXmlPartRootElement PartRootElement => TableStyleList;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Drawing.TableStyleList TableStyleList
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Drawing.TableStyleList>();
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
        internal sealed override string TargetName => "tableStyles";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";
    }
}
