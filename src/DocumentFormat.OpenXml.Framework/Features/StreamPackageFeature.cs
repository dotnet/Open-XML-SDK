// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
#if !NETFRAMEWORK
using System.IO.Compression;
#endif
using System.IO.Packaging;

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
            if (_stream is not null && OpenXmlPackage.IsEncryptedOfficeFile(_stream))
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
            _stream = RepairRelsContentType(_stream);
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

    // Some OOXML producers omit the required <Default Extension="rels" .../> entry from
    // [Content_Types].xml (a known OPC spec deviation). System.IO.Packaging is strict: without
    // that registration it cannot resolve .rels parts, so package-level relationships are never
    // loaded and MainDocumentPart (and equivalents) come back null. Repair the stream in-memory
    // before handing it to Package.Open so the SDK behaves like Word Desktop and the MIP SDK,
    // both of which recover silently from this deviation.
    //
    // Gated on !NETFRAMEWORK because ZipArchive requires net45+ and the old System.IO.Packaging
    // on net35/net40/net46 is already lenient about missing content-type registrations.
#if !NETFRAMEWORK
    private static Stream RepairRelsContentType(Stream input)
    {
        const string Marker = "Extension=\"rels\"";
        const string Closing = "</Types>";
        const string Injection =
            "<Default Extension=\"rels\" " +
            "ContentType=\"application/vnd.openxmlformats-package.relationships+xml\"/>";

        if (!input.CanRead || !input.CanSeek)
        {
            return input;
        }

        long originalPosition = input.Position;

        try
        {
            string ctXml;
            using (var readZip = new ZipArchive(input, ZipArchiveMode.Read, leaveOpen: true))
            {
                var ctEntry = readZip.GetEntry("[Content_Types].xml");
                if (ctEntry is null)
                {
                    input.Position = originalPosition;
                    return input;
                }

                using var reader = new StreamReader(ctEntry.Open());
                ctXml = reader.ReadToEnd();
            }

#if NET6_0_OR_GREATER
            if (ctXml.Contains(Marker, StringComparison.Ordinal))
            {
                input.Position = originalPosition;
                return input;
            }

            int closingIdx = ctXml.IndexOf(Closing, StringComparison.Ordinal);
            string patched = closingIdx >= 0
                ? string.Concat(ctXml.AsSpan(0, closingIdx), Injection, ctXml.AsSpan(closingIdx))
                : ctXml + Injection;
#else
            if (ctXml.IndexOf(Marker, StringComparison.Ordinal) >= 0)
            {
                input.Position = originalPosition;
                return input;
            }

            int closingIdx = ctXml.IndexOf(Closing, StringComparison.Ordinal);
            string patched = closingIdx >= 0
                ? ctXml.Substring(0, closingIdx) + Injection + ctXml.Substring(closingIdx)
                : ctXml + Injection;
#endif

            input.Position = originalPosition;
            var output = new MemoryStream();
            using (var inZip = new ZipArchive(input, ZipArchiveMode.Read, leaveOpen: false))
            using (var outZip = new ZipArchive(output, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (var entry in inZip.Entries)
                {
                    var outEntry = outZip.CreateEntry(entry.FullName, CompressionLevel.Fastest);
                    outEntry.LastWriteTime = entry.LastWriteTime;
                    using var inStream = entry.Open();
                    using var outStream = outEntry.Open();
                    if (entry.FullName == "[Content_Types].xml")
                    {
                        using var sw = new StreamWriter(outStream);
                        sw.Write(patched);
                    }
                    else
                    {
                        inStream.CopyTo(outStream);
                    }
                }
            }

            output.Position = 0;
            return output;
        }
        catch
        {
            input.Position = originalPosition;
            return input;
        }
    }
#else
    private static Stream RepairRelsContentType(Stream input) => input;
#endif

    protected override void Register(IFeatureCollection features)
    {
        base.Register(features);

        features.Set<IPackageStreamFeature>(this);
        features.GetRequired<IDisposableFeature>().Register(this);
    }
}
