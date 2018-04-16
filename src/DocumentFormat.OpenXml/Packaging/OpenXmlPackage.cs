// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private readonly PartExtensionProvider _partExtensionProvider = new PartExtensionProvider();
        private readonly LinkedList<DataPart> _dataPartList = new LinkedList<DataPart>();

        private bool _disposed;
        private Package _package;
        private string _mainPartContentType;
        private PartUriHelper _partUriHelper = new PartUriHelper();

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class.
        /// </summary>
        protected OpenXmlPackage()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied Open XML package.
        /// </summary>
        /// <param name="package">The target package for the OpenXmlPackage class.</param>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when package is not opened with read access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        internal void OpenCore(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException(nameof(package));
            }

            if (package.FileOpenAccess == FileAccess.Write)
            {
                throw new OpenXmlPackageException(ExceptionMessages.PackageMustCanBeRead);
            }

            _package = package;

            Load();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class with access to a specified Open XML package.
        /// </summary>
        /// <param name="package">The target package for the OpenXmlPackage class.</param>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        internal void CreateCore(Package package)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False indicates read-only mode.</param>
        /// <exception cref="ArgumentNullException">Thrown when stream is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the specified stream is read-only and <paramref name="readWriteMode"/> is true. The package to open requires write or read/write permission.</exception>
        internal void OpenCore(Stream stream, bool readWriteMode)
        {
            if (stream == null)
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

            _package = Package.Open(stream, packageMode, packageAccess);

            Load();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <exception cref="ArgumentNullException">Thrown when stream is a null reference.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the specified stream is read-only. The package to open requires write or read/write permission.</exception>
        internal void CreateCore(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            if (!stream.CanWrite)
            {
                throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldBeWrite);
            }

            _package = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False for read only mode.</param>
        /// <exception cref="ArgumentNullException">Thrown when path is a null reference.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the supplied path cannot be found</exception>
        internal void OpenCore(string path, bool readWriteMode)
        {
            if (path == null)
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

            _package = Package.Open(path, packageAccess, packageMode, packageShare);

            Load();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        /// <exception cref="ArgumentNullException">Thrown when path is a null reference.</exception>
        internal void CreateCore(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            _package = Package.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
        }

        /// <summary>
        /// Loads the package. This method must be called in the constructor of a derived class.
        /// </summary>
        private void Load()
        {
            try
            {
                Dictionary<Uri, OpenXmlPart> loadedParts = new Dictionary<Uri, OpenXmlPart>();

                bool hasMainPart = false;
                RelationshipCollection relationshipCollection = new PackageRelationshipPropertyCollection(_package);

                // relationCollection.StrictTranslation is true when this collection contains Transitional relationships converted from Strict.
                StrictTranslation = relationshipCollection.StrictTranslation;

                // AutoSave must be false when opening ISO Strict doc as editable.
                // (Attention: #2545529. Now we disable this code until we finally decide to go with this. Instead, we take an alternative approach that is added in the SavePartContents() method
                // which we ignore AutoSave when this.StrictTranslation is true to keep consistency in the document.)
                //if (this.StrictTranslation && (this._accessMode == FileAccess.ReadWrite || this._accessMode == FileAccess.Write) && !this.AutoSave)
                //{
                //    OpenXmlPackageException exception = new OpenXmlPackageException(ExceptionMessages.StrictEditNeedsAutoSave);
                //    throw exception;
                //}

                // auto detect document type (main part type for Transitional)
                foreach (RelationshipProperty relationship in relationshipCollection)
                {
                    if (relationship.RelationshipType == MainPartRelationshipType)
                    {
                        hasMainPart = true;

                        Uri uriTarget = PackUriHelper.ResolvePartUri(new Uri("/", UriKind.Relative), relationship.TargetUri);
                        PackagePart metroPart = Package.GetPart(uriTarget);

                        if (!IsValidMainPartContentType(metroPart.ContentType))
                        {
                            throw new OpenXmlPackageException(ExceptionMessages.InvalidPackageType);
                        }

                        MainPartContentType = metroPart.ContentType;
                        break;
                    }
                }

                if (!hasMainPart)
                {
                    throw new OpenXmlPackageException(ExceptionMessages.NoMainPart);
                }

                LoadReferencedPartsAndRelationships(this, null, relationshipCollection, loadedParts);
            }
            catch (UriFormatException exception)
            {
                // UriFormatException is wrapped here in an OpenXmlPackageException
                Close();
                throw new OpenXmlPackageException(ExceptionMessages.InvalidUriFormat, exception);
            }
            catch (Exception)
            {
                Close();
                throw;
            }
        }

        internal OpenSettings OpenSettings { get; set; }

        internal bool StrictTranslation { get; set; } = false;

        /// <summary>
        /// Gets the package of the document.
        /// </summary>
        public Package Package
        {
            get
            {
                ThrowIfObjectDisposed();
                return _package;
            }
        }

        /// <summary>
        /// Gets the FileAccess setting for the document.
        /// The current I/O access settings are: Read, Write, or ReadWrite.
        /// </summary>
        public FileAccess FileOpenAccess => _package.FileOpenAccess;

        /// <summary>
        /// Gets the core package properties of the Open XML document.
        /// </summary>
        public PackageProperties PackageProperties
        {
            get
            {
                ThrowIfObjectDisposed();
                return Package.PackageProperties;
            }
        }

        /// <summary>
        /// Gets or sets the compression level for the content of the new part
        /// </summary>
        public CompressionOption CompressionOption { get; set; } = CompressionOption.Normal;

        /// <summary>
        /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
        /// </summary>
        public PartExtensionProvider PartExtensionProvider
        {
            get
            {
                ThrowIfObjectDisposed();
                return _partExtensionProvider;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates the maximum allowable number of characters in an Open XML part. A zero (0) value indicates that there are no limits on the size
        /// of the part. A non-zero value specifies the maximum size, in characters.
        /// </summary>
        /// <remarks>
        /// This property allows you to mitigate denial of service attacks where the attacker submits a package with an extremely large Open XML part. By limiting the size of a
        /// part, you can detect the attack and recover reliably.
        /// </remarks>
        public long MaxCharactersInPart { get; internal set; }

        /// <summary>
        /// Gets a value indicating whether saving the package is supported by calling <see cref="Save"/>. Some platforms (such as .NET Core), have limited support for saving.
        /// If <c>false</c>, in order to save, the document and/or package needs to be fully closed and disposed and then reopened.
        /// </summary>
        public static bool CanSave { get; } =
#if FEATURE_PACKAGE_FLUSH
            true;
#else
            false;
#endif

        /// <summary>
        /// Gets all the <see cref="DataPart"/> parts in the document package.
        /// </summary>
        public IEnumerable<DataPart> DataParts => _dataPartList;

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

            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (part.RelationshipType == MainPartRelationshipType &&
                part.ContentType != MainPartContentType)
            {
                throw new ArgumentOutOfRangeException(ExceptionMessages.MainPartIsDifferent);
            }

            return (T)AddPartFrom(part, null);
        }

        /// <summary>
        /// Deletes all the parts with the specified part type from the package recursively.
        /// </summary>
        public void DeletePartsRecursivelyOfType<T>() where T : OpenXmlPart
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

            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            MediaDataPart mediaDataPart = new MediaDataPart();

            mediaDataPart.CreateInternal(InternalOpenXmlPackage, contentType, null);

            _dataPartList.AddLast(mediaDataPart);

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

            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            MediaDataPart mediaDataPart = new MediaDataPart();

            mediaDataPart.CreateInternal(InternalOpenXmlPackage, contentType, extension);

            _dataPartList.AddLast(mediaDataPart);

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

            MediaDataPart mediaDataPart = new MediaDataPart();

            mediaDataPart.CreateInternal(InternalOpenXmlPackage, mediaDataPartType);

            _dataPartList.AddLast(mediaDataPart);

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

            if (dataPart == null)
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
                return _dataPartList.Remove(dataPart);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.DataPartIsInUse);
            }
        }

        #endregion

        #endregion

        #region public virtual methods

        /// <summary>
        /// Validates the package. This method does not validate the XML content in each part.
        /// </summary>
        /// <param name="validationSettings">The OpenXmlPackageValidationSettings for validation events.</param>
        /// <remarks>If validationSettings is null or no EventHandler is set, the default behavior is to throw an OpenXmlPackageException on the validation error. </remarks>
        [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
        public void Validate(OpenXmlPackageValidationSettings validationSettings)
        {
            ThrowIfObjectDisposed();

            void DefaultValidationEventHandler(object sender, OpenXmlPackageValidationEventArgs e)
            {
                var exception = new OpenXmlPackageException(ExceptionMessages.ValidationException);

                exception.Data.Add("OpenXmlPackageValidationEventArgs", e);

                throw exception;
            }

            OpenXmlPackageValidationSettings ValidateSettings(OpenXmlPackageValidationSettings settings)
            {
                if (settings.GetEventHandler() == null)
                {
                    // use default DefaultValidationEventHandler( ) which throw an exception
                    settings.EventHandler += DefaultValidationEventHandler;
                }

                if (!settings.FileFormat.Any())
                {
                    settings.FileFormat = FileFormatVersions.Office2007;
                }

                return settings;
            }

            new Validation.PackageValidator(this).Validate(ValidateSettings(validationSettings ?? new OpenXmlPackageValidationSettings()));
        }

        [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
        internal void Validate(OpenXmlPackageValidationSettings validationSettings, FileFormatVersions fileFormatVersions)
        {
            Debug.Assert(validationSettings != null);
            Debug.Assert(fileFormatVersions.Any());

            validationSettings.FileFormat = fileFormatVersions;

            Validate(validationSettings);
        }

        #endregion

        #region internal methods

        /// <summary>
        /// Reserves the URI of the loaded part.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="partUri"></param>
        internal void ReserveUri(string contentType, Uri partUri)
        {
            ThrowIfObjectDisposed();

            _partUriHelper.ReserveUri(contentType, partUri);
        }

        /// <summary>
        /// Gets a unique part URI for the newly created part.
        /// </summary>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="parentUri">The URI of the parent part.</param>
        /// <param name="targetPath"></param>
        /// <param name="targetName"></param>
        /// <param name="targetExt"></param>
        /// <returns></returns>
        internal Uri GetUniquePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt)
        {
            ThrowIfObjectDisposed();

            Uri partUri = null;

            // fix bug #241492
            // check to avoid name conflict with orphan parts in the packages.
            do
            {
                partUri = _partUriHelper.GetUniquePartUri(contentType, parentUri, targetPath, targetName, targetExt);
            } while (_package.PartExists(partUri));

            return partUri;
        }

        /// <summary>
        /// Gets a unique part URI for the newly created part.
        /// </summary>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="parentUri">The URI of the parent part.</param>
        /// <param name="targetUri"></param>
        /// <returns></returns>
        internal Uri GetUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
        {
            ThrowIfObjectDisposed();

            Uri partUri = null;

            // fix bug #241492
            // check to avoid name conflict with orphan parts in the packages.
            do
            {
                partUri = _partUriHelper.GetUniquePartUri(contentType, parentUri, targetUri);
            } while (_package.PartExists(partUri));

            return partUri;
        }

        #endregion

        #region dispose related methods

        /// <summary>
        /// Thrown if an object is disposed.
        /// </summary>
        protected override void ThrowIfObjectDisposed()
        {
            if (_disposed)
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
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // Try to save contents of every part in the package
                SavePartContents(AutoSave);
                DeleteUnusedDataPartOnClose();

                // TODO: Close resources
                _package.Close();
                _package = null;
                ChildrenRelationshipParts.Clear();
                ReferenceRelationshipList.Clear();
                _partUriHelper = null;
            }

            _disposed = true;
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
                if (OpenSettings.MarkupCompatibilityProcessSettings == null)
                    return new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007);
                else
                    return OpenSettings.MarkupCompatibilityProcessSettings;
            }
        }

        //internal FileFormatVersions MCTargetFormat
        //{
        //    get
        //    {
        //        if (MarkupCompatibilityProcessSettings.ProcessMode == MarkupCompatibilityProcessMode.NoProcess)
        //            return (FileFormatVersions.Office2007 | FileFormatVersions.Office2010);
        //        else
        //        {
        //            return MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
        //        }
        //    }
        //}

        //internal bool ProcessMCInWholePackage
        //{
        //    get
        //    {
        //        return MarkupCompatibilityProcessSettings.ProcessMode == MarkupCompatibilityProcessMode.ProcessAllParts;
        //    }
        //}
        #endregion

        #region Auto-Save functions

        /// <summary>
        /// Gets a value indicating whether the parts should be saved when disposed.
        /// </summary>
        public bool AutoSave => OpenSettings.AutoSave;

        private void SavePartContents(bool save)
        {
            bool isAnyPartChanged;

            if (FileOpenAccess == FileAccess.Read)
            {
                return; // do nothing if the package is open in read-only mode.
            }

            // When this.StrictTranslation is true, we ignore the save argument to do the translation if isAnyPartChanged is true. That's the way to keep consistency.
            if (!save && !StrictTranslation)
            {
                return; // do nothing if saving is false.
            }

            // Traversal the whole package and save changed contents.
            isAnyPartChanged = false;

            // If a part is in the state of 'loaded', something in the part should've been changed.
            // When all the part is not loaded yet, we can skip saving all parts' contents and updating Package relationship types.
            foreach (var part in this.GetAllParts())
            {
                if (part.IsRootElementLoaded)
                {
                    isAnyPartChanged = true;
                    break;
                }
            }

            // We update parts and relationship types only when any one of the parts was changed (i.e. loaded).
            if (isAnyPartChanged)
            {
                foreach (var part in this.GetAllParts())
                {
                    TrySavePartContent(part);
                }

                if (StrictTranslation)
                {
                    RelationshipCollection relationshipCollection;

                    // For Package: Invoking UpdateRelationshipTypesInPackage() changes the relationship types in the package.
                    // We need to new PackageRelationshipPropertyCollection to read through the package contents right here
                    // because some operation may have updated the package before we get here.
                    relationshipCollection = new PackageRelationshipPropertyCollection(_package);
                    relationshipCollection.UpdateRelationshipTypesInPackage();
                }
            }
        }

        // Check if the part content changed and save it if yes.
        private static void TrySavePartContent(OpenXmlPart part)
        {
            Debug.Assert(part != null);
            Debug.Assert(part.OpenXmlPackage != null);

            // If StrictTranslation is true, we need to update the part anyway.
            if (part.OpenXmlPackage.StrictTranslation)
            {
                RelationshipCollection relationshipCollection;

                // For PackagePart: Invoking UpdateRelationshipTypesInPackage() changes the relationship types in the package part.
                // We need to new PackageRelationshipPropertyCollection to read through the package part contents right here
                // because some operation may have updated the package part before we get here.
                relationshipCollection = new PackagePartRelationshipPropertyCollection(part.PackagePart);
                relationshipCollection.UpdateRelationshipTypesInPackage();

                // For ISO Strict documents, we read and save the part anyway to translate the contents. The contents are translated when PartRootElement is being loaded.
                if (part.PartRootElement != null)
                {
                    SavePartContent(part);
                }
            }
            else
            {
                // For Transitional documents, we only save the 'changed' part.
                if (IsPartContentChanged(part))
                {
                    SavePartContent(part);
                }
            }
        }

        // Check if the content of a part is changed.
        private static bool IsPartContentChanged(OpenXmlPart part)
        {
            Debug.Assert(part != null);

            // If the root element of the part is loaded,
            // consider the part changed and should be saved.
            Debug.Assert(part.OpenXmlPackage != null);
            if (!part.IsRootElementLoaded &&
                part.OpenXmlPackage.MarkupCompatibilityProcessSettings.ProcessMode == MarkupCompatibilityProcessMode.ProcessAllParts)
            {
                if (part.PartRootElement != null)
                {
                    return true;
                }
            }

            return part.IsRootElementLoaded;
        }

        // Save the content of a part to its stream.
        private static void SavePartContent(OpenXmlPart part)
        {
            Debug.Assert(part != null);
            Debug.Assert(part.IsRootElementLoaded);

            // Save PartRootElement to the part stream.
            part.PartRootElement.Save();
        }
        #endregion

        #region internal methods related main part

        /// <summary>
        /// Gets the relationship type of the main part.
        /// </summary>
        internal abstract string MainPartRelationshipType { get; }

        /// <summary>
        /// Gets or sets the content type of the main part of the package.
        /// </summary>
        internal string MainPartContentType
        {
            get
            {
                return _mainPartContentType;
            }

            set
            {
                if (IsValidMainPartContentType(value))
                {
                    _mainPartContentType = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(ExceptionMessages.InvalidMainPartContentType);
                }
            }
        }

        /// <summary>
        /// Gets the list of valid content types for the main part.
        /// </summary>
        internal abstract ICollection<string> ValidMainPartContentTypes { get; }

        /// <summary>
        /// Determines whether the content type is valid for the main part of the package.
        /// </summary>
        /// <param name="contentType">The content type.</param>
        /// <returns>Returns true if the content type is valid.</returns>
        internal bool IsValidMainPartContentType(string contentType)
        {
            return ValidMainPartContentTypes.Contains(contentType);
        }

        /// <summary>
        /// Changes the type of the document.
        /// </summary>
        /// <typeparam name="T">The type of the document's main part.</typeparam>
        /// <remarks>The MainDocumentPart will be changed.</remarks>
        internal void ChangeDocumentTypeInternal<T>() where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            T mainPart = GetSubPartOfType<T>();
            MemoryStream memoryStream = null;
            ExtendedPart tempPart = null;
            Dictionary<string, OpenXmlPart> childParts = new Dictionary<string, OpenXmlPart>();
            ReferenceRelationship[] referenceRelationships;

            try
            {
                // read the content to local string
                using (Stream mainPartStream = mainPart.GetStream())
                {
                    if (mainPartStream.Length > int.MaxValue)
                    {
                        throw new OpenXmlPackageException(ExceptionMessages.DocumentTooBig);
                    }

                    memoryStream = new MemoryStream(Convert.ToInt32(mainPartStream.Length));
                    mainPartStream.CopyTo(memoryStream);
                }

                tempPart = AddExtendedPart(@"http://temp", MainPartContentType, @".xml");

                foreach (KeyValuePair<string, OpenXmlPart> idPartPair in mainPart.ChildrenRelationshipParts)
                {
                    childParts.Add(idPartPair.Key, idPartPair.Value);
                }

                referenceRelationships = mainPart.ReferenceRelationshipList.ToArray();
            }
            catch (OpenXmlPackageException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, e);
            }
