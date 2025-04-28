// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Defines extensions for part relationships
/// </summary>
public static class OpenXmlSupportedRelationshipExtensions
{
    private static TChild InitPart<TChild>(this OpenXmlPartContainer? parent, TChild childPart, PartTypeInfo partType, string? relId = null)
        where TChild : OpenXmlPart
    {
        if (parent == null)
        {
            throw new ArgumentNullException(paramName: nameof(parent));
        }

        string contentType = partType.ContentType;

        var partExtension = partType.Extension;
        parent.Features.Get<IPartExtensionFeature>()?.Register(contentType, partExtension);

        if (relId == null || relId.Length == 0)
        {
            relId = null;
        }

        parent.InitPart(childPart, contentType, relId);
        return childPart;
    }

    private static T DoInitPart<T>(OpenXmlPartContainer parent, T childPart, string contentType, string? id = null)
        where T : OpenXmlPart
    {
        if (parent == null)
        {
            throw new ArgumentNullException(nameof(parent));
        }

        parent.InitPart(childPart, contentType, id);

        return childPart;
    }

    /// <summary>
    /// Adds a <see cref="AlternativeFormatImportPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static AlternativeFormatImportPart AddAlternativeFormatImportPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer?, ISupportedRelationship<AlternativeFormatImportPart>?
        => InitPart(parent, new AlternativeFormatImportPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="AlternativeFormatImportPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static AlternativeFormatImportPart AddAlternativeFormatImportPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<AlternativeFormatImportPart>
        => DoInitPart(parent, new AlternativeFormatImportPart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="CustomPropertyPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static CustomPropertyPart AddCustomPropertyPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<CustomPropertyPart>
        => InitPart(parent, new CustomPropertyPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="CustomPropertyPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static CustomPropertyPart AddCustomPropertyPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<CustomPropertyPart>
        => DoInitPart(parent, new CustomPropertyPart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="CustomXmlPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static CustomXmlPart AddCustomXmlPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<CustomXmlPart>
        => InitPart(parent, new CustomXmlPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="CustomXmlPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static CustomXmlPart AddCustomXmlPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<CustomXmlPart>
        => DoInitPart(parent, new CustomXmlPart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedControlPersistenceBinaryDataPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedControlPersistenceBinaryDataPart>
        => InitPart(parent, new EmbeddedControlPersistenceBinaryDataPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedControlPersistenceBinaryDataPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedControlPersistenceBinaryDataPart AddEmbeddedControlPersistenceBinaryDataPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedControlPersistenceBinaryDataPart>
        => DoInitPart(parent, new EmbeddedControlPersistenceBinaryDataPart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedControlPersistencePart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedControlPersistencePart>
        => InitPart(parent, new EmbeddedControlPersistencePart(), partType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedControlPersistencePart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedControlPersistencePart AddEmbeddedControlPersistencePart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedControlPersistencePart>
        => DoInitPart(parent, new EmbeddedControlPersistencePart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedObjectPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedObjectPart AddEmbeddedObjectPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedObjectPart>
        => InitPart(parent, new EmbeddedObjectPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedObjectPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedObjectPart AddEmbeddedObjectPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedObjectPart>
        => DoInitPart(parent, new EmbeddedObjectPart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedPackagePart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedPackagePart AddEmbeddedPackagePart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedPackagePart>
        => InitPart(parent, new EmbeddedPackagePart(), partType, id);

    /// <summary>
    /// Adds a <see cref="EmbeddedPackagePart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static EmbeddedPackagePart AddEmbeddedPackagePart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<EmbeddedPackagePart>
        => DoInitPart(parent, new EmbeddedPackagePart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="FontPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static FontPart AddFontPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<FontPart>
        => InitPart(parent, new FontPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="FontPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static FontPart AddFontPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<FontPart>
        => DoInitPart(parent, new FontPart(), contentType, id);

    /// <summary>
    /// Adds an ImagePart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static ImagePart AddImagePart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<ImagePart>
        => InitPart(parent, new ImagePart(), partType, id);

    /// <summary>
    /// Adds a <see cref="ImagePart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static ImagePart AddImagePart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<ImagePart>
        => DoInitPart(parent, new ImagePart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="MailMergeRecipientDataPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static MailMergeRecipientDataPart AddMailMergeRecipientDataPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<MailMergeRecipientDataPart>
        => InitPart(parent, new MailMergeRecipientDataPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="MailMergeRecipientDataPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static MailMergeRecipientDataPart AddMailMergeRecipientDataPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<MailMergeRecipientDataPart>
        => DoInitPart(parent, new MailMergeRecipientDataPart(), contentType, id);

    /// <summary>
    /// Adds a <see cref="ThumbnailPart"/> as a relationship to the parent part.
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="partType">The part type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static ThumbnailPart AddThumbnailPart<T>(this T parent, PartTypeInfo partType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<ThumbnailPart>
        => InitPart(parent, new ThumbnailPart(), partType, id);

    /// <summary>
    /// Adds a <see cref="ThumbnailPart"/> as a relationship to the parent part
    /// </summary>
    /// <param name="parent">The parent part requesting to add.</param>
    /// <param name="contentType">The content type information for the added extensible part.</param>
    /// <param name="id">The relationship id. Optional, default to null.</param>
    /// <return>The newly added part</return>
    public static ThumbnailPart AddThumbnailPart<T>(this T parent, string contentType, string? id = null)
        where T : OpenXmlPartContainer, ISupportedRelationship<ThumbnailPart>
        => DoInitPart(parent, new ThumbnailPart(), contentType, id);
}
