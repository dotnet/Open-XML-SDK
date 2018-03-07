// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the DocumentSettingsPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class DocumentSettingsPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings";
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint;
        private static Dictionary<string, PartConstraintRule> _partConstraint;

        /// <summary>
        /// Creates an instance of the DocumentSettingsPart OpenXmlType
        /// </summary>
        internal protected DocumentSettingsPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the ImageParts of the DocumentSettingsPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <summary>
        /// Gets the MailMergeRecipientDataPart of the DocumentSettingsPart
        /// </summary>
        public MailMergeRecipientDataPart MailMergeRecipientDataPart => GetSubPartOfType<MailMergeRecipientDataPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "settings";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        /// <summary>
        /// Adds a ImagePart to the DocumentSettingsPart
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
        /// Adds a ImagePart to the DocumentSettingsPart
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
        /// Adds a ImagePart to the DocumentSettingsPart
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
        /// Adds a ImagePart to the DocumentSettingsPart
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

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="contentType">The content type of the MailMergeRecipientDataPart</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType)
        {
            var childPart = new MailMergeRecipientDataPart();
            InitPart(childPart, contentType);
            return childPart;
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="contentType">The content type of the MailMergeRecipientDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(string contentType, string id)
        {
            var childPart = new MailMergeRecipientDataPart();
            InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="partType">The part type of the MailMergeRecipientDataPart</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType, string id)
        {
            var contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
            var partExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddMailMergeRecipientDataPart(contentType, id);
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart to the DocumentSettingsPart
        /// </summary>
        /// <param name="partType">The part type of the MailMergeRecipientDataPart</param>
        /// <return>The newly added part</return>
        public MailMergeRecipientDataPart AddMailMergeRecipientDataPart(MailMergeRecipientDataPartType partType)
        {
            var contentType = MailMergeRecipientDataPartTypeInfo.GetContentType(partType);
            var partExtension = MailMergeRecipientDataPartTypeInfo.GetTargetExtension(partType);
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, partExtension);
            return AddMailMergeRecipientDataPart(contentType);
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
                case MailMergeRecipientDataPart.RelationshipTypeConstant:
                    return new MailMergeRecipientDataPart();
                case ImagePart.RelationshipTypeConstant:
                    return new ImagePart();
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
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/recipientData",
                        new PartConstraintRule(nameof(MailMergeRecipientDataPart), null, false, false, FileFormatVersions.Office2007.AndLater())
                    },
                    {
                        "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image",
                        new PartConstraintRule(nameof(ImagePart), null, false, true, FileFormatVersions.Office2007.AndLater())
                    }
                };
            }

            return _partConstraint;
        }
    }
}
