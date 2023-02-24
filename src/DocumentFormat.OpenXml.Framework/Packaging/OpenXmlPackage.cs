// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents a base class for strong typed Open XML document classes.
    /// </summary>
    public abstract partial class OpenXmlPackage : OpenXmlPartContainer, IDisposable
    {
        internal static Uri Uri { get; } = new Uri("/", UriKind.Relative);

        private bool _isDisposed;
        private OpenSettings? _settings;

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class.
        /// </summary>
        protected OpenXmlPackage()
            : base()
        {
        }

        /// <summary>
        /// Gets the root part for the package.
        /// </summary>
        public virtual OpenXmlPart? RootPart => Features.GetRequired<IMainPartFeature>().Part;

        internal OpenSettings OpenSettings
        {
            get => _settings ??= new();
            set => _settings = value;
        }

        /// <summary>
        /// Gets a value indicating whether this package contains Transitional relationships converted from Strict.
        /// </summary>
        public bool StrictRelationshipFound => Features.Get<IStrictNamespaceFeature>()?.Found ?? false;

        internal IPackage Package => Features.GetRequired<IPackageFeature>().Package;

        /// <summary>
        /// Gets the FileAccess setting for the document.
        /// The current I/O access settings are: Read, Write, or ReadWrite.
        /// </summary>
        public FileAccess FileOpenAccess => Package.FileOpenAccess;

        /// <summary>
        /// Gets the core package properties of the Open XML document.
        /// </summary>
        public PackageProperties PackageProperties => Package.PackageProperties;

        /// <summary>
        /// Gets or sets the compression level for the content of the new part
        /// </summary>
        public CompressionOption CompressionOption { get; set; } = CompressionOption.Normal;

        /// <summary>
        /// Gets a <see cref="IPartExtensionFeature"/> part which provides a mapping from content type to part extension.
        /// </summary>
        internal IPartExtensionFeature PartExtensions => Features.GetRequired<IPartExtensionFeature>();

        /// <summary>
        /// Gets a value that indicates the maximum allowable number of characters in an Open XML part. A zero (0) value indicates that there are no limits on the size
        /// of the part. A non-zero value specifies the maximum size, in characters.
        /// </summary>
        /// <remarks>
        /// This property allows you to mitigate denial of service attacks where the attacker submits a package with an extremely large Open XML part. By limiting the size of a
        /// part, you can detect the attack and recover reliably.
        /// </remarks>
        public long MaxCharactersInPart => OpenSettings.MaxCharactersInPart;

        /// <summary>
        /// Gets a value indicating whether saving the package is supported by calling <see cref="Save"/>. Some platforms (such as .NET Core), have limited support for saving.
        /// If <c>false</c>, in order to save, the document and/or package needs to be fully closed and disposed and then reopened.
        /// </summary>
        public bool CanSave => Features.GetRequired<IPackageFeature>().Capabilities.HasFlagFast(PackageCapabilities.Save);

        /// <summary>
        /// Gets all the <see cref="DataPart"/> parts in the document package.
        /// </summary>
        public IEnumerable<DataPart> DataParts
        {
            get
            {
                LoadAllParts();
                return Features.GetRequired<IDataPartsFeature>().Parts;
            }
        }

        internal void LoadAllParts()
        {
            foreach (var part in this.GetAllParts())
            {
                // Force it to load
                _ = part.ChildrenRelationshipParts.Count;
            }
        }

        #region public methods

        /// <summary>
        /// Adds the specified part to the document.
        /// Use the returned part to operate on the part added to the document.
        /// </summary>
        /// <typeparam name="T">A class that is derived from the OpenXmlPart class.</typeparam>
        /// <param name="part">The part to add to the document.</param>
        /// <returns>The added part in the document. Differs from the part that was passed as an argument.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part is not allowed to be added.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the part type already exists and multiple instances of the part type is not allowed.</exception>
        public override T AddPart<T>(T part)
        {
            ThrowIfObjectDisposed();

            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (Features.Get<IMainPartFeature>() is { } mainPart && part.RelationshipType == mainPart.RelationshipType && part.ContentType != mainPart.ContentType)
            {
                throw new ArgumentOutOfRangeException(ExceptionMessages.MainPartIsDifferent);
            }

            return (T)AddPartFrom(part, null);
        }

        /// <summary>
        /// Deletes all the parts with the specified part type from the package recursively.
        /// </summary>
        public void DeletePartsRecursivelyOfType<T>()
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();
            DeletePartsRecursivelyOfTypeBase<T>();
        }

        /// <summary>
        /// Saves and closes the OpenXml package and all underlying part streams.
        /// </summary>
        public void Close()
        {
            ThrowIfObjectDisposed();
            Dispose();
        }

        #region methods to operate DataPart

        /// <summary>
        /// Creates a new <see cref="MediaDataPart"/> part in the document package.
        /// </summary>
        /// <param name="contentType">The content type of the new <see cref="MediaDataPart"/> part.</param>
        /// <returns>The added <see cref="MediaDataPart"/> part.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="contentType"/> is a null reference.</exception>
        public MediaDataPart CreateMediaDataPart(string contentType)
        {
            ThrowIfObjectDisposed();

            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            var mediaDataPart = new MediaDataPart(InternalOpenXmlPackage, contentType, extension: null);

            Features.GetRequired<IDataPartsFeature>().Add(mediaDataPart);

            return mediaDataPart;
        }

        /// <summary>
        /// Creates a new <see cref="MediaDataPart"/> part in the document package.
        /// </summary>
        /// <param name="contentType">The content type of the new <see cref="MediaDataPart"/> part.</param>
        /// <param name="extension">The part name extension (.dat, etc.) of the new <see cref="MediaDataPart"/> part.</param>
        /// <returns>The added <see cref="MediaDataPart"/> part.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="contentType"/> is a null reference.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="extension"/> is a null reference.</exception>
        public MediaDataPart CreateMediaDataPart(string contentType, string extension)
        {
            ThrowIfObjectDisposed();

            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (extension is null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            var mediaDataPart = new MediaDataPart(InternalOpenXmlPackage, contentType, extension);

            Features.GetRequired<IDataPartsFeature>().Add(mediaDataPart);

            return mediaDataPart;
        }

        /// <summary>
        /// Creates a new <see cref="MediaDataPart"/> part in the document package.
        /// </summary>
        /// <param name="mediaDataPartType">The content type of the new <see cref="MediaDataPart"/> part.</param>
        /// <returns>The added <see cref="MediaDataPart"/> part.</returns>
        public MediaDataPart CreateMediaDataPart(MediaDataPartType mediaDataPartType)
        {
            ThrowIfObjectDisposed();

            var mediaDataPart = new MediaDataPart(InternalOpenXmlPackage, mediaDataPartType);

            Features.GetRequired<IDataPartsFeature>().Add(mediaDataPart);

            return mediaDataPart;
        }

        /// <summary>
        /// Deletes the specified <see cref="DataPart"/> from the document package.
        /// </summary>
        /// <param name="dataPart">The <see cref="DataPart"/> to be deleted.</param>
        /// <returns>Returns true if the part is successfully removed; otherwise returns false. This method also returns false if the part was not found or the parameter is null.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="dataPart"/> is referenced by another part in the document package.</exception>
        public bool DeletePart(DataPart dataPart)
        {
            ThrowIfObjectDisposed();

            if (dataPart is null)
            {
                throw new ArgumentNullException(nameof(dataPart));
            }

            if (dataPart.OpenXmlPackage != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignDataPart);
            }

            if (IsOrphanDataPart(dataPart))
            {
                // delete the part from the package
                dataPart.Destroy();
                return Features.GetRequired<IDataPartsFeature>().Remove(dataPart);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.DataPartIsInUse);
            }
        }

        #endregion

        #endregion

        #region dispose related methods

        /// <summary>
        /// Thrown if an object is disposed.
        /// </summary>
        protected override void ThrowIfObjectDisposed()
        {
            if (_isDisposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        /// <summary>
        /// Flushes and saves the content, closes the document, and releases all resources.
        /// </summary>
        /// <param name="disposing">Specify true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }

            if (disposing)
            {
                var closing = Features.Get<IPackageEventsFeature>();

                closing?.OnChange(this, EventType.Closing);

                // Try to save contents of every part in the package
                SavePartContents(AutoSave);
                DeleteUnusedDataPartOnClose();

                Features.Get<IContainerDisposableFeature>()?.Dispose();

                closing?.OnChange(this, EventType.Closed);
                _isDisposed = true;
            }
        }

        /// <summary>
        /// Flushes and saves the content, closes the document, and releases all resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region MC Staffs

        /// <summary>
        /// Gets the markup compatibility settings applied at loading time.
        /// </summary>
        public MarkupCompatibilityProcessSettings MarkupCompatibilityProcessSettings
        {
            get
            {
                if (OpenSettings.MarkupCompatibilityProcessSettings is null)
                {
                    return new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007);
                }
                else
                {
                    return OpenSettings.MarkupCompatibilityProcessSettings;
                }
            }
        }
        #endregion

        #region Auto-Save functions

        /// <summary>
        /// Gets a value indicating whether the parts should be saved when disposed.
        /// </summary>
        public bool AutoSave => OpenSettings.AutoSave;

        private IPackage SavePartContents(bool save)
        {
            var package = Features.GetRequired<IPackageFeature>().Package;

            if (package.FileOpenAccess == FileAccess.Read)
            {
                return package; // do nothing if the package is open in read-only mode.
            }

            // When this.StrictRelationshipFound is true, we ignore the save argument to do the translation if isAnyPartChanged is true. That's the way to keep consistency.
            if (!save && !StrictRelationshipFound)
            {
                return package; // do nothing if saving is false.
            }

            var saveFeature = Features.Get<ISaveFeature>();

            saveFeature?.Save(this);

            foreach (var part in this.GetAllParts())
            {
                saveFeature?.Save(part);

                TrySavePartContent(part);
            }

            return package;
        }

        // Check if the part content changed and save it if yes.
        private static void TrySavePartContent(OpenXmlPart part)
        {
            // If StrictRelationshipFound is true, we need to update the part anyway.
            if (part.OpenXmlPackage.StrictRelationshipFound)
            {
                // For ISO Strict documents, we read and save the part anyway to translate the contents. The contents are translated when PartRootElement is being loaded.
                if (part.PartRootElement is not null)
                {
                    part.PartRootElement.Save();
                }
            }
            else
            {
                // For Transitional documents, we only save the 'changed' part.
                if (IsPartContentChanged(part) && part.PartRootElement is not null)
                {
                    part.PartRootElement.Save();
                }
            }
        }

        // Check if the content of a part is changed.
        private static bool IsPartContentChanged(OpenXmlPart part)
        {
            // If the root element of the part is loaded,
            // consider the part changed and should be saved.
            if (!part.IsRootElementLoaded &&
                part.OpenXmlPackage.MarkupCompatibilityProcessSettings.ProcessMode == MarkupCompatibilityProcessMode.ProcessAllParts)
            {
                if (part.PartRootElement is not null)
                {
                    return true;
                }
            }

            return part.IsRootElementLoaded;
        }

        #endregion

        #region internal methods related main part

        internal string MainPartContentType
        {
            get => Features.GetRequired<IMainPartFeature>().ContentType;
        }

        /// <summary>
        /// Changes the type of the document.
        /// </summary>
        /// <typeparam name="T">The type of the document's main part.</typeparam>
        /// <remarks>The MainDocumentPart will be changed.</remarks>
        internal void ChangeDocumentTypeInternal<T>(T newMainPart)
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            var mainPart = GetSubPartOfType<T>();
            var childParts = new Dictionary<string, OpenXmlPart>(StringComparer.Ordinal);

            if (mainPart is null)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType);
            }

            try
            {
                using (var memoryStream = mainPart.CopyToMemoryStream())
                {
                    var tempPart = AddExtendedPart(@"http://temp", MainPartContentType, @".xml");

                    // Make a copy as we will remove old parts and need the originals later
                    foreach (KeyValuePair<string, OpenXmlPart> idPartPair in mainPart.ChildrenRelationshipParts)
                    {
                        childParts.Add(idPartPair.Key, idPartPair.Value);
                    }

                    var referenceRelationships = mainPart.Features.GetRequired<IReferenceRelationshipsFeature>().Relationships.ToArray();

                    Uri uri = mainPart.Uri;
                    string id = GetIdOfPart(mainPart);

                    // remove the old part
                    ChildrenRelationshipParts.Remove(id);
                    mainPart.Destroy();

                    // do not call this.InitPart( ).  copy the code here
                    newMainPart.CreateInternal(this, null, MainPartContentType, uri);

                    // add it and get the id
                    ChildrenRelationshipParts.Add(newMainPart, id);

                    // copy the stream back
                    memoryStream.Position = 0;
                    newMainPart.FeedData(memoryStream);

                    // add back all relationships
                    foreach (KeyValuePair<string, OpenXmlPart> idPartPair in childParts)
                    {
                        newMainPart.ChildrenRelationshipParts.Add(idPartPair.Value, idPartPair.Key);
                    }

                    foreach (ExternalRelationship externalRel in referenceRelationships.OfType<ExternalRelationship>())
                    {
                        newMainPart.AddExternalRelationship(externalRel.RelationshipType, externalRel.Uri, externalRel.Id);
                    }

                    foreach (HyperlinkRelationship hyperlinkRel in referenceRelationships.OfType<HyperlinkRelationship>())
                    {
                        newMainPart.AddHyperlinkRelationship(hyperlinkRel.Uri, hyperlinkRel.IsExternal, hyperlinkRel.Id);
                    }

                    foreach (DataPartReferenceRelationship dataPartReference in referenceRelationships.OfType<DataPartReferenceRelationship>())
                    {
                        newMainPart.AddDataPartReferenceRelationship(dataPartReference);
                    }

                    // delete the temp part
                    id = GetIdOfPart(tempPart);
                    ChildrenRelationshipParts.Remove(id);
                    tempPart.Destroy();
                }
            }
            catch (OpenXmlPackageException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, e);
            }
            catch (SystemException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentTypeSerious, e);
            }
        }

        #endregion

        #region internal methods

        internal sealed override OpenXmlPackage InternalOpenXmlPackage => this;

        internal sealed override OpenXmlPart? ThisOpenXmlPart => null;

        internal override IRelationshipCollection Relationships => Package.Relationships;

        // find all reachable parts from the package root, the dictionary also used for cycle reference defense
        internal sealed override void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
        {
            ThrowIfObjectDisposed();

            if (reachableParts is null)
            {
                throw new ArgumentNullException(nameof(reachableParts));
            }

            foreach (OpenXmlPart part in ChildrenRelationshipParts.Parts)
            {
                if (!reachableParts.ContainsKey(part))
                {
                    part.FindAllReachableParts(reachableParts);
                }
            }
        }

        // create the metro part in the package with the CompressionOption
        internal IPackagePart CreateMetroPart(Uri partUri, string contentType)
        {
            return Features.GetRequired<IPackageFeature>().Package.CreatePart(partUri, contentType, CompressionOption);
        }

        #endregion

        #region methods on DataPart

        private static bool IsOrphanDataPart(DataPart dataPart)
        {
            return !dataPart.GetDataPartReferenceRelationships().Any();
        }

        /// <summary>
        /// Deletes all DataParts that are not referenced by any media, audio, or video reference relationships.
        /// </summary>
        private void DeleteUnusedDataPartOnClose()
        {
            var dataParts = Features.GetRequired<IDataPartsFeature>();

            if (dataParts.Count > 0)
            {
                HashSet<DataPart> dataPartSet = new HashSet<DataPart>();
                foreach (var dataPart in dataParts.Parts)
                {
                    dataPartSet.Add(dataPart);
                }

                // first, see if there are any reference in package level.
                foreach (var dataPartReferenceRelationship in DataPartReferenceRelationships)
                {
                    dataPartSet.Remove(dataPartReferenceRelationship.DataPart);
                    if (dataPartSet.Count == 0)
                    {
                        // No more DataPart in the set. All DataParts are referenced somewhere.
                        return;
                    }
                }

                // for each part in the package, check the DataPartReferenceRelationships.
                foreach (var openXmlPart in this.GetAllParts())
                {
                    foreach (var dataPartReferenceRelationship in openXmlPart.DataPartReferenceRelationships)
                    {
                        dataPartSet.Remove(dataPartReferenceRelationship.DataPart);
                        if (dataPartSet.Count == 0)
                        {
                            // No more DataPart in the set. All DataParts are referenced somewhere.
                            return;
                        }
                    }
                }

                foreach (var dataPart in dataPartSet)
                {
                    // delete the part from the package
                    dataPart.Destroy();
                    Features.GetRequired<IDataPartsFeature>().Remove(dataPart);
                }
            }
        }

        internal DataPart AddDataPartToList(DataPart dataPart)
        {
            Features.GetRequired<IDataPartsFeature>().Add(dataPart);
            return dataPart;
        }

        #endregion

        #region saving and cloning

        #region saving

        private readonly object _saveAndCloneLock = new object();

        /// <summary>
        /// Saves the contents of all parts and relationships that are contained in the OpenXml package, if <see cref="FileOpenAccess"/> is <see cref="FileAccess.ReadWrite"/>.
        /// Some platforms do not support saving due to limitations in <see cref="System.IO.Packaging.Package"/>, so please query <see cref="CanSave"/> at runtime to know if
        /// full saving will be supported without closing and disposing of the <see cref="OpenXmlPackage"/>.
        /// </summary>
        public void Save()
        {
            ThrowIfObjectDisposed();
            if (FileOpenAccess == FileAccess.ReadWrite)
            {
                lock (_saveAndCloneLock)
                {
                    SavePartContents(true);
                    Features.GetRequired<IPackageFeature>().Package.Save();
                }
            }
        }

        /// <summary>
        /// Saves the contents of all parts and relationships that are contained
        /// in the OpenXml package to the specified file. Opens the saved document
        /// using the same settings that were used to open this OpenXml package.
        /// </summary>
        /// <remarks>
        /// Calling SaveAs(string) is exactly equivalent to calling Clone(string).
        /// This method is essentially provided for convenience.
        /// </remarks>
        /// <param name="path">The path and file name of the target document.</param>
        /// <returns>The cloned OpenXml package</returns>
        public OpenXmlPackage SaveAs(string path)
        {
            return Clone(path);
        }

        #endregion saving

        #region Default clone method

        /// <summary>
        /// Creates an editable clone of this OpenXml package, opened on a
        /// <see cref="MemoryStream"/> with expandable capacity and using
        /// default OpenSettings.
        /// </summary>
        /// <returns>The cloned OpenXml package.</returns>
        public OpenXmlPackage Clone()
        {
#pragma warning disable CA2000 // Dispose objects before losing scope
            return Clone(new MemoryStream(), true, new OpenSettings());
#pragma warning restore CA2000 // Dispose objects before losing scope
        }

        #endregion Default clone method

        #region Stream-based cloning

        /// <summary>
        /// Creates a clone of this OpenXml package, opened on the given stream.
        /// The cloned OpenXml package is opened with the same settings, i.e.,
        /// FileOpenAccess and OpenSettings, as this OpenXml package.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the OpenXml package.</param>
        /// <returns>The cloned OpenXml package.</returns>
        public OpenXmlPackage Clone(Stream stream)
        {
            return Clone(stream, FileOpenAccess == FileAccess.ReadWrite, OpenSettings);
        }

        /// <summary>
        /// Creates a clone of this OpenXml package, opened on the given stream.
        /// The cloned OpenXml package is opened with the same OpenSettings as
        /// this OpenXml package.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the OpenXml package.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>The cloned OpenXml package.</returns>
        public OpenXmlPackage Clone(Stream stream, bool isEditable)
        {
            return Clone(stream, isEditable, OpenSettings);
        }

        /// <summary>
        /// Creates a clone of this OpenXml package, opened on the given stream.
        /// </summary>
        /// <param name="stream">The IO stream on which to open the OpenXml package.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>The cloned OpenXml package.</returns>
        public OpenXmlPackage Clone(Stream stream, bool isEditable, OpenSettings openSettings)
        {
            if (stream is null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            // Use this OpenXml package's OpenSettings if none are provided.
            // This is more in line with cloning than providing the default
            // OpenSettings, i.e., unless the caller explicitly specifies
            // something, we'll later open the clone with this OpenXml
            // package's OpenSettings.
            if (openSettings is null)
            {
                openSettings = OpenSettings;
            }

            lock (_saveAndCloneLock)
            {
                // Save the contents of all parts and relationships that are contained
                // in the OpenXml package to make sure we clone a consistent state.
                // This will also invoke ThrowIfObjectDisposed(), so we don't need
                // to call it here.
                Save();

                // Create new OpenXmlPackage backed by stream. Next, copy all document
                // parts (AddPart will copy the parts and their children in a recursive
                // fashion) and close/dispose the document (by leaving the scope of the
                // using statement). Finally, reopen the clone from the MemoryStream.
                // This way, writing the stream to a file, for example, directly after
                // returning from this method will not lead to issues with corrupt files
                // and a FileFormatException ("Compressed part has inconsistent data length")
                // thrown within OpenXmlPackage.OpenCore(string, bool) by the
                //     this._metroPackage = Package.Open(path, ...);
                // assignment.
                using (var clone = CreateClone(stream))
                using (clone.EnableCloningFeatures())
                {
                    foreach (var part in Parts)
                    {
                        clone.AddPart(part.OpenXmlPart, part.RelationshipId);
                    }
                }

                return OpenClone(stream, isEditable, openSettings);
            }
        }

        /// <summary>
        /// Creates a new OpenXmlPackage on the given stream.
        /// </summary>
        /// <param name="stream">The stream on which the concrete OpenXml package will be created.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected abstract OpenXmlPackage CreateClone(Stream stream);

        /// <summary>
        /// Opens the cloned OpenXml package on the given stream.
        /// </summary>
        /// <param name="stream">The stream on which the cloned OpenXml package will be opened.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected abstract OpenXmlPackage OpenClone(Stream stream, bool isEditable, OpenSettings openSettings);

        #endregion Stream-based cloning

        #region File-based cloning

        /// <summary>
        /// Creates a clone of this OpenXml package opened from the given file
        /// (which will be created by cloning this OpenXml package).
        /// The cloned OpenXml package is opened with the same settings, i.e.,
        /// FileOpenAccess and OpenSettings, as this OpenXml package.
        /// </summary>
        /// <param name="path">The path and file name of the target document.</param>
        /// <returns>The cloned document.</returns>
        public OpenXmlPackage Clone(string path)
        {
            return Clone(path, FileOpenAccess == FileAccess.ReadWrite, OpenSettings);
        }

        /// <summary>
        /// Creates a clone of this OpenXml package opened from the given file
        /// (which will be created by cloning this OpenXml package).
        /// The cloned OpenXml package is opened with the same OpenSettings as
        /// this OpenXml package.
        /// </summary>
        /// <param name="path">The path and file name of the target document.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <returns>The cloned document.</returns>
        public OpenXmlPackage Clone(string path, bool isEditable)
        {
            return Clone(path, isEditable, OpenSettings);
        }

        /// <summary>
        /// Creates a clone of this OpenXml package opened from the given file (which
        /// will be created by cloning this OpenXml package).
        /// </summary>
        /// <param name="path">The path and file name of the target document.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>The cloned document.</returns>
        public OpenXmlPackage Clone(string path, bool isEditable, OpenSettings? openSettings)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            // Use this OpenXml package's OpenSettings if none are provided.
            // This is more in line with cloning than providing the default
            // OpenSettings, i.e., unless the caller explicitly specifies
            // something, we'll later open the clone with this OpenXml
            // package's OpenSettings.
            if (openSettings is null)
            {
                openSettings = OpenSettings;
            }

            lock (_saveAndCloneLock)
            {
                // Save the contents of all parts and relationships that are contained
                // in the OpenXml package to make sure we clone a consistent state.
                // This will also invoke ThrowIfObjectDisposed(), so we don't need
                // to call it here.
                Save();

                // Use the same approach as for the streams-based cloning, i.e., close
                // and reopen the document.
                using (var clone = CreateClone(path))
                using (clone.EnableCloningFeatures())
                {
                    foreach (var part in Parts)
                    {
                        clone.AddPart(part.OpenXmlPart, part.RelationshipId);
                    }
                }

                return OpenClone(path, isEditable, openSettings);
            }
        }

        /// <summary>
        /// Creates a new OpenXml package on the given file.
        /// </summary>
        /// <param name="path">The path and file name of the target OpenXml package.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected abstract OpenXmlPackage CreateClone(string path);

        /// <summary>
        /// Opens the cloned OpenXml package on the given file.
        /// </summary>
        /// <param name="path">The path and file name of the target OpenXml package.</param>
        /// <param name="isEditable">In ReadWrite mode. False for Read only mode.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected abstract OpenXmlPackage OpenClone(string path, bool isEditable, OpenSettings openSettings);

        #endregion File-based cloning

        #region Package-based cloning

        /// <summary>
        /// Creates a clone of this OpenXml package, opened on the specified instance
        /// of Package. The clone will be opened with the same OpenSettings as this
        /// OpenXml package.
        /// </summary>
        /// <param name="package">The specified instance of Package.</param>
        /// <returns>The cloned OpenXml package.</returns>
        public OpenXmlPackage Clone(Package package)
        {
            return Clone(package, OpenSettings);
        }

        /// <summary>
        /// Creates a clone of this OpenXml package, opened on the specified instance
        /// of Package.
        /// </summary>
        /// <param name="package">The specified instance of Package.</param>
        /// <param name="openSettings">The advanced settings for opening a document.</param>
        /// <returns>The cloned OpenXml package.</returns>
        public OpenXmlPackage Clone(Package package, OpenSettings openSettings)
        {
            if (package is null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            // Use this OpenXml package's OpenSettings if none are provided.
            // This is more in line with cloning than providing the default
            // OpenSettings, i.e., unless the caller explicitly specifies
            // something, we'll later open the clone with this OpenXml
            // package's OpenSettings.
            if (openSettings is null)
            {
                openSettings = OpenSettings;
            }

            lock (_saveAndCloneLock)
            {
                // Save the contents of all parts and relationships that are contained
                // in the OpenXml package to make sure we clone a consistent state.
                // This will also invoke ThrowIfObjectDisposed(), so we don't need
                // to call it here.
                Save();

                // Create a new OpenXml package, copy this package's parts, and flush.
                // This is different from the stream and file-based cloning, because
                // we don't close the package here (whereas it will be closed in
                // stream and file-based cloning to make sure the underlying stream
                // or file can be read without any corruption issues directly after
                // having cloned the OpenXml package).
                OpenXmlPackage clone = CreateClone(package);
                foreach (var part in Parts)
                {
                    clone.AddPart(part.OpenXmlPart, part.RelationshipId);
                }

                // TODO: Revisit.
                // package.Flush();

                // Configure OpenSettings.
                clone.OpenSettings = new OpenSettings(openSettings);

                return clone;
            }
        }

        /// <summary>
        /// Creates a new instance of OpenXmlPackage on the specified instance
        /// of Package.
        /// </summary>
        /// <param name="package">The specified instance of Package.</param>
        /// <returns>A new instance of OpenXmlPackage.</returns>
        protected abstract OpenXmlPackage CreateClone(Package package);

        #endregion Package-based cloning

        #endregion saving and cloning

        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new PackageFeatureCollection(this, FeatureCollection.Default);
    }
}
