// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Extensions to enable package cloning.
/// </summary>
public static class CloneableExtensions
{
    /// <summary>
    /// Creates an editable clone of this OpenXml package, opened on a
    /// <see cref="MemoryStream"/> with expandable capacity and using
    /// default OpenSettings.
    /// </summary>
    /// <returns>The cloned OpenXml package.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage)
        => openXmlPackage.Clone(new MemoryStream(), true, new OpenSettings());

    /// <summary>
    /// Creates a clone of this OpenXml package, opened on the given stream.
    /// The cloned OpenXml package is opened with the same settings, i.e.,
    /// FileOpenAccess and OpenSettings, as this OpenXml package.
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="stream">The IO stream on which to open the OpenXml package.</param>
    /// <returns>The cloned OpenXml package.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, Stream stream)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (stream is null)
        {
            throw new ArgumentNullException(nameof(stream));
        }

        return openXmlPackage.Clone(stream, openXmlPackage.FileOpenAccess == FileAccess.ReadWrite, openXmlPackage.OpenSettings);
    }

    /// <summary>
    /// Creates a clone of this OpenXml package, opened on the given stream.
    /// The cloned OpenXml package is opened with the same OpenSettings as
    /// this OpenXml package.
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="stream">The IO stream on which to open the OpenXml package.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>The cloned OpenXml package.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, Stream stream, bool isEditable)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (stream is null)
        {
            throw new ArgumentNullException(nameof(stream));
        }

        return openXmlPackage.Clone(stream, isEditable, openXmlPackage.OpenSettings);
    }

    /// <summary>
    /// Creates a clone of this OpenXml package, opened on the given stream.
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="stream">The IO stream on which to open the OpenXml package.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <param name="openSettings">The advanced settings for opening a document.</param>
    /// <returns>The cloned OpenXml package.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, Stream stream, bool isEditable, OpenSettings openSettings)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (stream is null)
        {
            throw new ArgumentNullException(nameof(stream));
        }

        return openXmlPackage.Features.GetRequired<IPackageFactoryFeature>()
            .Create()
            .WithSettings(openSettings)
            .WithStorage(stream, PackageOpenMode.Create)
            .CopyFrom(openXmlPackage)
            .Reload(isEditable)
            .UseDefaultBehavior();
    }

    /// <summary>
    /// Creates a clone of this OpenXml package opened from the given file
    /// (which will be created by cloning this OpenXml package).
    /// The cloned OpenXml package is opened with the same settings, i.e.,
    /// FileOpenAccess and OpenSettings, as this OpenXml package.
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="path">The path and file name of the target document.</param>
    /// <returns>The cloned document.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, string path)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentException($"'{nameof(path)}' cannot be null or empty.", nameof(path));
        }

        return openXmlPackage.Clone(path, openXmlPackage.FileOpenAccess == FileAccess.ReadWrite, openXmlPackage.OpenSettings);
    }

    /// <summary>
    /// Creates a clone of this OpenXml package opened from the given file
    /// (which will be created by cloning this OpenXml package).
    /// The cloned OpenXml package is opened with the same OpenSettings as
    /// this OpenXml package.
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="path">The path and file name of the target document.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <returns>The cloned document.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, string path, bool isEditable)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentException($"'{nameof(path)}' cannot be null or empty.", nameof(path));
        }

        return openXmlPackage.Clone(path, isEditable, openXmlPackage.OpenSettings);
    }

    /// <summary>
    /// Creates a clone of this OpenXml package opened from the given file (which
    /// will be created by cloning this OpenXml package).
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="path">The path and file name of the target document.</param>
    /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
    /// <param name="openSettings">The advanced settings for opening a document.</param>
    /// <returns>The cloned document.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, string path, bool isEditable, OpenSettings? openSettings)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (path is null)
        {
            throw new ArgumentNullException(nameof(path));
        }

        return openXmlPackage.Features.GetRequired<IPackageFactoryFeature>()
              .Create()
              .WithSettings(openSettings ?? new())
              .WithStorage(path, PackageOpenMode.Create)
              .CopyFrom(openXmlPackage)
              .Reload(isEditable)
              .UseDefaultBehavior();
    }

    /// <summary>
    /// Creates a clone of this OpenXml package, opened on the specified instance
    /// of Package. The clone will be opened with the same OpenSettings as this
    /// OpenXml package.
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="package">The specified instance of Package.</param>
    /// <returns>The cloned OpenXml package.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, Package package)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (package is null)
        {
            throw new ArgumentNullException(nameof(package));
        }

        return openXmlPackage.Clone(package, openXmlPackage.OpenSettings);
    }

    /// <summary>
    /// Creates a clone of this OpenXml package, opened on the specified instance
    /// of Package.
    /// </summary>
    /// <param name="openXmlPackage"></param>
    /// <param name="package">The specified instance of Package.</param>
    /// <param name="openSettings">The advanced settings for opening a document.</param>
    /// <returns>The cloned OpenXml package.</returns>
    public static OpenXmlPackage Clone(this OpenXmlPackage openXmlPackage, Package package, OpenSettings openSettings)
    {
        if (openXmlPackage is null)
        {
            throw new ArgumentNullException(nameof(openXmlPackage));
        }

        if (package is null)
        {
            throw new ArgumentNullException(nameof(package));
        }

        return openXmlPackage.Features.GetRequired<IPackageFactoryFeature>()
              .Create()
              .WithSettings(openSettings ?? new())
              .WithStorage(package)
              .CopyFrom(openXmlPackage)
              .UseDefaultBehavior();
    }

    private static OpenXmlPackage CopyFrom(this OpenXmlPackage destination, OpenXmlPackage source, OpenSettings? settings = null)
    {
        lock (source.Features.GetRequired<ILockFeature>().SyncLock)
        {
            var existing = destination.Features.GetRequired<IPartUriFeature>();
            destination.Features.Set<IPartUriFeature>(new CloningFeatures(existing));

            source.Save();

            foreach (var part in source.Parts)
            {
                destination.AddPart(part.OpenXmlPart, part.RelationshipId);
            }

            destination.OpenSettings = settings ?? new(source.OpenSettings);

            destination.Features.Set<IPartUriFeature>(existing);

            return destination;
        }
    }

    private static OpenXmlPackage Reload(this OpenXmlPackage openXmlPackage, bool isEditable)
    {
        if (openXmlPackage.Features.Get<IPackageFeature>() is { } package && package.Capabilities.HasFlagFast(PackageCapabilities.Reload))
        {
            package.Reload(access: isEditable ? FileAccess.ReadWrite : FileAccess.Read);
        }

        return openXmlPackage;
    }

    private sealed class CloningFeatures : IPartUriFeature
    {
        private readonly IPartUriFeature _other;

        public CloningFeatures(IPartUriFeature other)
        {
            _other = other;
        }

        Uri IPartUriFeature.CreatePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt, bool forceUnique)
            => _other.CreatePartUri(contentType, parentUri, targetPath, targetName, targetExt, forceUnique: false);

        Uri IPartUriFeature.EnsureUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
        {
            _other.ReserveUri(contentType, targetUri);
            return targetUri;
        }

        void IPartUriFeature.ReserveUri(string contentType, Uri partUri)
            => _other.ReserveUri(contentType, partUri);
    }
}
