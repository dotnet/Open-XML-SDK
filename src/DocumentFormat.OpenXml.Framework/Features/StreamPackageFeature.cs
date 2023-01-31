// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Features;

internal class StreamPackageFeature : PackageFeatureBase, IDisposable, IPackageStreamFeature
{
    private readonly FileAccess _access;
    private readonly FileMode _mode;

    private Package _package;
    private bool _disposedValue;
    private Stream _stream;

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
        _stream = openMode == PackageOpenMode.Read && stream.CanWrite ? new ReadOnlyStream(stream) : stream;

        _access = openMode == PackageOpenMode.Read ? FileAccess.Read : FileAccess.ReadWrite;
        var initialMode = openMode switch
        {
            PackageOpenMode.Create => FileMode.Create,
            PackageOpenMode.Read => FileMode.Open,
            PackageOpenMode.ReadWrite => FileMode.OpenOrCreate,
            _ => throw new NotImplementedException(),
        };

        // Only the inital should create, after that, it should be open
        _mode = initialMode == FileMode.Create ? _mode = FileMode.Open : initialMode;

        InitializePackage(initialMode, _access);
    }

    public Stream Stream
    {
        get => _stream;
        set
        {
            _stream = value;
            Reload();
        }
    }

    [MemberNotNull(nameof(_package))]
    private void InitializePackage(FileMode? mode = default, FileAccess? access = default)
    {
        _package?.Close();
        _package = Package.Open(Stream, mode ?? _mode, access ?? _access);
    }

    protected override Package Package => _package;

    public override PackageCapabilities Capabilities => base.Capabilities | PackageCapabilities.Reload;

    public override void Reload(FileMode? mode = null, FileAccess? access = null)
    {
        InitializePackage(mode, access);
        UpdateCachedItems();
    }

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
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
