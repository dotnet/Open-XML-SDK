// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    internal static class PackageLoader
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False indicates read-only mode.</param>
        /// <exception cref="ArgumentNullException">Thrown when stream is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the specified stream is read-only and <paramref name="readWriteMode"/> is true. The package to open requires write or read/write permission.</exception>
        public static Package OpenCore(Stream stream, bool readWriteMode)
        {
            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            if (!stream.CanRead)
            {
                throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldRead);
            }

            if (readWriteMode && !stream.CanWrite)
            {
                throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldBeWrite);
            }

            var packageAccess = readWriteMode ? FileAccess.ReadWrite : FileAccess.Read;
            var packageMode = readWriteMode ? FileMode.OpenOrCreate : FileMode.Open;

            return Package.Open(stream, packageMode, packageAccess);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <exception cref="ArgumentNullException">Thrown when stream is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the specified stream is read-only. The package to open requires write or read/write permission.</exception>
        public static Package CreateCore(Stream stream)
        {
            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            if (!stream.CanWrite)
            {
                throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldBeWrite);
            }

            return Package.Open(stream, FileMode.Create, FileAccess.ReadWrite);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False for read only mode.</param>
        /// <exception cref="ArgumentNullException">Thrown when path is a null reference.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the supplied path cannot be found</exception>
        public static Package OpenCore(string path, bool readWriteMode)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException(ExceptionMessages.FileNotFound, path);
            }

            var packageMode = readWriteMode ? FileAccess.ReadWrite : FileAccess.Read;
            var packageAccess = readWriteMode ? FileMode.OpenOrCreate : FileMode.Open;
            var packageShare = readWriteMode ? FileShare.None : FileShare.Read;

            return Package.Open(path, packageAccess, packageMode, packageShare);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        /// <exception cref="ArgumentNullException">Thrown when path is a null reference.</exception>
        public static Package CreateCore(string path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            return Package.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
        }
    }
}
