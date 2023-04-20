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
        internal static OpenXmlPart InitPart(this OpenXmlPartContainer parent, OpenXmlPart childPart, PartTypeInfo partType, string? relId = null)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(message: "Parent part MUST be provided.", paramName: nameof(parent));
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
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static AlternativeFormatImportPart AddAlternativeFormatImportPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<AlternativeFormatImportPart>
        {
            return (AlternativeFormatImportPart)OpenXmlPartExtensions.InitPart(parent, new AlternativeFormatImportPart(), partType, id);
        }

        /// <summary>
        /// Adds a CustomPropertyPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static CustomPropertyPart AddCustomPropertyPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<CustomPropertyPart>
        {
            return (CustomPropertyPart)OpenXmlPartExtensions.InitPart(parent, new CustomPropertyPart(), partType, id);
        }

        /// <summary>
        /// Adds a CustomXmlPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static CustomXmlPart AddCustomXmlPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<CustomXmlPart>
        {
            return (CustomXmlPart)OpenXmlPartExtensions.InitPart(parent, new CustomXmlPart(), partType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistenceBinaryDataPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<EmbeddedControlPersistenceBinaryDataPart>
        {
            return (EmbeddedControlPersistenceBinaryDataPart)OpenXmlPartExtensions.InitPart(parent, new EmbeddedControlPersistenceBinaryDataPart(), partType, id);
        }

        /// <summary>
        /// Adds a EmbeddedControlPersistencePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<EmbeddedControlPersistencePart>
        {
            return (EmbeddedControlPersistencePart)OpenXmlPartExtensions.InitPart(parent, new EmbeddedControlPersistencePart(), partType, id);
        }

        /// <summary>
        /// Adds a EmbeddedObjectPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static EmbeddedObjectPart AddEmbeddedObjectPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<EmbeddedObjectPart>
        {
            return (EmbeddedObjectPart)OpenXmlPartExtensions.InitPart(parent, new EmbeddedObjectPart(), partType, id);
        }

        /// <summary>
        /// Adds a EmbeddedPackagePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static EmbeddedPackagePart AddEmbeddedPackagePart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<EmbeddedPackagePart>
        {
            return (EmbeddedPackagePart)OpenXmlPartExtensions.InitPart(parent, new EmbeddedPackagePart(), partType, id);
        }

        /// <summary>
        /// Adds a FontPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static FontPart AddFontPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<FontPart>
        {
            return (FontPart)OpenXmlPartExtensions.InitPart(parent, new FontPart(), partType, id);
        }

        /// <summary>
        /// Adds an ImagePart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static ImagePart AddImagePart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<ImagePart>
        {
            return (ImagePart)OpenXmlPartExtensions.InitPart(parent, new ImagePart(), partType, id);
        }

        /// <summary>
        /// Adds a MailMergeRecipientDataPart as a relationship to the parent part
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static MailMergeRecipientDataPart AddMailMergeRecipientDataPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<MailMergeRecipientDataPart>
        {
            return (MailMergeRecipientDataPart)OpenXmlPartExtensions.InitPart(parent, new MailMergeRecipientDataPart(), partType, id);
        }

        /// <summary>
        /// Adds a ThumbnailPart as a relationship to the parent part.
        /// </summary>
        /// <param name="parent">The parent part requesting to add. Required.</param>
        /// <param name="partType">The part type information for the added extensible part. Required.</param>
        /// <param name="id">The relationship id. Optional, default to null.</param>
        /// <return>The newly added part</return>
        public static ThumbnailPart AddThumbnailPart<T>(this T parent, PartTypeInfo partType, string? id = null)
            where T : OpenXmlPart, ISupportExtensibleRelationship<ThumbnailPart>
        {
            return (ThumbnailPart)OpenXmlPartExtensions.InitPart(parent, new ThumbnailPart(), partType, id);
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

    /// <summary>
    /// Defines the interface for tagging a part that can add extensible parts.
    /// </summary>
    /// <typeparam name="TPart">Extensible part type that is supported by the implementing class.</typeparam>
#pragma warning disable CA1040 // Avoid empty interfaces
    public interface ISupportExtensibleRelationship<TPart>
#pragma warning restore CA1040 // Avoid empty interfaces
        where TPart : OpenXmlPart
    {
    }
}
