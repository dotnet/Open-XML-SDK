// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.IO;
using System.Threading;

namespace DocumentFormat.OpenXml.Packaging;

internal static class WriteableStreamExtensions
{
    /// <summary>
    /// Attempts to replace the underlying stream so that we can modify it even in readonly situations via a copy
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposable is registered with package")]
    public static bool EnableWriteableStream(this IFeatureCollection features)
    {
        if (features.Get<IPackageStreamFeature>() is { Stream: { CanWrite: false, CanSeek: true } } feature &&
            features.Get<IPackageFeature>() is { } packageFeature &&
            packageFeature.Capabilities.HasFlagFast(PackageCapabilities.Reload))
        {
            var tempStream = new TemporaryFile();

            feature.Stream.Position = 0;
            feature.Stream.CopyTo(tempStream.Stream);

            tempStream.Stream.Position = 0;
            feature.Stream = tempStream.Stream;

            features.GetRequired<IDisposableFeature>().Register(tempStream);

            return true;
        }

        return false;
    }

    private sealed class TemporaryFile : IDisposable
    {
        private const int DefaultBufferSize = 4096;

        public TemporaryFile()
        {
            Stream = new FileStream(Path.GetTempFileName(), FileMode.Create, FileAccess.ReadWrite, FileShare.None, DefaultBufferSize, FileOptions.DeleteOnClose);
        }

        public Stream Stream { get; }

        public void Dispose()
        {
            Stream.Dispose();
        }
    }
}
