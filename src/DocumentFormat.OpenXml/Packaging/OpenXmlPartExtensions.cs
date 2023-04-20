// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines extensions for part relationships
    /// </summary>
    public static class OpenXmlPartExtensions
    {
        private static TChild InitPart<TChild>(this OpenXmlPartContainer parent, TChild childPart, PartTypeInfo partType, string? relId = null)
            where TChild : OpenXmlPart
        {
            if (parent == null)
            {
                throw new ArgumentNullException(paramName: nameof(parent));
            }

            string contentType = partType.ContentType;

            var partExtension = partType.Extension;
            parent.Features.GetRequired<IPartExtensionFeature>().Register(contentType, partExtension);

            if (relId == null || relId.Length == 0)
            {
                relId = null;
            }

            parent.InitPart(childPart, contentType, relId);
            return childPart;
        }

        /// <summary>
        /// Adds a AlternativeFormatImportPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="AlternativeFormatImportPart"/>
        public static AlternativeFormatImportPart AddAlternativeFormatImportPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<AlternativeFormatImportPart> => OpenXmlPartExtensions.InitPart<AlternativeFormatImportPart>(parent, new AlternativeFormatImportPart(), partType, id);

        /// <summary>
        /// Adds a AlternativeFormatImportPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="AlternativeFormatImportPart"/>
        public static AlternativeFormatImportPart AddAlternativeFormatImportPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<AlternativeFormatImportPart>
        {
            AlternativeFormatImportPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomPropertyPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="CustomPropertyPart"/>
        public static CustomPropertyPart AddCustomPropertyPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<CustomPropertyPart> => OpenXmlPartExtensions.InitPart<CustomPropertyPart>(parent, new CustomPropertyPart(), partType, id);

        /// <summary>
        /// Adds a CustomPropertyPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="CustomPropertyPart"/>
        public static CustomPropertyPart AddCustomPropertyPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<CustomPropertyPart>
        {
            CustomPropertyPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a CustomXmlPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="CustomXmlPart"/>
        public static CustomXmlPart AddCustomXmlPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<CustomXmlPart> => OpenXmlPartExtensions.InitPart<CustomXmlPart>(parent, new CustomXmlPart(), partType, id);

        /// <summary>
        /// Adds a CustomXmlPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="CustomXmlPart"/>
        public static CustomXmlPart AddCustomXmlPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<CustomXmlPart>
        {
            CustomXmlPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedControlPersistenceBinaryDataPart"/>
        public static EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedControlPersistenceBinaryDataPart> => OpenXmlPartExtensions.InitPart<EmbeddedControlPersistenceBinaryDataPart>(parent, new EmbeddedControlPersistenceBinaryDataPart(), partType, id);

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedControlPersistenceBinaryDataPart"/>
        public static EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedControlPersistenceBinaryDataPart>
        {
            EmbeddedControlPersistenceBinaryDataPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedControlPersistencePart"/>
        public static EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedControlPersistencePart> => OpenXmlPartExtensions.InitPart<EmbeddedControlPersistencePart>(parent, new EmbeddedControlPersistencePart(), partType, id);

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedControlPersistencePart"/>
        public static EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedControlPersistencePart>
        {
            EmbeddedControlPersistencePart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedObjectPart"/>
        public static EmbeddedObjectPart AddEmbeddedObjectPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedObjectPart> => OpenXmlPartExtensions.InitPart<EmbeddedObjectPart>(parent, new EmbeddedObjectPart(), partType, id);

        /// <summary>
        /// Adds a EmbeddedObjectPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedObjectPart"/>
        public static EmbeddedObjectPart AddEmbeddedObjectPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedObjectPart>
        {
            EmbeddedObjectPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a EmbeddedPackagePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedPackagePart"/>
        public static EmbeddedPackagePart AddEmbeddedPackagePart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedPackagePart> => OpenXmlPartExtensions.InitPart<EmbeddedPackagePart>(parent, new EmbeddedPackagePart(), partType, id);

        /// <summary>
        /// Adds a EmbeddedPackagePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="EmbeddedPackagePart"/>
        public static EmbeddedPackagePart AddEmbeddedPackagePart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<EmbeddedPackagePart>
        {
            EmbeddedPackagePart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a FontPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="FontPart"/>
        public static FontPart AddFontPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<FontPart> => OpenXmlPartExtensions.InitPart<FontPart>(parent, new FontPart(), partType, id);

        /// <summary>
        /// Adds a FontPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="FontPart"/>
        public static FontPart AddFontPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<FontPart>
        {
            FontPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds an ImagePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="ImagePart"/>
        public static ImagePart AddImagePart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<ImagePart> => OpenXmlPartExtensions.InitPart<ImagePart>(parent, new ImagePart(), partType, id);

        /// <summary>
        /// Adds a ImagePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="ImagePart"/>
        public static ImagePart AddImagePart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<ImagePart>
        {
            ImagePart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="MailMergeRecipientDataPart"/>
        public static MailMergeRecipientDataPart AddMailMergeRecipientDataPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<MailMergeRecipientDataPart> => OpenXmlPartExtensions.InitPart<MailMergeRecipientDataPart>(parent, new MailMergeRecipientDataPart(), partType, id);

        /// <summary>
        /// Adds a MailMergeRecipientDataPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="MailMergeRecipientDataPart"/>
        public static MailMergeRecipientDataPart AddMailMergeRecipientDataPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<MailMergeRecipientDataPart>
        {
            MailMergeRecipientDataPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }

        /// <summary>
        /// Adds a ThumbnailPart as a relationship to the parent part.
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="partType">The part type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="ThumbnailPart"/>
        public static ThumbnailPart AddThumbnailPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<ThumbnailPart> => OpenXmlPartExtensions.InitPart<ThumbnailPart>(parent, new ThumbnailPart(), partType, id);

        /// <summary>
        /// Adds a ThumbnailPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add.</param>
        /// <param name="contentType">The content type information for the added extensible part.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        /// <see cref="ThumbnailPart"/>
        public static ThumbnailPart AddThumbnailPart<T>(this T parent, string contentType, string? id = null)
            where T : OpenXmlPart, ISupportRelationship<ThumbnailPart>
        {
            ThumbnailPart childPart = new();

            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent));
            }

            parent.InitPart(childPart, contentType, id);
            return childPart;
        }
    }

    /// <summary>
    /// Defines information used in creating a new part.
    /// </summary>
    public readonly record struct PartTypeInfo
    {
        /// <summary>
        /// Ctor - assign content type and extention.
        /// </summary>
        public PartTypeInfo(string contentType, string extension)
        {
            ContentType = contentType;
            Extension = extension;
        }

        /// <summary>
        /// Gets content type for the part.
        /// </summary>
        public string ContentType { get; }

        /// <summary>
        /// Gets the file extension for the part.
        /// </summary>
        public string Extension { get; }
    }
}
