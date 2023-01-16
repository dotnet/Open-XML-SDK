// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging.Builder;

internal static class LargePartStreamExtensions
{
    internal static IFeatureCollection EnableLargePartStreams(this IFeatureCollection features)
    {
        var feature = features.GetRequired<IPackageFeature>();

        // If the package is readonly, we do not need to handle this
        if (feature.Package.FileOpenAccess == FileAccess.Read)
        {
            return features;
        }

        if (!feature.Capabilities.HasFlagFast(PackageCapabilities.LargePartStreams))
        {
            return features;
        }

        // Required to support feature
        if (!feature.Capabilities.HasFlagFast(PackageCapabilities.Reload))
        {
            return features;
        }

        var newFeature = new TemporaryStreamPackage(feature);

        features.Set<IPackageFeature>(newFeature);
        features.GetRequired<IDisposableFeature>().Register(newFeature);

        return features;
    }

    private sealed class TemporaryStreamPackage : DelegatingPackageFeature, IDisposable
    {
        private Dictionary<Uri, Stream>? _streams;

        public TemporaryStreamPackage(IPackageFeature package)
            : base(package)
        {
        }

        public override PackageCapabilities Capabilities => base.Capabilities & PackageCapabilities.LargePartStreams;

        public Stream GetStream(Uri uri, FileMode mode, FileAccess access, IPackagePart originalPart)
        {
            if (_streams is not null && _streams.TryGetValue(uri, out var existing))
            {
                return new LargePartStream(EnsureAccess(existing, access));
            }

            // We don't need to do any redirection if it is just reading the stream
            if (access == FileAccess.Read)
            {
                return originalPart.GetStream(mode, access);
            }

            if (_streams is null)
            {
                _streams = new();
            }

            var path = Path.GetTempFileName();
            var stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.DeleteOnClose);
            _streams[uri] = stream;

            // In this case, we will overwrite the existing stream
            if (mode != FileMode.Create)
            {
                using var original = originalPart.GetStream(mode, FileAccess.Read);
                original.CopyTo(stream);
                stream.Position = 0;
            }

            return new LargePartStream(EnsureAccess(stream, access));
        }

        private static Stream EnsureAccess(Stream stream, FileAccess access)
        {
            if (access == FileAccess.Write)
            {
                return new WriteOnlyStream(stream);
            }
            else if (access == FileAccess.Read)
            {
                return new ReadOnlyStream(stream);
            }
            else
            {
                return stream;
            }
        }

        public override void Save()
        {
            base.Save();

            if (_streams is { } streams)
            {
                Feature.Reload(access: FileAccess.Write);

                WriteStreams(streams);
                _streams = null;

                Feature.Reload();
            }
        }

        private void WriteStreams(Dictionary<Uri, Stream> files)
        {
            foreach (var entry in files)
            {
                using var stream = entry.Value;
                using var partStream = base.GetPart(entry.Key).GetStream(FileMode.Create, FileAccess.Write);

                stream.CopyTo(partStream);
            }
        }

        private IPackagePart Wrap(IPackagePart part) => new TemporaryStreamPart(this, part);

        public override IPackagePart CreatePart(Uri partUri, string contentType, CompressionOption compressionOption)
            => Wrap(base.CreatePart(partUri, contentType, compressionOption));

        public override void DeletePart(Uri uri)
        {
            if (_streams is not null && _streams.TryGetValue(uri, out var existing))
            {
                existing.Dispose();
                _streams.Remove(uri);
            }

            base.DeletePart(uri);
        }

        public override IPackagePart GetPart(Uri uriTarget)
            => Wrap(base.GetPart(uriTarget));

        public override IEnumerable<IPackagePart> GetParts()
        {
            foreach (var inner in base.GetParts())
            {
                yield return Wrap(inner);
            }
        }

        public void Dispose()
        {
            if (_streams is not null)
            {
                foreach (var item in _streams.Values)
                {
                    item.Dispose();
                }

                _streams = null;
            }
        }
    }

    private sealed class TemporaryStreamPart : DelegatingPackagePart
    {
        private readonly TemporaryStreamPackage _package;

        public TemporaryStreamPart(TemporaryStreamPackage package, IPackagePart part)
            : base(package, part)
        {
            _package = package;
        }

        public override Stream GetStream(FileMode open, FileAccess write)
        {
            return _package.GetStream(Uri, open, write, OriginalPart);
        }
    }

    internal sealed class LargePartStream : DelegatingStream
    {
        public LargePartStream(Stream innerStream)
            : base(innerStream)
        {
            InUse = true;
        }

        public bool InUse { get; private set; }

        protected override void Dispose(bool disposing)
        {
            InUse = false;
            Position = 0;
        }
    }
}
