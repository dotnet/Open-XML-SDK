// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal class StreamPackageFeature : PackageBase, IPackageFeature, IDisposable
{
    private Package _package;
    private bool _disposedValue;

    public StreamPackageFeature(Stream stream, PackageOpenMode openMode)
    {
        if (stream is null)
        {
            throw new ArgumentNullException(nameof(stream));
        }

        if (!stream.CanRead)
        {
            throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldRead);
        }

        if (openMode != PackageOpenMode.Read && !stream.CanWrite)
        {
            throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldBeWrite);
        }

        // Ensure the stream we're operating on is readonly if that is the requested mode
        Stream = openMode == PackageOpenMode.Read && stream.CanWrite ? new ReadOnlyStream(stream) : stream;

        _initialAccess = openMode == PackageOpenMode.Read ? FileAccess.Read : FileAccess.ReadWrite;
        _initialMode = openMode switch
        {
            PackageOpenMode.Create => FileMode.Create,
            PackageOpenMode.Read => FileMode.Open,
            PackageOpenMode.ReadWrite => FileMode.OpenOrCreate,
            _ => throw new NotImplementedException(),
        };

        InitializePackage();
    }

    protected Stream Stream { get; }

    private readonly FileAccess _initialAccess;
    private readonly FileMode _initialMode;

    [MemberNotNull(nameof(_package))]
    private void InitializePackage(FileMode? mode = default, FileAccess? access = default)
    {
        _package?.Close();
        _package = Package.Open(Stream, mode ?? _initialMode, access ?? _initialAccess);
    }

    protected override Package Package => _package;

    IPackage IPackageFeature.Package => this;

    bool IPackageFeature.CanReload => true;

    void IPackageFeature.Reload(FileMode? mode, FileAccess? access)
        => InitializePackage(mode, access);

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                _package.Close();
            }

            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
