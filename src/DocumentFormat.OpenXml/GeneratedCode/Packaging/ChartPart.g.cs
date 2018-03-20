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
    [ContentType(ContentTypeConstant)]
    public partial class ChartPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.drawingml.chart+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart";
        private static PartConstraintCollection _partConstraints;
        private DocumentFormat.OpenXml.Drawing.Charts.ChartSpace _rootElement;

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
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartSpace ChartSpace
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Drawing.Charts.ChartSpace>();
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

        private protected override OpenXmlPartRootElement InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Drawing.Charts.ChartSpace;
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
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chartUserShapes",
                            PartConstraintRule.Create<ChartDrawingPart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package",
                            PartConstraintRule.Create<EmbeddedPackagePart>(false, false)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                            PartConstraintRule.Create<ImagePart>(false, true)
                        },
                        {
                            "http://schemas.openxmlformats.org/officeDocument/2006/relationships/themeOverride",
                            PartConstraintRule.Create<ThemeOverridePart>(false, false)
                        },
                        {
                            "http://schemas.microsoft.com/office/2011/relationships/chartStyle",
                            PartConstraintRule.Create<ChartStylePart>(false, true)
                        },
                        {
                            "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle",
                            PartConstraintRule.Create<ChartColorStylePart>(false, true)
                        }
                    };
                }

                return _partConstraints;
            }
        }

        internal override OpenXmlPartRootElement PartRootElement => ChartSpace;

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
    }
}
