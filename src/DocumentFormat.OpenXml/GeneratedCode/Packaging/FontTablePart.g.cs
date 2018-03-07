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
    [ContentType("application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml")]
    public partial class FontTablePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

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

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

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

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            if (_dataPartReferenceConstraint is null)
            {
                _dataPartReferenceConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal) { };
            }

            return _dataPartReferenceConstraint;
        }

        /// <inheritdoc/>
        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            if (_partConstraint is null)
            {
                _partConstraint = new Dictionary<string, PartConstraintRule>(StringComparer.Ordinal)
                {
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font",
                        PartConstraintRule.Create<FontPart>(false, true)
                    }
                };
            }

            return _partConstraint;
        }
    }
}
