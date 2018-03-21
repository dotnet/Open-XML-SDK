// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WordprocessingPeoplePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    [ContentType(ContentTypeConstant)]
    public partial class WordprocessingPeoplePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.people+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/people";
        private DocumentFormat.OpenXml.Office2013.Word.People _rootElement;

        /// <summary>
        /// Creates an instance of the WordprocessingPeoplePart OpenXmlType
        /// </summary>
        internal protected WordprocessingPeoplePart()
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
                _rootElement = value as DocumentFormat.OpenXml.Office2013.Word.People;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        internal override OpenXmlPartRootElement PartRootElement => People;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2013.Word.People People
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2013.Word.People>();
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
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "people";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2013);
        }
    }
}
