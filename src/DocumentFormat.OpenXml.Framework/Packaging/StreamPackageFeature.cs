// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging;

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

        Stream = openMode == PackageOpenMode.Read && stream.CanWrite ? new ReadOnlyStream(stream) : stream;

        var access = openMode == PackageOpenMode.Read ? FileAccess.Read : FileAccess.ReadWrite;
        var mode = openMode switch
        {
            PackageOpenMode.Create => FileMode.Create,
            PackageOpenMode.Read => FileMode.Open,
            PackageOpenMode.ReadWrite => FileMode.OpenOrCreate,
            _ => throw new NotImplementedException(),
        };

        Initialize(mode, access);
    }

    protected Stream Stream { get; }

    [MemberNotNull(nameof(_package))]
    private void Initialize(FileMode mode, FileAccess access)
    {
        _package?.Close();
        _package = Package.Open(Stream, mode, access);
    }

    protected override Package Package => _package;

    IPackage IPackageFeature.Package => this;

    bool IPackageFeature.CanReload => true;

    void IPackageFeature.Reload(FileMode mode, FileAccess access)
        => Initialize(mode, access);

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
