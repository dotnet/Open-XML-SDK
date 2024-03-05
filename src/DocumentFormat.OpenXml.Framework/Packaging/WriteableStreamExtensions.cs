// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System.IO;

namespace DocumentFormat.OpenXml.Packaging;

internal static class WriteableStreamExtensions
{
    private const int DefaultBufferSize = 4096;

    /// <summary>
    /// Attempts to replace the underlying stream so that we can modify it even in readonly situations via a copy
    /// </summary>
    public static bool EnableWriteableStream(this IFeatureCollection features)
    {
        if (features.Get<IPackageStreamFeature>() is { Stream: { CanWrite: false, CanSeek: true } } feature &&
            features.Get<IPackageFeature>() is { } packageFeature &&
            packageFeature.Capabilities.HasFlagFast(PackageCapabilities.Reload))
        {
            var tempStream = new FileStream(Path.GetTempFileName(), FileMode.Create, FileAccess.ReadWrite, FileShare.None, DefaultBufferSize, FileOptions.DeleteOnClose);

            feature.Stream.Position = 0;
            feature.Stream.CopyTo(tempStream);

            tempStream.Position = 0;

            // IPackageStreamFeature will take ownership of the stream it is supplied. Since it has DeleteOnClose, it will be deleted
            // when the package is closed.
            feature.Stream = tempStream;

            return true;
        }

        return false;
    }
}
