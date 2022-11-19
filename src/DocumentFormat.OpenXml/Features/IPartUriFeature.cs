// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features;

internal interface IPartUriFeature
{
    Uri CreatePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt, bool forceUnique = true);

    Uri EnsureUniquePartUri(string contentType, Uri parentUri, Uri targetUri);

    void ReserveUri(string contentType, Uri partUri);
}
