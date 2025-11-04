// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Features;

internal class StreamPackageFeature : PackageFeatureBase, IDisposable, IPackageStreamFeature
{
    private Package _package;
    private Stream _stream;
    private bool _disposedValue;
    private bool _isOwned;

    public StreamPackageFeature(Stream stream, PackageOpenMode openMode, bool isOwned = false)
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

        var initialMode = openMode switch
        {
            PackageOpenMode.Create => FileMode.Create,
            PackageOpenMode.Read => FileMode.Open,
            PackageOpenMode.ReadWrite => FileMode.OpenOrCreate,
            _ => throw new NotImplementedException(),
        };

        // Only the initial should create, after that, it should be open
        Mode = initialMode == FileMode.Create ? Mode = FileMode.Open : initialMode;
        Access = openMode == PackageOpenMode.Read ? FileAccess.Read : FileAccess.ReadWrite;

        try
        {
            InitializePackage(initialMode, Access);
        }
        catch when (isOwned)
        {
            if (_stream is not null && IsEncryptedOfficeFile(_stream))
            {
                _stream.Dispose();
                throw new OpenXmlPackageException(ExceptionMessages.EncryptedPackageNotSupported);
            }

            _stream?.Dispose();
            throw;
        }

        _isOwned = isOwned;
    }

    protected FileAccess Access { get; }

    protected FileMode Mode { get; }

    public Stream Stream
    {
        get => _stream;
        set
        {
            if (SetStream(value))
            {
                // Once we set a new stream, it will be owned by the package
                _isOwned = true;

                Reload();
            }
        }
    }

    [MemberNotNull(nameof(_stream))]
    private bool SetStream(Stream stream)
    {
        if (ReferenceEquals(_stream, stream))
        {
            return false;
        }

        DisposeStreamIfOwned();

        _stream = stream;
        return true;
    }

    protected void DisposeStreamIfOwned()
    {
        if (_isOwned && _stream is not null)
        {
            _stream.Dispose();
            _stream = null!;
        }
    }

    protected virtual Stream GetStream(FileMode mode, FileAccess access) => Stream;

    [MemberNotNull(nameof(_package))]
    private void InitializePackage(FileMode? mode = default, FileAccess? access = default)
    {
        mode ??= Mode;
        access ??= Access;

        _package?.Close();

        if (_stream is null || Mode != mode || Access != access)
        {
            SetStream(GetStream(mode.Value, access.Value));
        }

        try
        {
            _package = Package.Open(_stream, mode.Value, access.Value);
        }
        catch (ArgumentException ex)
        {
            throw new OpenXmlPackageException(ExceptionMessages.FailedToOpenPackage, ex);
        }
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

                if (_isOwned)
                {
                    _stream.Dispose();
                }
            }

            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected override void Register(IFeatureCollection features)
    {
        base.Register(features);

        features.Set<IPackageStreamFeature>(this);
        features.GetRequired<IDisposableFeature>().Register(this);
    }

    private static bool IsEncryptedOfficeFile(Stream inputStream)
    {
        if (!inputStream.CanSeek)
        {
            throw new ArgumentException("Stream must be seekable.");
        }

        long originalPosition = inputStream.Position;

        try
        {
            byte[] header = new byte[8];
            inputStream.Seek(0, SeekOrigin.Begin);
            int read = inputStream.Read(header, 0, header.Length);
            inputStream.Seek(originalPosition, SeekOrigin.Begin);

            // OLE Compound File signature for encrypted Office files
            byte[] oleSignature = { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 };
            if (read == 8 && header.SequenceEqual(oleSignature))
            {
                return true;
            }

            // If not OLE, try to open as package and check for encrypted part
            try
            {
                using (var package = System.IO.Packaging.Package.Open(inputStream, FileMode.Open, FileAccess.Read))
                {
                    foreach (var part in package.GetParts())
                    {
                        if (part.ContentType.Equals("application/vnd.openxmlformats-officedocument.encrypted-package", StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
        finally
        {
            inputStream.Seek(originalPosition, SeekOrigin.Begin);
        }
    }
}
