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
    #region Properties

    public override bool CanRead
    {
        get { return InnerStream.CanRead; }
    }

    public override bool CanSeek
    {
        get { return InnerStream.CanSeek; }
    }

    public override bool CanWrite
    {
        get { return InnerStream.CanWrite; }
    }

    public override long Length
    {
        get { return InnerStream.Length; }
    }

    public override long Position
    {
        get { return InnerStream.Position; }
        set { InnerStream.Position = value; }
    }

    public override int ReadTimeout
    {
        get { return InnerStream.ReadTimeout; }
        set { InnerStream.ReadTimeout = value; }
    }

    public override bool CanTimeout
    {
        get { return InnerStream.CanTimeout; }
    }

    public override int WriteTimeout
    {
        get { return InnerStream.WriteTimeout; }
        set { InnerStream.WriteTimeout = value; }
    }

    #endregion Properties

    protected DelegatingStream(Stream innerStream)
    {
        Debug.Assert(innerStream != null);
        InnerStream = innerStream!;
    }

    public Stream InnerStream { get; }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            InnerStream.Dispose();
        }

        base.Dispose(disposing);
    }

#if NET6_0_OR_GREATER
    public override ValueTask DisposeAsync()
    {
        return _innerStream.DisposeAsync();
    }
#endif

    #region Read

    public override long Seek(long offset, SeekOrigin origin)
    {
        return InnerStream.Seek(offset, origin);
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        return InnerStream.Read(buffer, offset, count);
    }

#if NET6_0_OR_GREATER
    public override int Read(Span<byte> buffer)
    {
        return _innerStream.Read(buffer);
    }
#endif

    public override int ReadByte()
    {
        return InnerStream.ReadByte();
    }

#if !NET35 && !NET40
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        return InnerStream.ReadAsync(buffer, offset, count, cancellationToken);
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
        return InnerStream.CopyToAsync(destination, bufferSize, cancellationToken);
    }
#endif

    #endregion Read

    #region Write

    public override void Flush()
    {
        InnerStream.Flush();
    }

#if !NET35 && !NET40
    public override Task FlushAsync(CancellationToken cancellationToken)
    {
        return InnerStream.FlushAsync(cancellationToken);
    }
#endif

    public override void SetLength(long value)
    {
        InnerStream.SetLength(value);
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        InnerStream.Write(buffer, offset, count);
    }

#if NET6_0_OR_GREATER
    public override void Write(ReadOnlySpan<byte> buffer)
    {
        _innerStream.Write(buffer);
    }
#endif

    public override void WriteByte(byte value)
    {
        InnerStream.WriteByte(value);
    }

#if !NET35 && !NET40
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        return InnerStream.WriteAsync(buffer, offset, count, cancellationToken);
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
        return InnerStream.BeginWrite(buffer, offset, count, callback, state);
    }

    public override void EndWrite(IAsyncResult asyncResult)
    {
        InnerStream.EndWrite(asyncResult);
    }
#endif

    #endregion Write
}
