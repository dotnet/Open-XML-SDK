// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;

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
        private OpenXmlPackage _openXmlPackage;
        
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PackagePart _metroPart;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Uri _uri;

        #endregion

        /// <summary>
        /// Initializes a new instance of the DataPart class. 
        /// </summary>
        internal DataPart()
        {
        }

        #region public properties

        /// <summary>
        /// Gets the OpenXmlPackage which contains the current part.
        /// </summary>
        public OpenXmlPackage OpenXmlPackage
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._openXmlPackage;
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

                Debug.Assert(this._uri.OriginalString.Equals(this._metroPart.Uri.OriginalString, StringComparison.OrdinalIgnoreCase));

                return this._uri;
            }
        }

        #endregion

        #region public methods
                
        /// <summary>
        /// Enumerates all <see cref="DataPartReferenceRelationship" />s that reference the current data part.
        /// </summary>
        public IEnumerable<DataPartReferenceRelationship> GetDataPartReferenceRelationships()
        {
            ThrowIfObjectDisposed();

            // first, see if there are any reference in package leve.
            foreach (var dataPartReferenceRelationship in this.OpenXmlPackage.DataPartReferenceRelationships)
            {
                if (dataPartReferenceRelationship.DataPart == this)
                {
                    yield return dataPartReferenceRelationship;
                }
            }

            // for each part in the package, check the DataPartReferenceRelationships.
            OpenXmlPackagePartIterator partIterator = new OpenXmlPackagePartIterator(this.OpenXmlPackage);
            foreach (var openXmlPart in partIterator)
            {
                foreach (var dataPartReferenceRelationship in openXmlPart.DataPartReferenceRelationships)
                {
                    if (dataPartReferenceRelationship.DataPart == this)
                    {
                        yield return dataPartReferenceRelationship;
                    }
                }
            }

            yield break;
        }

        /// <summary>
        /// Returns the content data stream of the current part. 
        /// </summary>
        /// <returns>The content data stream of the current part. </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public Stream GetStream()
        {
            ThrowIfObjectDisposed();

            return this.PackagePart.GetStream();
        }


        /// <summary>
        /// Returns the content stream that was opened using a specified I/O FileMode. 
        /// </summary>
        /// <param name="mode">The I/O mode to be used to open the content stream.</param>
        /// <returns>The content stream of the part. </returns>
        public Stream GetStream(FileMode mode)
        {
            ThrowIfObjectDisposed();

            return this.PackagePart.GetStream(mode);
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

            return this.PackagePart.GetStream(mode, access);
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

            if (sourceStream == null)
            {
                throw new ArgumentNullException("sourceStream");
            }

            using (Stream targetStream = this.GetStream(FileMode.Create))
            {
                OpenXmlPart.CopyStream(sourceStream, targetStream);
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
                return this.PackagePart.ContentType;
            }
        }

        #endregion

        #region internal properties

        /// <summary>
        /// Gets the internal metro PackagePart.
        /// </summary>
        internal PackagePart PackagePart
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._metroPart;
            }
        }

        /// <summary>
        /// The internal path to be used for the part name.
        /// </summary>
        internal virtual string TargetPath
        {
            get { return DefaultTargetPart; } 
        }

        /// <summary>
        /// The file base name to be used for the part name in the package.
        /// </summary>
        internal virtual string TargetName
        {
            get { return DefaultTargetName; }
        }


        /// <summary>
        /// The file extension to be used for the part in the package.
        /// </summary>
        internal virtual string TargetFileExtension
        {
            get { return DefaultTargetExt; }
        }

        internal void Load(OpenXmlPackage openXmlPackage, PackagePart packagePart)
        {
            Debug.Assert(openXmlPackage.Package.GetPart(packagePart.Uri) == packagePart);

            this._openXmlPackage = openXmlPackage;
            this._metroPart = packagePart;
            this._uri = packagePart.Uri;

            if (this._metroPart.GetRelationships().Any())
            {
                // Media (Audio, Video) parts should not reference any other parts.
                throw new OpenXmlPackageException(ExceptionMessages.MediaDataPartShouldNotReferenceOtherParts);
            }
        }

        // create a new part in this package
        internal void CreateInternal(OpenXmlPackage openXmlPackage, string contentType, string extension)
        {
            this._openXmlPackage = openXmlPackage;
            this._uri = NewPartUri(openXmlPackage, contentType, extension);
            this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
        }

        // create a new part in this package
        internal void CreateInternal(OpenXmlPackage openXmlPackage, MediaDataPartType mediaDataPartType)
        {
            this._openXmlPackage = openXmlPackage;

            string contentType = mediaDataPartType.GetContentType();
            string targetFileExt = mediaDataPartType.GetTargetExtension();
            OpenXmlPackage.PartExtensionProvider.MakeSurePartExtensionExist(contentType, targetFileExt);

            this._uri = NewPartUri(openXmlPackage, contentType, null);
            this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
        }

        // create a new part in this package
        internal void CreateInternal2(OpenXmlPackage openXmlPackage, string contentType, Uri partUri)
        {
            // openXmlPackage, parent can not be all null
            if (openXmlPackage == null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }

            // throw exception to catch error in our code
            if (this._metroPart != null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            this._openXmlPackage = openXmlPackage;

            Uri parentUri = new Uri("/", UriKind.Relative);

            this._uri = this._openXmlPackage.GetUniquePartUri(contentType, parentUri, partUri);

            this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);

        }

        internal Uri NewPartUri(OpenXmlPackage openXmlPackage, string contentType, string extension)
        {
            string targetFileExt;

            if (extension == null)
            {
                if (!this._openXmlPackage.PartExtensionProvider.TryGetValue(contentType, out targetFileExt))
                {
                    targetFileExt = this.TargetFileExtension;
                }
            }
            else
            {
                targetFileExt = extension;
            }

            return openXmlPackage.GetUniquePartUri(contentType, new Uri("/", UriKind.Relative), this.TargetPath, this.TargetName, targetFileExt);
        }

        // destroy itself (aka. dispose)
        internal void Destroy()
        {
            this.OpenXmlPackage.Package.DeletePart(this.Uri);

            this._openXmlPackage = null;
        }

        #endregion

        #region protected methods

        /// <summary>
        /// Indicates whether the object is destroyed (deleted from the package).
        /// </summary>
        protected void ThrowIfObjectDisposed()
        {
            if (this._openXmlPackage == null)
            {
                throw new InvalidOperationException(ExceptionMessages.PartIsDestroyed);
            }
        }

        #endregion
    }

    /// <summary>
    /// Represents a media (Audio, Video) data part in the document.
    /// </summary>
    public class MediaDataPart : DataPart
    {
        private const string DefaultTargetPart = "media";
        private const string DefaultTargetName = "mediadata";
        private const string DefaultTargetExt = ".bin";

        /// <summary>
        /// Initializes a new instance of the MediaDataPart class. 
        /// </summary>
        internal MediaDataPart()
            : base()
        {
        }

        /// <summary>
        /// The internal path to be used for the part name.
        /// </summary>
        internal override string TargetPath
        {
            get { return DefaultTargetPart; }
        }

        /// <summary>
        /// The file base name to be used for the part name in the package
        /// </summary>
        internal override string TargetName
        {
            get { return DefaultTargetName; }
        }


        /// <summary>
        /// The file extension to be used for the part in the package.
        /// </summary>
        internal override string TargetFileExtension
        {
            get { return DefaultTargetExt; }
        }
    }

    /// <summary>
    /// Defines part media types.
    /// </summary>
    public enum MediaDataPartType
    {
        #region Audio Types

        /// <summary>
        /// Audio Interchange File Format (.aiff)
        /// </summary>
        Aiff,
        ///// <summary>
        ///// AU Audio File (.au)
        ///// </summary>
        //Basic, 
        /// <summary>
        /// MIDI Audio (.mid)
        /// </summary>
        Midi,
        /// <summary>
        /// MP3 (.mp3)
        /// </summary>
        Mp3,
        /// <summary>
        /// MP3 Playlist File (.m3u)
        /// </summary>
        MpegUrl,
        /// <summary>
        /// WAV audio (.wav)
        /// </summary>
        Wav,
        ///// <summary>
        ///// Windows Media Audio Redirector (.wax)
        ///// </summary>
        //Wax,
        /// <summary>
        /// Windows Media Audio File (.wma)
        /// </summary>
        Wma,
        /// <summary>
        /// Mpeg audio (.mpeg)
        /// </summary>
        MpegAudio,
        /// <summary>
        /// Ogg Vorbis (.ogg)
        /// </summary>
        OggAudio,

        #endregion

        #region Video Types

        ///// <summary>
        ///// Advanced Streaming Format (.asf)
        ///// </summary>
        //Asf,
        /// <summary>
        /// Advanced Stream Redirector File (.asx)
        /// </summary>
        Asx,
        /// <summary>
        /// Audio Video Interleave File (.avi)
        /// </summary>
        Avi,
        ///// <summary>
        ///// Indeo Video File (.ivf)
        ///// </summary>
        //Ivf,
        /// <summary>
        /// MPEG 1 System Stream (.mpg)
        /// </summary>
        Mpg,
        /// <summary>
        /// MPEG 1 System Stream (.mpeg)
        /// </summary>
        MpegVideo,
        ///// <summary>
        ///// Windows Media A/V File (.wm)
        ///// </summary>
        //WM,
        /// <summary>
        /// Windows Media File (.wmv)
        /// </summary>
        Wmv,
        /// <summary>
        /// Windows Media Player A/V Shortcut (.wmx)
        /// </summary>
        Wmx,
        /// <summary>
        /// Windows Media Redirector (.wvx)
        /// </summary>
        Wvx,
        /// <summary>
        /// QuickTime video (.mov)
        /// </summary>
        Quicktime,
        /// <summary>
        ///  Ogg Stream (.ogg)
        /// </summary>
        OggVideo,
        /// <summary>
        /// VC-1 Stream (.wmv)
        /// </summary>
        VC1

        #endregion
    }

    internal static class MediaDataPartTypeInfo
    {
        internal static string GetContentType(this MediaDataPartType mediaDataPartType)
        {
            switch (mediaDataPartType)
            {
                case MediaDataPartType.Aiff:
                    return "audio/aiff";

                //case MediaDataPartType.Basic:
                //    return "audio/basic";

                case MediaDataPartType.Midi:
                    return "audio/midi";

                case MediaDataPartType.Mp3:
                    return "audio/mp3";

                case MediaDataPartType.MpegUrl:
                    return "audio/mpegurl";

                case MediaDataPartType.Wav:
                    return "audio/wav";

                //case MediaDataPartType.Wax:
                //    return "audio/x-ms-wax";

                case MediaDataPartType.Wma:
                    return "audio/x-ms-wma";

                case MediaDataPartType.MpegAudio:
                    return "audio/mpeg";

                case MediaDataPartType.OggAudio:
                    return "audio/ogg";

                // *** Video types.

                //case MediaDataPartType.Asf:
                //    return "video/x-ms-asf";

                case MediaDataPartType.Asx:
                    return "video/x-ms-asf-plugin";

                case MediaDataPartType.Avi:
                    return "video/avi";

                //case MediaDataPartType.Ivf:
                //    return "video/x-ivf";

                case MediaDataPartType.Mpg:
                    return "video/mpg";

                case MediaDataPartType.MpegVideo:
                    return "video/mpeg";

                //case MediaDataPartType.WM:
                //    return "video/x-ms-wm";

                case MediaDataPartType.Wmv:
                    return "video/x-ms-wmv";

                case MediaDataPartType.Wmx:
                    return "video/x-ms-wmx";

                case MediaDataPartType.Wvx:
                    return "video/x-ms-wvx";

                case MediaDataPartType.Quicktime:
                    return "video/quicktime";

                case MediaDataPartType.OggVideo:
                    return "video/ogg";

                case MediaDataPartType.VC1:
                    return "video/vc1";

                default:
                    throw new ArgumentOutOfRangeException("mediaDataPartType");
            }
        }

        internal static string GetTargetExtension(this MediaDataPartType mediaDataPartType)
        {
            switch (mediaDataPartType)
            {
                case MediaDataPartType.Aiff:
                    return ".aiff";

                //case MediaDataPartType.Basic:
                //    return ".au";

                case MediaDataPartType.Midi:
                    return ".midi";

                case MediaDataPartType.Mp3:
                    return ".mp3";

                case MediaDataPartType.MpegUrl:
                    return ".m3u";

                case MediaDataPartType.Wav:
                    return ".wav";

                //case MediaDataPartType.Wax:
                //    return ".wax";

                case MediaDataPartType.Wma:
                    return ".wma";

                case MediaDataPartType.MpegAudio:
                    return ".mpeg";

                case MediaDataPartType.OggAudio:
                    return ".ogg";

                // Video types.

                //case MediaDataPartType.Asf:
                //    return ".asf";

                case MediaDataPartType.Asx:
                    return ".asx";

                case MediaDataPartType.Avi:
                    return ".avi";

                //case MediaDataPartType.Ivf:
                //    return ".ivf";

                case MediaDataPartType.Mpg:
                    return ".mpg";

                case MediaDataPartType.MpegVideo:
                    return ".mpeg";

                //case MediaDataPartType.WM:
                //    return ".wm";

                case MediaDataPartType.Wmv:
                    return ".wmv";

                case MediaDataPartType.Wmx:
                    return ".wmx";

                case MediaDataPartType.Wvx:
                    return ".wvx";

                case MediaDataPartType.Quicktime:
                    return ".mov";

                case MediaDataPartType.OggVideo:
                    return ".ogg";

                case MediaDataPartType.VC1:
                    return ".wmv";
                
                default:
                    return ".media";
            }
        }
    }

}
