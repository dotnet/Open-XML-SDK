// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    internal sealed class PackagePartUriHelper : IPartUriFeature
    {
        private readonly PartUriHelper _other;
        private readonly IContainerFeature<OpenXmlPackage> _package;

        public PackagePartUriHelper(IContainerFeature<OpenXmlPackage> package)
        {
            _other = new PartUriHelper();
            _package = package;
        }

        public Uri CreatePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt, bool forceUnique = true)
        {
            Uri partUri;

            do
            {
                partUri = _other.CreatePartUri(contentType, parentUri, targetPath, targetName, targetExt, forceUnique);
            }
            while (_package.Value.Package.PartExists(partUri));

            return partUri;
        }

        public Uri EnsureUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
        {
            Uri partUri;

            do
            {
                partUri = _other.EnsureUniquePartUri(contentType, parentUri, targetUri);
            }
            while (_package.Value.Package.PartExists(partUri));

            return partUri;
        }

        public void ReserveUri(string contentType, Uri partUri) => _other.ReserveUri(contentType, partUri);
    }
}
