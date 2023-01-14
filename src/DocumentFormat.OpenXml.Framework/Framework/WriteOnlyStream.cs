// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

#if !NET35 && !NET40
using System.Threading;
using System.Threading.Tasks;
#endif

namespace DocumentFormat.OpenXml.Framework;

internal sealed class WriteOnlyStream : DelegatingStream
{
    public WriteOnlyStream(Stream innerStream)
        : base(innerStream)
    {
    }

    public override bool CanRead => false;

    public override int Read(byte[] buffer, int offset, int count)
        => throw new NotSupportedException();

#if NET6_0_OR_GREATER
    public override int Read(Span<byte> buffer)
        => throw new NotSupportedException();
#endif

#if !NET35 && !NET40
    public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        => throw new NotSupportedException();
#endif

#if NET6_0_OR_GREATER
    public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
        => throw new NotSupportedException();
#endif

    public override int ReadByte()
        => throw new NotSupportedException();

    public override int ReadTimeout
    {
        get => throw new InvalidOperationException();
        set => throw new InvalidOperationException();
    }

#if !NETSTANDARD1_3
    public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback? callback, object? state)
        => throw new NotSupportedException();

    public override int EndRead(IAsyncResult asyncResult)
        => throw new NotSupportedException();
#endif
}
