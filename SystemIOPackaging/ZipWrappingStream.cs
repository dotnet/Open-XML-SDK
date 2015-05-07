using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO.Packaging
{
    internal class ZipWrappingStream : Stream
    {
        private Stream _baseStream;
        private bool _canRead;
        private bool _canWrite;

        public ZipWrappingStream(Stream stream, bool canRead, bool canWrite)
        {
            _baseStream = stream;
            _canRead = canRead;
            _canWrite = canWrite;
        }

        public override bool CanRead
        {
            get
            {
                if (_canRead == false)
                    return false;
                return _baseStream.CanRead;
            }
        }

        public override bool CanWrite
        {
            get
            {
                if (_canWrite == false)
                    return false;
                return _baseStream.CanWrite;
            }
        }

        public override void Write(
	        byte[] buffer,
	        int offset,
	        int count
        )
        {
            _baseStream.Write(buffer, offset, count);
        }

        public override int Read(
	        byte[] buffer,
	        int offset,
	        int count
        )
        {
            return _baseStream.Read(buffer, offset, count);
        }

        public override void SetLength(
	        long value
        )
        {
            _baseStream.SetLength(value);
        }

        public override long Seek(
	        long offset,
	        SeekOrigin origin
        )
        {
            return _baseStream.Seek(offset, origin);
        }

        public override void Flush()
        {
            _baseStream.Flush();
        }

        public override long Position
        {
            get
            {
                return _baseStream.Position;
            }
            set
            {
                _baseStream.Position = value;
            }
        }

        public override long Length
        {
            get { return _baseStream.Length; }
        }

        public override bool CanSeek
        {
            get { return _baseStream.CanSeek; }
        }

        // this wrapping stream will not close the underlying stream
        public override void Close()
        {
        }

        // this wrapping stream will not dispose of the underlying stream
        protected override void Dispose(bool disposing)
        {
        }
    }
}
