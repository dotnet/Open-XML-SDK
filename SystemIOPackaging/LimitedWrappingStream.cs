using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO.Packaging
{
    internal class LimitedWrappingStream : Stream
    {
        private Stream _baseStream;
        private bool _canRead;
        private bool _canWrite;

        public LimitedWrappingStream(Stream stream, bool canRead, bool canWrite)
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

        public override void Close()
        {
            _baseStream.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _baseStream.Dispose();
        }

#if false
        public override IAsyncResult BeginRead(
	        byte[] buffer,
	        int offset,
	        int count,
	        AsyncCallback callback,
	        Object state
        )
        {
            return base.BeginRead(buffer, offset, count, callback, state);
        }
        
        public override IAsyncResult BeginWrite(
	        byte[] buffer,
	        int offset,
	        int count,
	        AsyncCallback callback,
	        Object state
        )
        {
            return base.BeginWrite(buffer, offset, count, callback, state);
        }

        public override void Close()
        {
            base.Close();
        }

        public void CopyTo(
	        Stream destination
        )
        {
            _baseStream.CopyTo(destination);
        }

        public void CopyTo(
	        Stream destination,
	        int bufferSize
        )
        {
            _baseStream.CopyTo(destination, bufferSize);
        }

        public Task CopyToAsync(
	        Stream destination
        )
        {
            return _baseStream.CopyToAsync(destination);
        }

        public Task CopyToAsync(
	        Stream destination,
	        int bufferSize
        )
        {
            return _baseStream.CopyToAsync(destination, bufferSize);
        }
#endif

    }
}
