using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO.Packaging
{
    internal class ZipStreamManager : IDisposable
    {
        private ZipArchive _zipArchive;
        private Dictionary<string, Stream> _streamCache;
        private bool _disposed = false;

        public ZipStreamManager(ZipArchive zipArchive)
        {
            _zipArchive = zipArchive;
            _streamCache = new Dictionary<string,Stream>();
        }

        public Stream Open(ZipArchiveEntry zipArchiveEntry, FileMode fileMode, FileAccess packageFileAccess, FileAccess streamFileAccess)
        {
            // todo need to figure out canRead, canWrite from fileMode, fileAccess
            bool canRead = true;
            bool canWrite = true;
            switch (packageFileAccess)
            {
                case FileAccess.Read:
                    switch (streamFileAccess)
                    {
                        case FileAccess.Read:
                            canRead = true;
                            canWrite = false;
                            break;
                        case FileAccess.Write:
                            canRead = false;
                            canWrite = false;
                            break;
                        case FileAccess.ReadWrite:
                            canRead = true;
                            canWrite = false;
                            break;
                    }
                    break;
                case FileAccess.Write:
                    switch (streamFileAccess)
                    {
                        case FileAccess.Read:
                            canRead = false;
                            canWrite = false;
                            break;
                        case FileAccess.Write:
                            canRead = false;
                            canWrite = true;
                            break;
                        case FileAccess.ReadWrite:
                            canRead = false;
                            canWrite = true;
                            break;
                    }
                    break;
                case FileAccess.ReadWrite:
                    switch (streamFileAccess)
                    {
                        case FileAccess.Read:
                            canRead = true;
                            canWrite = false;
                            break;
                        case FileAccess.Write:
                            canRead = false;
                            canWrite = true;
                            break;
                        case FileAccess.ReadWrite:
                            canRead = true;
                            canWrite = true;
                            break;
                    }
                    break;
            }

            if (_streamCache.ContainsKey(zipArchiveEntry.FullName))
            {
                Stream s = _streamCache[zipArchiveEntry.FullName];
                if (fileMode == FileMode.Create)
                {
                    s.SetLength(0);
                }
                s.Seek(0, SeekOrigin.Begin);
                return new ZipWrappingStream(s, canRead, canWrite);
            }
            else
            { 
                Stream ns = zipArchiveEntry.Open();
                _streamCache.Add(zipArchiveEntry.FullName, ns);
                return new ZipWrappingStream(ns, canRead, canWrite);
            }
        }

        public void Close(ZipArchiveEntry zipArchiveEntry)
        {
            if (_streamCache.ContainsKey(zipArchiveEntry.FullName))
            {
                Stream s = _streamCache[zipArchiveEntry.FullName];
                s.Close();
                s.Dispose();
                _streamCache.Remove(zipArchiveEntry.FullName);
            }
        }

        //
        // IDisposable interface
        //
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern. 
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                foreach (var s in _streamCache)
                {
                    try
                    {
                        s.Value.Close();
                        s.Value.Dispose();
                    }
                    catch (ObjectDisposedException)
                    {
                        continue;
                    }
                }
            }

            _disposed = true;
        }
    }
}