#if FEATURE_SYSTEMEXCEPTION
            catch (SystemException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, e);
            }
#endif

            try
            {
                Uri uri = mainPart.Uri;
                string id = GetIdOfPart(mainPart);

                // remove the old part
                ChildrenRelationshipParts.Remove(id);
                DeleteRelationship(id);
                mainPart.Destroy();

                // create new part
                T newMainPart = PartActivator.CreateInstance<T>();

                // do not call this.InitPart( ).  copy the code here
                newMainPart.CreateInternal2(this, null, MainPartContentType, uri);

                // add it and get the id
                string relationshipId = AttachChild(newMainPart, id);

                ChildrenRelationshipParts.Add(relationshipId, newMainPart);

                // copy the stream back
                memoryStream.Position = 0;
                newMainPart.FeedData(memoryStream);

                // add back all relationships
                foreach (KeyValuePair<string, OpenXmlPart> idPartPair in childParts)
                {
                    // just call AttachChild( ) is OK. No need to call AddPart( ... )
                    newMainPart.AttachChild(idPartPair.Value, idPartPair.Key);
                    newMainPart.ChildrenRelationshipParts.Add(idPartPair.Key, idPartPair.Value);
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
                DeleteRelationship(id);
                tempPart.Destroy();
            }
            catch (OpenXmlPackageException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, e);
            }
