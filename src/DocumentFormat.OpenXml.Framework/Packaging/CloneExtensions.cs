// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging;

internal static class CloneExtensions
{
    public static IDisposable EnableCloningFeatures(this OpenXmlPackage package)
        => new CloningFeatures(package);

    private class CloningFeatures : IPartUriFeature, IDisposable
    {
        private readonly OpenXmlPackage _package;
        private readonly IPartUriFeature _partUri;

        public CloningFeatures(OpenXmlPackage package)
        {
            _package = package;
            _partUri = package.Features.GetRequired<IPartUriFeature>();

            _package.Features.Set<IPartUriFeature>(this);
        }

        Uri IPartUriFeature.CreatePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt, bool forceUnique)
            => _partUri.CreatePartUri(contentType, parentUri, targetPath, targetName, targetExt, forceUnique: false);

        Uri IPartUriFeature.EnsureUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
        {
            _partUri.ReserveUri(contentType, targetUri);
            return targetUri;
        }

        void IPartUriFeature.ReserveUri(string contentType, Uri partUri)
            => _partUri.ReserveUri(contentType, partUri);

        void IDisposable.Dispose()
        {
            _package.Features.Set<IPartUriFeature>(_partUri);
        }
    }
}
