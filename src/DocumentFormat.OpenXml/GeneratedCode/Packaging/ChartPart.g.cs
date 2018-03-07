// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ChartPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class ChartPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawingml.chart+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the ChartPart OpenXmlType
        /// </summary>
        internal protected ChartPart()
        {
        }

        /// <summary>
        /// Gets the ChartColorStyleParts of the ChartPart
        /// </summary>
        public IEnumerable<ChartColorStylePart> ChartColorStyleParts => GetPartsOfType<ChartColorStylePart>();

        /// <summary>
        /// Gets the ChartDrawingPart of the ChartPart
        /// </summary>
        public ChartDrawingPart ChartDrawingPart => GetSubPartOfType<ChartDrawingPart>();

        /// <summary>
        /// Gets the ChartStyleParts of the ChartPart
        /// </summary>
        public IEnumerable<ChartStylePart> ChartStyleParts => GetPartsOfType<ChartStylePart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the EmbeddedPackagePart of the ChartPart
        /// </summary>
        public EmbeddedPackagePart EmbeddedPackagePart => GetSubPartOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ImageParts of the ChartPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "chart";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "charts";

        /// <summary>
        /// Gets the ThemeOverridePart of the ChartPart
        /// </summary>
        public ThemeOverridePart ThemeOverridePart => GetSubPartOfType<ThemeOverridePart>();

        /// <summary>
        /// Adds a EmbeddedPackagePart to the ChartPart
        /// </summary>
        /// <param name="contentType">The content type of the EmbeddedPackagePart</param>
        /// <return>The newly added part</return>
        public EmbeddedPackagePart AddEmbeddedPackagePart(string contentType)
        {
            var childPart = new EmbeddedPackagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the ChartPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the ChartPart
        /// </summary>
        /// <param name="contentType">The content type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(string contentType, string id)
        {
            var childPart = new ImagePart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ImagePart to the ChartPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType, string id)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType, id);
        }

        /// <summary>
        /// Adds a ImagePart to the ChartPart
        /// </summary>
        /// <param name="partType">The part type of the ImagePart</param>
        /// <return>The newly added part</return>
        public ImagePart AddImagePart(ImagePartType partType)
        {
            var contentType = ImagePartTypeInfo.GetContentType(partType);
            var partExtension = ImagePartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddImagePart(contentType);
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
                case ChartDrawingPart.RelationshipTypeConstant:
                    return new ChartDrawingPart();
                case EmbeddedPackagePart.RelationshipTypeConstant:
                    return new EmbeddedPackagePart();
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
                case ThemeOverridePart.RelationshipTypeConstant:
                    return new ThemeOverridePart();
                case ChartStylePart.RelationshipTypeConstant:
                    return new ChartStylePart();
                case ChartColorStylePart.RelationshipTypeConstant:
                    return new ChartColorStylePart();
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
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes",
                        new PartConstraintRule(nameof(ChartDrawingPart), ChartDrawingPart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
                        new PartConstraintRule(nameof(EmbeddedPackagePart), null, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                        new PartConstraintRule(nameof(ImagePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride",
                        new PartConstraintRule(nameof(ThemeOverridePart), ThemeOverridePart.ContentTypeConstant, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2011/relationships/chartStyle",
                        new PartConstraintRule(nameof(ChartStylePart), ChartStylePart.ContentTypeConstant, false, true, FileFormatVersions.Office2013.AndLater())
                    },
                    {
                        "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle",
                        new PartConstraintRule(nameof(ChartColorStylePart), ChartColorStylePart.ContentTypeConstant, false, true, FileFormatVersions.Office2013.AndLater())
                    }
                };
            }

            return _partConstraint;
        }
    }
}
