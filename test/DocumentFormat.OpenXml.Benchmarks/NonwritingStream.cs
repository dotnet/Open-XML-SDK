// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace DocumentFormat.OpenXml.Benchmarks
{
    /// <summary>
    /// An implementation of stream that can be used for writing that will not allocate and will cause minimal performance
    /// effects. This stream does not store anything and will therefore fail if an operation needing to read is required;
    /// however, it will report that it can read, but will throw when attempted.
    /// </summary>
    internal class NonwritingStream : Stream
    {
        private long _length;

        public override bool CanRead => true;

        public override bool CanSeek => true;

        public override bool CanWrite => true;

        public override long Length => _length;

        public override long Position { get; set; }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin:
                    Position = offset;
                    break;
                case SeekOrigin.Current:
                    Position += offset;
                    break;
                case SeekOrigin.End:
                    throw new NotImplementedException();
            }

            return Position;
        }

        public override void SetLength(long value)
        {
            _length = value;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _length += count;
            Position += count;
        }
    }
}
