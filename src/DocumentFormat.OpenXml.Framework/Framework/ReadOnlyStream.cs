// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

#if !NET35 && !NET40
using System.Threading;
using System.Threading.Tasks;
#endif

namespace DocumentFormat.OpenXml.Framework;

internal sealed class ReadOnlyStream : DelegatingStream
{
    public ReadOnlyStream(Stream innerStream)
        : base(innerStream)
    {
    }

    public override bool CanWrite => false;

    public override void Flush()
    {
    }

#if !NET35 && !NET40
    public override Task FlushAsync(CancellationToken cancellationToken) => Task.CompletedTask;
#endif

    public override void SetLength(long value) => throw new NotSupportedException();

    public override void Write(byte[] buffer, int offset, int count)
        => throw new NotSupportedException();

#if NET6_0_OR_GREATER
    public override void Write(ReadOnlySpan<byte> buffer)
        => throw new NotSupportedException();
#endif

    public override void WriteByte(byte value)
        => throw new NotSupportedException();

#if !NET35 && !NET40
    public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        => throw new NotSupportedException();
#endif

#if NET6_0_OR_GREATER
    public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default)
        => throw new NotSupportedException();
#endif

    public override int WriteTimeout
    {
        get => throw new InvalidOperationException();
        set => throw new InvalidOperationException();
    }
}
