﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents the type of part referenced by a <see cref="DataPartReferenceRelationship"/>.
    /// </summary>
    public class DataPart
    {
        #region private data members
        private const string DefaultTargetPart = "data";
        private const string DefaultTargetName = "data";
        private const string DefaultTargetExt = ".bin";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IPackagePart _metroPart;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Uri _uri;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenXmlPackage? _openXmlPackage;

        #endregion

        /// <summary>
        /// Gets the OpenXmlPackage which contains the current part.
        /// </summary>
        public OpenXmlPackage OpenXmlPackage
        {
            get
            {
                ThrowIfObjectDisposed();
                return _openXmlPackage;
            }
        }

        /// <summary>
        /// Gets the internal part path in the package.
        /// </summary>
        public Uri Uri
        {
            get
            {
                ThrowIfObjectDisposed();

                Debug.Assert(_uri.OriginalString.Equals(_metroPart.Uri.OriginalString, StringComparison.OrdinalIgnoreCase));

                return _uri;
            }
        }

        #region public methods

        /// <summary>
        /// Enumerates all <see cref="DataPartReferenceRelationship" />s that reference the current data part.
        /// </summary>
        public IEnumerable<DataPartReferenceRelationship> GetDataPartReferenceRelationships()
        {
            ThrowIfObjectDisposed();

            // First, see if there are any reference in package level.
            foreach (var dataPartReferenceRelationship in OpenXmlPackage.DataPartReferenceRelationships)
            {
                if (dataPartReferenceRelationship.DataPart == this)
                {
                    yield return dataPartReferenceRelationship;
                }
            }

            // For each part in the package, check the DataPartReferenceRelationships.
            foreach (var openXmlPart in OpenXmlPackage.GetAllParts())
            {
                foreach (var dataPartReferenceRelationship in openXmlPart.DataPartReferenceRelationships)
                {
                    if (dataPartReferenceRelationship.DataPart == this)
                    {
                        yield return dataPartReferenceRelationship;
                    }
                }
            }
        }

        /// <summary>
        /// Returns the content data stream of the current part.
        /// </summary>
        /// <returns>The content data stream of the current part. </returns>
        public Stream GetStream()
        {
            ThrowIfObjectDisposed();

            return PackagePart.GetStream();
        }

        /// <summary>
        /// Returns the content stream that was opened using a specified I/O FileMode.
        /// </summary>
        /// <param name="mode">The I/O mode to be used to open the content stream.</param>
        /// <returns>The content stream of the part. </returns>
        public Stream GetStream(FileMode mode)
        {
            ThrowIfObjectDisposed();

            return PackagePart.GetStream(mode);
        }

        /// <summary>
        /// Returns the content stream of the part that was opened by using a specified FileMode and FileAccess.
        /// </summary>
        /// <param name="mode">The I/O mode to be used to open the content stream.</param>
        /// <param name="access">The access permissions to be used to open the content stream.</param>
        /// <returns>The content stream of the part. </returns>
        public Stream GetStream(FileMode mode, FileAccess access)
        {
            ThrowIfObjectDisposed();

            return PackagePart.GetStream(mode, access);
        }

        /// <summary>
        /// Feeds data into the part stream.
        /// The stream of the part will be truncated at first.
        /// </summary>
        /// <param name="sourceStream">The source stream to be read from.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="sourceStream"/> is a null reference.</exception>
        public void FeedData(Stream sourceStream)
        {
            ThrowIfObjectDisposed();

            if (sourceStream is null)
            {
                throw new ArgumentNullException(nameof(sourceStream));
            }

            using (Stream targetStream = GetStream(FileMode.Create))
            {
                sourceStream.CopyTo(targetStream);
            }
        }

        #endregion

        #region public virtual methods / properties

        /// <summary>
        /// Gets the content type (MIME type) of the data in the part.
        /// </summary>
        public virtual string ContentType
        {
            get
            {
                ThrowIfObjectDisposed();
                return PackagePart.ContentType;
            }
        }

        #endregion

        #region internal properties

        /// <summary>
        /// Gets the internal metro PackagePart.
        /// </summary>
        internal IPackagePart PackagePart
        {
            get
            {
                ThrowIfObjectDisposed();
                return _metroPart;
            }
        }

        /// <summary>
        /// Gets the internal path to be used for the part name.
        /// </summary>
        internal virtual string TargetPath => DefaultTargetPart;

        /// <summary>
        /// Gets the file base name to be used for the part name in the package.
        /// </summary>
        internal virtual string TargetName => DefaultTargetName;

        /// <summary>
        /// Gets the file extension to be used for the part in the package.
        /// </summary>
        internal virtual string TargetFileExtension => DefaultTargetExt;

        private protected DataPart(OpenXmlPackage openXmlPackage, IPackagePart packagePart)
        {
            Debug.Assert(openXmlPackage.Package.GetPart(packagePart.Uri) == packagePart);

            _openXmlPackage = openXmlPackage;
            _metroPart = packagePart;
            _uri = packagePart.Uri;

            if (_metroPart.Relationships.Any())
            {
                // Media (Audio, Video) parts should not reference any other parts.
                throw new OpenXmlPackageException(ExceptionMessages.MediaDataPartShouldNotReferenceOtherParts);
            }
        }

        // create a new part in this package
        private protected DataPart(OpenXmlPackage openXmlPackage, string contentType, string? extension)
        {
            _openXmlPackage = openXmlPackage;
            _uri = NewPartUri(openXmlPackage, contentType, extension);
            _metroPart = _openXmlPackage.CreateMetroPart(_uri, contentType);
        }

        // create a new part in this package
        private protected DataPart(OpenXmlPackage openXmlPackage, MediaDataPartType mediaDataPartType)
        {
            _openXmlPackage = openXmlPackage;

            string contentType = mediaDataPartType.GetContentType();
            string targetFileExt = mediaDataPartType.GetTargetExtension();
            OpenXmlPackage.PartExtensions.Register(contentType, targetFileExt);

            _uri = NewPartUri(openXmlPackage, contentType, null);
            _metroPart = _openXmlPackage.CreateMetroPart(_uri, contentType);
        }

        // create a new part in this package
        private protected DataPart(OpenXmlPackage openXmlPackage, string contentType, Uri partUri)
        {
            // openXmlPackage, parent can not be all null
            if (openXmlPackage is null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }

            // throw exception to catch error in our code
            if (_metroPart is not null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            _openXmlPackage = openXmlPackage;

            Uri parentUri = new Uri("/", UriKind.Relative);

            _uri = _openXmlPackage.Features.GetRequired<IPartUriFeature>().EnsureUniquePartUri(contentType, parentUri, partUri);

            _metroPart = _openXmlPackage.CreateMetroPart(_uri, contentType);
        }

        private Uri NewPartUri(OpenXmlPackage openXmlPackage, string contentType, string? extension)
        {
            string? targetFileExt;

            if (extension is null)
            {
                if (!openXmlPackage.PartExtensions.TryGetExtension(contentType, out targetFileExt))
                {
                    targetFileExt = TargetFileExtension;
                }
            }
            else
            {
                targetFileExt = extension;
            }

            return openXmlPackage.Features.GetRequired<IPartUriFeature>().CreatePartUri(contentType, new Uri("/", UriKind.Relative), TargetPath, TargetName, targetFileExt);
        }

        // destroy itself (aka. dispose)
        internal void Destroy()
        {
            OpenXmlPackage.Package.DeletePart(Uri);

            _openXmlPackage = null;
        }

        #endregion

        #region protected methods

        /// <summary>
        /// Indicates whether the object is destroyed (deleted from the package).
        /// </summary>
        [MemberNotNull(nameof(_openXmlPackage))]
        protected void ThrowIfObjectDisposed()
        {
            if (_openXmlPackage is null)
            {
                throw new InvalidOperationException(ExceptionMessages.PartIsDestroyed);
            }
        }

        #endregion
    }
}
