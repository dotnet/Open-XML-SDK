// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.IO;

#if !NET35 && !NET40
using System.Threading;
using System.Threading.Tasks;
#endif

namespace DocumentFormat.OpenXml.Framework;

internal abstract class DelegatingStream : Stream
{
    private readonly Stream _innerStream;

    #region Properties

    public override bool CanRead
    {
        get { return _innerStream.CanRead; }
    }

    public override bool CanSeek
    {
        get { return _innerStream.CanSeek; }
    }

    public override bool CanWrite
    {
        get { return _innerStream.CanWrite; }
    }

    public override long Length
    {
        get { return _innerStream.Length; }
    }

    public override long Position
    {
        get { return _innerStream.Position; }
        set { _innerStream.Position = value; }
    }

    public override int ReadTimeout
    {
        get { return _innerStream.ReadTimeout; }
        set { _innerStream.ReadTimeout = value; }
    }

    public override bool CanTimeout
    {
        get { return _innerStream.CanTimeout; }
    }

    public override int WriteTimeout
    {
        get { return _innerStream.WriteTimeout; }
        set { _innerStream.WriteTimeout = value; }
    }

    #endregion Properties

    protected DelegatingStream(Stream innerStream)
    {
        Debug.Assert(innerStream != null);
        _innerStream = innerStream!;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _innerStream.Dispose();
        }

        base.Dispose(disposing);
    }

#if NET6_0_OR_GREATER
    public override async ValueTask DisposeAsync()
    {
        await base.DisposeAsync().ConfigureAwait(false);
        await _innerStream.DisposeAsync().ConfigureAwait(false);
    }
#endif

    #region Read

    public override long Seek(long offset, SeekOrigin origin)
    {
        return _innerStream.Seek(offset, origin);
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        return _innerStream.Read(buffer, offset, count);
    }

#if NET6_0_OR_GREATER
    public override int Read(Span<byte> buffer)
    {
        return _innerStream.Read(buffer);
    }
#endif

    public override int ReadByte()
    {
        return _innerStream.ReadByte();
    }

#if !NET35 && !NET40
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        return _innerStream.ReadAsync(buffer, offset, count, cancellationToken);
    }
#endif

#if NET6_0_OR_GREATER
    public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
    {
        return _innerStream.ReadAsync(buffer, cancellationToken);
    }
#endif

#if NET6_0_OR_GREATER
    public override void CopyTo(Stream destination, int bufferSize)
    {
        _innerStream.CopyTo(destination, bufferSize);
    }
#endif

#if !NET35 && !NET40
    public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
    {
        return _innerStream.CopyToAsync(destination, bufferSize, cancellationToken);
    }
#endif

    #endregion Read

    #region Write

    public override void Flush()
    {
        _innerStream.Flush();
    }

#if !NET35 && !NET40
    public override Task FlushAsync(CancellationToken cancellationToken)
    {
        return _innerStream.FlushAsync(cancellationToken);
    }
#endif

    public override void SetLength(long value)
    {
        _innerStream.SetLength(value);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        _innerStream.Write(buffer, offset, count);
    }

#if NET6_0_OR_GREATER
    public override void Write(ReadOnlySpan<byte> buffer)
    {
        _innerStream.Write(buffer);
    }
#endif

    public override void WriteByte(byte value)
    {
        _innerStream.WriteByte(value);
    }

#if !NET35 && !NET40
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        return _innerStream.WriteAsync(buffer, offset, count, cancellationToken);
    }
#endif

#if NET6_0_OR_GREATER
    public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default)
    {
        return _innerStream.WriteAsync(buffer, cancellationToken);
    }
#endif

#if !NETSTANDARD1_3
    public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback? callback, object? state)
    {
        return _innerStream.BeginWrite(buffer, offset, count, callback, state);
    }

    public override void EndWrite(IAsyncResult asyncResult)
    {
        _innerStream.EndWrite(asyncResult);
    }
#endif

    #endregion Write
}