#if FEATURE_SYSTEMEXCEPTION
            catch (SystemException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentTypeSerious, e);
            }
#endif
        }

        #endregion

        #region internal methods

        // internal abstract IExtensionPartFactory ExtensionPartFactory { get; }

        // cannot use generic, at it will emit error
        // Compiler Error CS0310
        // The type 'typename' must have a public parameter less constructor in order to use it as parameter 'parameter' in the generic type or method 'generic'
        internal sealed override OpenXmlPart NewPart(string relationshipType, string contentType)
        {
            ThrowIfObjectDisposed();

            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (PartConstraints.TryGetValue(relationshipType, out var partConstraintRule))
            {
                if (!partConstraintRule.MaxOccursGreatThanOne)
                {
                    if (GetSubPart(relationshipType) != null)
                    {
                        // already have one, cannot add new one.
                        throw new InvalidOperationException();
                    }
                }

                OpenXmlPart child = CreateOpenXmlPart(relationshipType);

                child.CreateInternal(this, null, contentType, null);

                // add it and get the id
                string relationshipId = AttachChild(child);

                ChildrenRelationshipParts.Add(relationshipId, child);

                return child;
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

        internal sealed override OpenXmlPackage InternalOpenXmlPackage
        {
            get { return this; }
        }

        internal sealed override OpenXmlPart ThisOpenXmlPart
        {
            get { return null; }
        }

        // find all reachable parts from the package root, the dictionary also used for cycle reference defense
        internal sealed override void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
        {
            ThrowIfObjectDisposed();

            if (reachableParts == null)
            {
                throw new ArgumentNullException(nameof(reachableParts));
            }

            foreach (OpenXmlPart part in ChildrenRelationshipParts.Values)
            {
                if (!reachableParts.ContainsKey(part))
                {
                    part.FindAllReachableParts(reachableParts);
                }
            }
        }

        internal sealed override void DeleteRelationship(string id)
        {
            ThrowIfObjectDisposed();

            Package.DeleteRelationship(id);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType)
        {
            ThrowIfObjectDisposed();

            return Package.CreateRelationship(targetUri, targetMode, relationshipType);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id)
        {
            ThrowIfObjectDisposed();

            return Package.CreateRelationship(targetUri, targetMode, relationshipType, id);
        }

        // create the metro part in the package with the CompressionOption
        internal PackagePart CreateMetroPart(Uri partUri, string contentType)
        {
            return Package.CreatePart(partUri, contentType, CompressionOption);
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
            if (_dataPartList.Count > 0)
            {
                HashSet<DataPart> dataPartSet = new HashSet<DataPart>();
                foreach (var dataPart in DataParts)
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
                    _dataPartList.Remove(dataPart);
                }
            }
        }

        /// <summary>
        /// Finds the DataPart that has the specified part URI.
        /// </summary>
        /// <param name="partUri">The part URI.</param>
        /// <returns>Returns null if there is no DataPart with the specified URI.</returns>
        internal DataPart FindDataPart(Uri partUri)
        {
            foreach (var dataPart in DataParts)
            {
                if (dataPart.Uri == partUri)
                {
                    return dataPart;
                }
            }

            return null;
        }

        internal DataPart AddDataPartToList(DataPart dataPart)
        {
            _dataPartList.AddLast(dataPart);
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
                    Package.Flush();
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
            return Clone(new MemoryStream(), true, new OpenSettings());
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
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            // Use this OpenXml package's OpenSettings if none are provided.
            // This is more in line with cloning than providing the default
            // OpenSettings, i.e., unless the caller explicitly specifies
            // something, we'll later open the clone with this OpenXml
            // package's OpenSettings.
            if (openSettings == null)
                openSettings = OpenSettings;

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
                using (OpenXmlPackage clone = CreateClone(stream))
                {
                    foreach (var part in Parts)
                        clone.AddPart(part.OpenXmlPart, part.RelationshipId);
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
        public OpenXmlPackage Clone(string path, bool isEditable, OpenSettings openSettings)
        {
            if (path == null)
                throw new ArgumentNullException(nameof(path));

            // Use this OpenXml package's OpenSettings if none are provided.
            // This is more in line with cloning than providing the default
            // OpenSettings, i.e., unless the caller explicitly specifies
            // something, we'll later open the clone with this OpenXml
            // package's OpenSettings.
            if (openSettings == null)
                openSettings = OpenSettings;

            lock (_saveAndCloneLock)
            {
                // Save the contents of all parts and relationships that are contained
                // in the OpenXml package to make sure we clone a consistent state.
                // This will also invoke ThrowIfObjectDisposed(), so we don't need
                // to call it here.
                Save();

                // Use the same approach as for the streams-based cloning, i.e., close
                // and reopen the document.
                using (OpenXmlPackage clone = CreateClone(path))
                {
                    foreach (var part in Parts)
                        clone.AddPart(part.OpenXmlPart, part.RelationshipId);
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
            if (package == null)
                throw new ArgumentNullException(nameof(package));

            // Use this OpenXml package's OpenSettings if none are provided.
            // This is more in line with cloning than providing the default
            // OpenSettings, i.e., unless the caller explicitly specifies
            // something, we'll later open the clone with this OpenXml
            // package's OpenSettings.
            if (openSettings == null)
                openSettings = OpenSettings;

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
                clone.OpenSettings.AutoSave = openSettings.AutoSave;
                clone.OpenSettings.MarkupCompatibilityProcessSettings.ProcessMode = openSettings.MarkupCompatibilityProcessSettings.ProcessMode;
                clone.OpenSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions = openSettings.MarkupCompatibilityProcessSettings.TargetFileFormatVersions;
                clone.MaxCharactersInPart = openSettings.MaxCharactersInPart;

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
    }
}
