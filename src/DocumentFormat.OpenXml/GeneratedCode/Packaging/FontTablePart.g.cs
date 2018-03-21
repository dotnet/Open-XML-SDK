// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the FontTablePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    [ContentType(ContentTypeConstant)]
    public partial class FontTablePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Wordprocessing.Fonts _rootElement;

        /// <summary>
        /// Creates an instance of the FontTablePart OpenXmlType
        /// </summary>
        internal protected FontTablePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the FontParts of the FontTablePart
        /// </summary>
        public IEnumerable<FontPart> FontParts => GetPartsOfType<FontPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Wordprocessing.Fonts Fonts
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Wordprocessing.Fonts>();
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

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Wordprocessing.Fonts;
            }
        }

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        internal sealed override PartConstraintCollection PartConstraints
        {
            get
            {
                if (_partConstraints is null)
                {
                    _partConstraints = new PartConstraintCollection
                    {
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font",
                            PartConstraintRule.Create<FontPart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => Fonts;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "fontTable";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        /// <summary>
        /// Adds a FontPart to the FontTablePart
        /// </summary>
        /// <param name="contentType">The content type of the FontPart</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(string contentType)
        {
            var childPart = new FontPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a FontPart to the FontTablePart
        /// </summary>
        /// <param name="contentType">The content type of the FontPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(string contentType, string id)
        {
            var childPart = new FontPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a FontPart to the FontTablePart
        /// </summary>
        /// <param name="partType">The part type of the FontPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(FontPartType partType, string id)
        {
            var contentType = FontPartTypeInfo.GetContentType(partType);
            var partExtension = FontPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddFontPart(contentType, id);
        }

        /// <summary>
        /// Adds a FontPart to the FontTablePart
        /// </summary>
        /// <param name="partType">The part type of the FontPart</param>
        /// <return>The newly added part</return>
        public FontPart AddFontPart(FontPartType partType)
        {
            var contentType = FontPartTypeInfo.GetContentType(partType);
            var partExtension = FontPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddFontPart(contentType);
        }

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case FontPart.RelationshipTypeConstant:
                    return new FontPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
