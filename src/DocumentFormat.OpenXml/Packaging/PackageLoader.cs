// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    internal readonly struct PackageLoader
    {
        public PackageLoader(Package package, bool isOpen = false)
        {
            Package = package;
            IsOpen = isOpen;
        }

        public Package Package { get; }

        public bool IsOpen { get; }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied Open XML package.
        /// </summary>
        /// <param name="package">The target package for the OpenXmlPackage class.</param>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when package is not opened with read access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        public static PackageLoader OpenCore(Package package)
        {
            if (package is null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            if (package.FileOpenAccess == FileAccess.Write)
            {
                throw new OpenXmlPackageException(ExceptionMessages.PackageMustCanBeRead);
            }

            return new PackageLoader(package, isOpen: true);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class with access to a specified Open XML package.
        /// </summary>
        /// <param name="package">The target package for the OpenXmlPackage class.</param>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        public static PackageLoader CreateCore(Package package)
             => new PackageLoader(package ?? throw new ArgumentNullException(nameof(package)));

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False indicates read-only mode.</param>
        /// <exception cref="ArgumentNullException">Thrown when stream is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the specified stream is read-only and <paramref name="readWriteMode"/> is true. The package to open requires write or read/write permission.</exception>
        public static PackageLoader OpenCore(Stream stream, bool readWriteMode)
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

            return new PackageLoader(Package.Open(stream, packageMode, packageAccess), isOpen: true);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <exception cref="ArgumentNullException">Thrown when stream is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the specified stream is read-only. The package to open requires write or read/write permission.</exception>
        public static PackageLoader CreateCore(Stream stream)
        {
            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            if (!stream.CanWrite)
            {
                throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldBeWrite);
            }

            return new PackageLoader(Package.Open(stream, FileMode.Create, FileAccess.ReadWrite));
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False for read only mode.</param>
        /// <exception cref="ArgumentNullException">Thrown when path is a null reference.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the supplied path cannot be found</exception>
        public static PackageLoader OpenCore(string path, bool readWriteMode)
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

            return new PackageLoader(Package.Open(path, packageAccess, packageMode, packageShare), isOpen: true);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        /// <exception cref="ArgumentNullException">Thrown when path is a null reference.</exception>
        public static PackageLoader CreateCore(string path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            return new PackageLoader(Package.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None));
        }
    }
}
