// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using System.IO.Packaging;
using System.Runtime.Serialization;
using System.Globalization;
using DocumentFormat.OpenXml;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    internal struct RelationshipProperty
    {
        internal string Id;
        internal string RelationshipType;
        internal TargetMode TargetMode;
        internal Uri TargetUri;
    };

    /// <summary>
    /// Defines the base class for PackageRelationshipPropertyCollection and PackagePartRelationshipPropertyCollection objects.
    /// </summary>
    abstract internal class RelationshipCollection : CollectionBase
    {
        protected PackageRelationshipCollection BasePackageRelationshipCollection { get; set; }

        private bool _strictTranslation = false;
        internal bool StrictTranslation
        {
            get
            {
               return this._strictTranslation;
            }
            set
            {
               this._strictTranslation = value;
            }
        }

        /// <summary>
        /// Gets or sets the relationship properties of the element at the specified index in the collection.
        /// </summary>
        public RelationshipProperty this[int index]
        {
            get
            {
                return (RelationshipProperty)this.List[index];
            }
            set
            {
                this.List[index] = value;
            }
        }

        /// <summary>
        /// Adds the specified relationship properties to the collection.
        /// </summary>
        public int Add(RelationshipProperty value)
        {
            return this.List.Add(value);
        }

        /// <summary>
        /// Gets the index of the specified relationship properties in the collection.
        /// </summary>
        public int IndexOf(RelationshipProperty value)
        {
            return this.List.IndexOf(value);
        }

        /// <summary>
        /// Inserts the specified relationship properties at the specified index in the collection.
        /// </summary>
        public void Insert(int index, RelationshipProperty value)
        {
            this.List.Insert(index, value);
        }

        /// <summary>
        /// Removes the specified relationship properties from the collection.
        /// </summary>
        public void Remove(RelationshipProperty value)
        {
            this.List.Remove(value);
        }

        /// <summary>
        /// Gets a value that indicates whether the collection contains the specified relationship properties.
        /// </summary>
        public bool Contains(RelationshipProperty value)
        {
            return this.List.Contains(value);
        }

        /// <summary>
        /// This method fills the collection with PackageRels from the PackageRelationshipCollection that is given in the sub class.
        /// </summary>
        protected void Build()
        {
            foreach (PackageRelationship relationship in this.BasePackageRelationshipCollection)
            {
                bool found;
                string transitionalNamespace;
                RelationshipProperty relationshipProperty;

                relationshipProperty.TargetUri = relationship.TargetUri;
                relationshipProperty.TargetMode = relationship.TargetMode;
                relationshipProperty.Id = relationship.Id;
                relationshipProperty.RelationshipType = relationship.RelationshipType;

                // If packageRel.RelationshipType is something for Strict, it tries to get the equivalent in Transitional.
                found = NamespaceIdMap.TryGetTransitionalRelationship(relationshipProperty.RelationshipType, out transitionalNamespace);
                if (found)
                {
                    relationshipProperty.RelationshipType = transitionalNamespace;
                    this.StrictTranslation = true;
                }

                this.Add(relationshipProperty);
            }
        }

        internal void UpdateRelationshipTypesInPackage()
        {
            // Update the relationshipTypes when editable.
            if (this.GetPackage().FileOpenAccess != FileAccess.Read)
            {
                for (int index = 0; index < this.Count; index++)
                {
                    RelationshipProperty relationshipProperty = this[index];
                    this.ReplaceRelationship(relationshipProperty.TargetUri, relationshipProperty.TargetMode, relationshipProperty.RelationshipType, relationshipProperty.Id);
                }
            }
        }

        abstract internal void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId);
        abstract internal Package GetPackage();
    }

    /// <summary>
    /// Represents a collection of relationships that are obtained from the package.
    /// </summary>
    internal class PackageRelationshipPropertyCollection : RelationshipCollection
    {
        public Package BasePackage { get; set; }

        public PackageRelationshipPropertyCollection(Package package)
        {
            this.BasePackage = package;
            if (this.BasePackage == null)
            {
                throw new ArgumentNullException("BasePackage");
            }

            this.BasePackageRelationshipCollection = this.BasePackage.GetRelationships();
            this.Build();
        }

        internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            this.BasePackage.DeleteRelationship(strId);
            this.BasePackage.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        internal override Package GetPackage()
        {
            return this.BasePackage;
        }
    }

    /// <summary>
    /// Represents a collection of relationships that are obtained from the package part.
    /// </summary>
    internal class PackagePartRelationshipPropertyCollection : RelationshipCollection
    {
        public PackagePart BasePackagePart { get; set; }

        public PackagePartRelationshipPropertyCollection(PackagePart packagePart)
        {
            this.BasePackagePart = packagePart;
            if (this.BasePackagePart == null)
            {
                throw new ArgumentNullException("BasePackagePart");
            }

            this.BasePackageRelationshipCollection = this.BasePackagePart.GetRelationships();
            this.Build();
        }

        internal override void ReplaceRelationship(Uri targetUri, TargetMode targetMode, string strRelationshipType, string strId)
        {
            this.BasePackagePart.DeleteRelationship(strId);
            this.BasePackagePart.CreateRelationship(targetUri, targetMode, strRelationshipType, strId);
        }

        internal override Package GetPackage()
        {
            return this.BasePackagePart.Package;
        }
    }

    /// <summary>
    /// Represents a base class for strong typed Open XML document classes.
    /// </summary>
    public abstract class OpenXmlPackage : OpenXmlPartContainer, IDisposable
    {
        #region private data members

        //internal object _lock = new object( );
        private bool _disposed;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Package _metroPackage;

        private FileAccess _accessMode;

        private string _mainPartContentType;

        // compression level for content that is stored in a PackagePart. 
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CompressionOption _compressionOption = CompressionOption.Normal;

        private PartUriHelper _partUriHelper = new PartUriHelper();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PartExtensionProvider _partExtensionProvider = new PartExtensionProvider();

        private LinkedList<DataPart> _dataPartList = new LinkedList<DataPart>();

        #endregion

        internal OpenSettings OpenSettings { get; set; }

        private bool _strictTranslation = false;
        internal bool StrictTranslation
        {
            get
            {
                return this._strictTranslation;
            }
            set
            {
                this._strictTranslation = value;
            }
        }

        #region internal constructors

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
        /// <exception cref="IOException">Thrown when package is not opened with read access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        internal void OpenCore(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            if (package.FileOpenAccess == FileAccess.Write)
            {
                // TODO: move this line to derived class
                throw new IOException(ExceptionMessages.PackageMustCanBeRead);
            }

            this._accessMode = package.FileOpenAccess;
            this._metroPackage = package;

            this.Load();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class with access to a specified Open XML package. 
        /// </summary>
        /// <param name="package">The target package for the OpenXmlPackage class.</param>
        /// <exception cref="ArgumentNullException">Thrown when package is a null reference.</exception>
        /// <exception cref="IOException">Thrown when package is not opened with write access.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when the package is not a valid Open XML document.</exception>
        internal void CreateCore(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            //if (package.FileOpenAccess != FileAccess.Write)
            //{
            //    // TODO: move this line to derived class
            //    throw new IOException(ExceptionMessages.PackageAccessModeShouldBeWrite);
            //}

            this._accessMode = package.FileOpenAccess;
            this._metroPackage = package;
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False indicates read-only mode.</param>
        /// <exception cref="IOException">Thrown when the specified stream is write-only. The package to open requires read or read/write permission.</exception>
        internal void OpenCore(Stream stream, bool readWriteMode)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            if (readWriteMode)
            {
                this._accessMode = FileAccess.ReadWrite;
            }
            else
            {
                this._accessMode = FileAccess.Read;
            }

            this._metroPackage = Package.Open(stream, (this._accessMode == FileAccess.Read) ? FileMode.Open : FileMode.OpenOrCreate, this._accessMode);

            this.Load();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied I/O stream class.
        /// </summary>
        /// <param name="stream">The I/O stream on which to open the package.</param>
        /// <exception cref="IOException">Thrown when the specified stream is read-only. The package to open requires write or read/write permission. </exception>
        internal void CreateCore(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            if (!stream.CanWrite)
            {
                throw new OpenXmlPackageException(ExceptionMessages.StreamAccessModeShouldBeWrite);
            }

            this._accessMode = FileAccess.ReadWrite;
            //this._accessMode = FileAccess.Write;
            // below line will exception by Package. Packaging API bug?
            // this._metroPackage = Package.Open(stream, FileMode.Create, packageAccess);
            this._metroPackage = Package.Open(stream, FileMode.Create, FileAccess.ReadWrite);
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the specified file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        /// <param name="readWriteMode">Indicates whether or not the package is in read/write mode. False for read only mode.</param>
        internal void OpenCore(string path, bool readWriteMode)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            if (readWriteMode)
            {
                this._accessMode = FileAccess.ReadWrite;
            }
            else
            {
                this._accessMode = FileAccess.Read;
            }

            this._metroPackage = Package.Open(path, (this._accessMode == FileAccess.Read) ? FileMode.Open : FileMode.OpenOrCreate, this._accessMode, (this._accessMode == FileAccess.Read) ? FileShare.Read : FileShare.None);

            this.Load();
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackage class using the supplied file.
        /// </summary>
        /// <param name="path">The path and file name of the target package for the OpenXmlPackage.</param>
        internal void CreateCore(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            this._accessMode = FileAccess.ReadWrite;
            //this._accessMode = FileAccess.Write;
            // below line will exception by Package. Packaging API bug?
            // this._metroPackage = Package.Open(path, FileMode.Create, packageAccess, FileShare.None);
            this._metroPackage = Package.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
        }

        /// <summary>
        /// Loads the package. This method must be called in the constructor of a derived class.
        /// </summary>
        private void Load()
        {
            Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPackage_Load_In);

            try
            {
                Dictionary<Uri, OpenXmlPart> loadedParts = new Dictionary<Uri, OpenXmlPart>();

                bool hasMainPart = false;
                RelationshipCollection relationshipCollection = new PackageRelationshipPropertyCollection(this._metroPackage);

                // relationCollection.StrictTranslation is true when this collection contains Transitional relationships converted from Strict.
                this.StrictTranslation = relationshipCollection.StrictTranslation;

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
                    if (relationship.RelationshipType == this.MainPartRelationshipType)
                    {
                        hasMainPart = true;

                        Uri uriTarget = PackUriHelper.ResolvePartUri(new Uri("/", UriKind.Relative), relationship.TargetUri);
                        PackagePart metroPart = this.Package.GetPart(uriTarget);

                        if (!this.IsValidMainPartContentType(metroPart.ContentType))
                        {
                            OpenXmlPackageException exception = new OpenXmlPackageException(ExceptionMessages.InvalidPackageType);
                            throw exception;
                        }

                        this.MainPartContentType = metroPart.ContentType;
                        break;
                    }
                }

                if (!hasMainPart)
                {
                    // throw exception is the package do not have the main part (MainDocument / Workbook / Presentation part)
                    OpenXmlPackageException exception = new OpenXmlPackageException(ExceptionMessages.NoMainPart);
                    throw exception;
                }

                this.LoadReferencedPartsAndRelationships(this, null, relationshipCollection, loadedParts);
            }
            catch (OpenXmlPackageException)
            {
                // invalid part ( content type is not expected )
                this.Close();
                throw;
            }
            catch (System.UriFormatException)
            {
                // UriFormatException is replaced here with OpenXmlPackageException. <O15:#322821>
                OpenXmlPackageException exception = new OpenXmlPackageException(ExceptionMessages.InvalidUriFormat);
                this.Close();
                throw exception;
            }
            catch (Exception)
            {
                this.Close();
                throw;
            }

            Profiler.CommentMarkProfile(Profiler.MarkId.OpenXmlPackage_Load_Out);
        }

        #endregion

        #region public properties

        /// <summary>
        /// Gets the package of the document.
        /// </summary>
        public Package Package
        {
            get
            {
                this.ThrowIfObjectDisposed();
                return _metroPackage;
            }
        }

        /// <summary>
        /// Gets the FileAccess setting for the document. 
        /// The current I/O access settings are: Read, Write, or ReadWrite. 
        /// </summary>
        public FileAccess FileOpenAccess
        {
            get { return this._metroPackage.FileOpenAccess; }
        }

        /// <summary>
        /// Gets or sets the compression level for the content of the new part. 
        /// </summary>
        public CompressionOption CompressionOption
        {
            get { return this._compressionOption; }
            set { this._compressionOption = value; }
        }

        /// <summary>
        /// Gets the core package properties of the Open XML document.
        /// </summary>
        public PackageProperties PackageProperties
        {
            get
            {
                this.ThrowIfObjectDisposed();
                return this.Package.PackageProperties;
            }
        }

        /// <summary>
        /// Gets a PartExtensionProvider part which provides a mapping from ContentType to part extension.
        /// </summary>
        public PartExtensionProvider PartExtensionProvider
        {
            get
            {
                this.ThrowIfObjectDisposed();
                return this._partExtensionProvider;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates the maximum allowable number of characters in an Open XML part. A zero (0) value indicates that there are no limits on the size of the part. A non-zero value specifies the maximum size, in characters.
        /// </summary>
        /// <remarks>
        /// This property allows you to mitigate denial of service attacks where the attacker submits a package with an extremely large Open XML part. By limiting the size of a part, you can detect the attack and recover reliably.
        /// </remarks>
        public long MaxCharactersInPart
        {
            get;
            internal set;
        }

        /// <summary>
        /// Enumerates all the <see cref="DataPart"/> parts in the document package.
        /// </summary>
        public IEnumerable<DataPart> DataParts
        {
            get
            {
                return this._dataPartList;
            }
        }

        #endregion

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
            this.ThrowIfObjectDisposed();

            if (part == null)
            {
                throw new ArgumentNullException("part");
            }

            if (part.RelationshipType == this.MainPartRelationshipType &&
                part.ContentType != this.MainPartContentType)
            {
                throw new ArgumentOutOfRangeException(ExceptionMessages.MainPartIsDifferent);
            }

            return (T)AddPartFrom(part, null);
        }

        /// <summary>
        /// Deletes all the parts with the specified part type from the package recursively.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public void DeletePartsRecursivelyOfType<T>() where T : OpenXmlPart
        {
            this.ThrowIfObjectDisposed();
            DeletePartsRecursivelyOfTypeBase<T>();
        }

        // Remove this method due to bug #18394
        // User can call doc.Package.Flush( ) as a workaround.
        ///// <summary>
        ///// Saves the contents of all parts and relationships that are contained in the OpenXml package. 
        ///// </summary>
        //public void Save()
        //{
        //    this.ThrowIfObjectDisposed();
        //    this.Package.Flush();
        //}

        /// <summary>
        /// Saves and closes the OpenXml package and all underlying part streams.  
        /// </summary>
        public void Close()
        {
            this.ThrowIfObjectDisposed();
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
                throw new ArgumentNullException("contentType");
            }

            MediaDataPart mediaDataPart = new MediaDataPart();

            mediaDataPart.CreateInternal(this.InternalOpenXmlPackage, contentType, null);

            this._dataPartList.AddLast(mediaDataPart);

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
                throw new ArgumentNullException("contentType");
            }

            if (extension == null)
            {
                throw new ArgumentNullException("extension");
            }

            MediaDataPart mediaDataPart = new MediaDataPart();

            mediaDataPart.CreateInternal(this.InternalOpenXmlPackage, contentType, extension);

            this._dataPartList.AddLast(mediaDataPart);

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

            mediaDataPart.CreateInternal(this.InternalOpenXmlPackage, mediaDataPartType);

            this._dataPartList.AddLast(mediaDataPart);

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
                throw new ArgumentNullException("dataPart");
            }

            if (dataPart.OpenXmlPackage != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignDataPart);
            }

            if (IsOrphanDataPart(dataPart))
            {
                // delete the part from the package
                dataPart.Destroy();
                return this._dataPartList.Remove(dataPart);
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
            this.ThrowIfObjectDisposed();

            OpenXmlPackageValidationSettings actualValidationSettings;

            if (validationSettings != null && validationSettings.GetEventHandler() != null)
            {
                actualValidationSettings = validationSettings;
            }
            else
            {
                // use default DefaultValidationEventHandler( ) which throw an exception
                actualValidationSettings = new OpenXmlPackageValidationSettings();
                actualValidationSettings.EventHandler += new EventHandler<OpenXmlPackageValidationEventArgs>(DefaultValidationEventHandler);
            }

            // TODO: what's expected behavior?
            actualValidationSettings.FileFormat = FileFormatVersions.Office2007;

            // for cycle defense
            Dictionary<OpenXmlPart, bool> processedParts = new Dictionary<OpenXmlPart, bool>();

            ValidateInternal(actualValidationSettings, processedParts);
        }

#pragma warning disable 0618 // CS0618: A class member was marked with the Obsolete attribute, such that a warning will be issued when the class member is referenced.

        /// <summary>
        /// Validates the package. This method does not validate the XML content in each part.
        /// </summary>
        /// <param name="validationSettings">The OpenXmlPackageValidationSettings for validation events.</param>
        /// <param name="fileFormatVersion">The target file format version.</param>
        /// <remarks>If validationSettings is null or no EventHandler is set, the default behavior is to throw an OpenXmlPackageException on the validation error. </remarks>
        internal void Validate(OpenXmlPackageValidationSettings validationSettings, FileFormatVersions fileFormatVersion)
        {
            this.ThrowIfObjectDisposed();
            Debug.Assert(validationSettings != null);
            Debug.Assert(fileFormatVersion == FileFormatVersions.Office2007 || fileFormatVersion == FileFormatVersions.Office2010 || fileFormatVersion == FileFormatVersions.Office2013);

            validationSettings.FileFormat = fileFormatVersion;

            // for cycle defense
            Dictionary<OpenXmlPart, bool> processedParts = new Dictionary<OpenXmlPart, bool>();

            ValidateInternal(validationSettings, processedParts);
        }

        #endregion

        #region virtual methods / properties

        #endregion

        #region internal methods

        /// <summary>
        /// Reserves the URI of the loaded part.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="partUri"></param>
        internal void ReserveUri(string contentType, Uri partUri)
        {
            this.ThrowIfObjectDisposed();

            this._partUriHelper.ReserveUri(contentType, partUri);
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
            this.ThrowIfObjectDisposed();

            Uri partUri = null;

            // fix bug #241492 
            // check to avoid name conflict with orphan parts in the packages. 
            do
            {
                partUri = this._partUriHelper.GetUniquePartUri(contentType, parentUri, targetPath, targetName, targetExt);
            } while (this._metroPackage.PartExists(partUri));

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
            this.ThrowIfObjectDisposed();

            Uri partUri = null;

            // fix bug #241492 
            // check to avoid name conflict with orphan parts in the packages. 
            do
            {
                partUri = this._partUriHelper.GetUniquePartUri(contentType, parentUri, targetUri);
            } while (this._metroPackage.PartExists(partUri));

            return partUri;
        }

        #endregion

        #region dispose related methods

        /// <summary>
        /// Thrown if an object is disposed.
        /// </summary>
        protected override void ThrowIfObjectDisposed()
        {
            if (this._disposed)
            {
                throw new ObjectDisposedException(base.GetType().Name);
            }
        }

        /// <summary>
        /// Flushes and saves the content, closes the document, and releases all resources. 
        /// </summary>
        /// <param name="disposing">Specify true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    // Try to save contents of every part in the package
                    SavePartContents();
                    DeleteUnusedDataPartOnClose();

                    // TODO: Close resources
                    this._metroPackage.Close();
                    this._metroPackage = null;
                    this.PartDictionary = null;
                    this.ReferenceRelationshipList.Clear();
                    this._partUriHelper = null;
                }
                this._disposed = true;
            }
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Flushes and saves the content, closes the document, and releases all resources. 
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
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
        /// Gets a flag that indicates whether the parts should be saved when disposed. 
        /// </summary>
        public bool AutoSave 
        {
            get
            {
                return OpenSettings.AutoSave;
            }
        }

        private void SavePartContents()
        {
            OpenXmlPackagePartIterator iterator;
            bool isAnyPartChanged;

            if (this.FileOpenAccess == FileAccess.Read)
            {
                return; // do nothing if the package is open in read-only mode.
            }

            // When this.StrictTranslation is true, we ignore AutoSave to do the translation if isAnyPartChanged is true. That's the way to keep consistency.
            if (!this.AutoSave && !this.StrictTranslation)
            {
                return; // do nothing if AutoSave is false.
            }

            // Traversal the whole package and save changed contents.
            iterator = new OpenXmlPackagePartIterator(this);
            isAnyPartChanged = false;

            // If a part is in the state of 'loaded', something in the part should've been changed.
            // When all the part is not loaded yet, we can skip saving all parts' contents and updating Package relationship types.
            foreach (var part in iterator)
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
                foreach (var part in iterator)
                {
                    TrySavePartContent(part);
                }

                if (this.StrictTranslation)
                {
                    RelationshipCollection relationshipCollection;

                    // For Package: Invoking UpdateRelationshipTypesInPackage() changes the relationship types in the package.
                    // We need to new PackageRelationshipPropertyCollection to read through the package contents right here 
                    // because some operation may have updated the package before we get here.
                    relationshipCollection = new PackageRelationshipPropertyCollection(this._metroPackage);
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
                if (this.IsValidMainPartContentType(value))
                {
                    this._mainPartContentType = value;
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

            T mainPart = this.GetSubPartOfType<T>();
            MemoryStream memoryStream = null;
            ExtendedPart tempPart = null;
            Dictionary<string, OpenXmlPart> childParts = new Dictionary<string, OpenXmlPart>();
            ReferenceRelationship[] referenceRelationships;

            try
            {
                // read the content to local string 
                using (Stream mainPartStream = mainPart.GetStream())
                {
                    if (mainPartStream.Length > Int32.MaxValue)
                    {
                        throw new OpenXmlPackageException(ExceptionMessages.DocumentTooBig);
                    }
                    memoryStream = new MemoryStream(Convert.ToInt32(mainPartStream.Length));
                    OpenXmlPart.CopyStream(mainPartStream, memoryStream);
                }


                // 
                tempPart = this.AddExtendedPart(@"http://temp", this.MainPartContentType, @".xml");

                foreach (KeyValuePair<string, OpenXmlPart> idPartPair in mainPart.ChildrenParts)
                {
                    childParts.Add(idPartPair.Key, idPartPair.Value);
                }

                referenceRelationships = mainPart.ReferenceRelationshipList.ToArray();
            }
            catch (OpenXmlPackageException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, e);
            }
            catch (SystemException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.CannotChangeDocumentType, e);
            }

            try
            {
                Uri uri = mainPart.Uri;
                string id = this.GetIdOfPart(mainPart);

                // remove the old part
                this.ChildrenParts.Remove(id);
                this.DeleteRelationship(id);
                mainPart.Destroy();

                // create new part
                T newMainPart = (T)Activator.CreateInstance(typeof(T), true);

                // do not call this.InitPart( ).  copy the code here

                newMainPart.CreateInternal2(this, null, this.MainPartContentType, uri);

                // add it and get the id
                string relationshipId = this.AttachChild(newMainPart, id);

                this.ChildrenParts.Add(relationshipId, newMainPart);

                // copy the stream back
                memoryStream.Position = 0;
                newMainPart.FeedData(memoryStream);

                // add back all relationships
                foreach (KeyValuePair<string, OpenXmlPart> idPartPair in childParts)
                {
                    // just call AttachChild( ) is OK. No need to call AddPart( ... )
                    newMainPart.AttachChild(idPartPair.Value, idPartPair.Key);
                    newMainPart.ChildrenParts.Add(idPartPair);
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
                id = this.GetIdOfPart(tempPart);
                this.ChildrenParts.Remove(id);
                this.DeleteRelationship(id);
                tempPart.Destroy();

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

        // internal abstract IExtensionPartFactory ExtensionPartFactory { get; }

        // cannot use generic, at it will emit error
        // Compiler Error CS0310 
        // The type 'typename' must have a public parameter less constructor in order to use it as parameter 'parameter' in the generic type or method 'generic'

        internal sealed override OpenXmlPart NewPart(string relationshipType, string contentType)
        {
            ThrowIfObjectDisposed();

            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }

            PartConstraintRule partConstraintRule;

            if (GetPartConstraint().TryGetValue(relationshipType, out partConstraintRule))
            {
                if (!partConstraintRule.MaxOccursGreatThanOne)
                {
                    if (this.GetSubPart(relationshipType) != null)
                    {
                        // already have one, cannot add new one.
                        throw new InvalidOperationException();
                    }
                }

                OpenXmlPart child = CreateOpenXmlPart(relationshipType);

                child.CreateInternal(this, null, contentType, null);

                // add it and get the id
                string relationshipId = this.AttachChild(child);

                this.ChildrenParts.Add(relationshipId, child);

                return child;
            }
            throw new ArgumentOutOfRangeException("relationshipType");
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
                throw new ArgumentNullException("reachableParts");
            }

            foreach (OpenXmlPart part in this.ChildrenParts.Values)
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

            this.Package.DeleteRelationship(id);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType)
        {
            ThrowIfObjectDisposed();

            return this.Package.CreateRelationship(targetUri, targetMode, relationshipType);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id)
        {
            ThrowIfObjectDisposed();

            return this.Package.CreateRelationship(targetUri, targetMode, relationshipType, id);
        }

        // create the metro part in the package with the CompressionOption
        internal PackagePart CreateMetroPart(Uri partUri, string contentType)
        {
            return this.Package.CreatePart(partUri, contentType, this.CompressionOption);
        }

        // default package validation event handler
        static void DefaultValidationEventHandler(Object sender, OpenXmlPackageValidationEventArgs e)
        {
            OpenXmlPackageException exception = new OpenXmlPackageException(ExceptionMessages.ValidationException);

            exception.Data.Add("OpenXmlPackageValidationEventArgs", e);

            throw exception;
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
            if (this._dataPartList.Count > 0)
            {
                HashSet<DataPart> dataPartSet = new HashSet<DataPart>();
                foreach (var dataPart in this.DataParts)
                {
                    dataPartSet.Add(dataPart);
                }

                // first, see if there are any reference in package level.
                foreach (var dataPartReferenceRelationship in this.DataPartReferenceRelationships)
                {
                    dataPartSet.Remove(dataPartReferenceRelationship.DataPart);
                    if (dataPartSet.Count == 0)
                    {
                        // No more DataPart in the set. All DataParts are referenced somewhere.
                        return;
                    }
                }

                // for each part in the package, check the DataPartReferenceRelationships.
                OpenXmlPackagePartIterator partIterator = new OpenXmlPackagePartIterator(this);
                foreach (var openXmlPart in partIterator)
                {
                    foreach (var dataPartReferenceRelationship in openXmlPart.DataPartReferenceRelationships)
                    {
                        dataPartSet.Remove(dataPartReferenceRelationship.DataPart);
                        if (dataPartSet.Count == 0)
                        {
                            // No more DataPart in the set. All DataParts are referenced somethwherr.
                            return;
                        }
                    }
                }

                // 
                foreach (var dataPart in dataPartSet)
                {
                    // delete the part from the package
                    dataPart.Destroy();
                    this._dataPartList.Remove(dataPart);
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
            foreach (var dataPart in this.DataParts)
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
            this._dataPartList.AddLast(dataPart);
            return dataPart;
        }

        #endregion

        internal class PartUriHelper
        {
            private Dictionary<string, int> _sequenceNumbers = new Dictionary<string, int>(20);
            private Dictionary<string, int> _reservedUri = new Dictionary<string, int>();

            public PartUriHelper()
            {
            }

            private bool IsReservedUri(Uri uri)
            {
                string uriString = uri.OriginalString.ToUpperInvariant();
                return this._reservedUri.ContainsKey(uriString);
            }

            internal void AddToReserveUri(Uri partUri)
            {
                string uriString = partUri.OriginalString.ToUpperInvariant();
                this._reservedUri.Add(uriString, 0);
            }

            internal void ReserveUri(string contentType, Uri partUri)
            {
                GetNextSequenceNumber(contentType);
                this.AddToReserveUri(PackUriHelper.GetNormalizedPartUri(partUri));
            }

            internal Uri GetUniquePartUri(string contentType, Uri parentUri, string targetPath, string targetName, string targetExt)
            {
                Uri partUri;

                do
                {
                    string sequenceNumber = this.GetNextSequenceNumber(contentType);
                    string path = Path.Combine(targetPath, targetName + sequenceNumber + targetExt);



                    Uri uri = new Uri(path, UriKind.RelativeOrAbsolute);
                    partUri = PackUriHelper.ResolvePartUri(parentUri, uri);
                    // partUri = PackUriHelper.GetNormalizedPartUri(PackUriHelper.CreatePartUri(uri));
                } while (this.IsReservedUri(partUri));

                this.AddToReserveUri(partUri);

                // do not need to add to the _existedNames
                return partUri;
            }

            internal Uri GetUniquePartUri(string contentType, Uri parentUri, Uri targetUri)
            {
                Uri partUri;

                partUri = PackUriHelper.ResolvePartUri(parentUri, targetUri);

                if (this.IsReservedUri(partUri))
                {
                    // already have one, create new
                    string targetPath = ".";
                    string targetName = Path.GetFileNameWithoutExtension(targetUri.OriginalString);
                    string targetExt = Path.GetExtension(targetUri.OriginalString);

                    partUri = GetUniquePartUri(contentType, partUri, targetPath, targetName, targetExt);
                }
                else
                {
                    // not used, can use it.
                    this.AddToReserveUri(partUri);
                }

                return partUri;
            }

            private string GetNextSequenceNumber(string contentType)
            {
                if (this._sequenceNumbers.ContainsKey(contentType))
                {
                    this._sequenceNumbers[contentType] += 1;
                    // use the default read-only NumberFormatInfo that is culture-independent (invariant). 
                    // return this._sequenceNumbers[contentType].ToString(NumberFormatInfo.InvariantInfo);

                    // Let's use the number string in hex
                    return Convert.ToString(this._sequenceNumbers[contentType], 16);
                }
                else
                {
                    this._sequenceNumbers.Add(contentType, 1);
                    return "";
                }
            }
        }
    }

    /// <summary>
    /// Specifies event handlers that will handle OpenXmlPackage validation events and the OpenXmlPackageValidationEventArgs. 
    /// </summary>
    [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
    public class OpenXmlPackageValidationSettings
    {
        private EventHandler<OpenXmlPackageValidationEventArgs> valEventHandler;

        /// <summary>
        /// Gets the event handler.
        /// </summary>
        /// <returns></returns>
        internal EventHandler<OpenXmlPackageValidationEventArgs> GetEventHandler()
        {
            return this.valEventHandler;
        }

        /// <summary>
        /// Represents the callback method that will handle OpenXmlPackage validation events and the OpenXmlPackageValidationEventArgs.
        /// </summary>
        public event EventHandler<OpenXmlPackageValidationEventArgs> EventHandler
        {
            add
            {
                this.valEventHandler = (EventHandler<OpenXmlPackageValidationEventArgs>)Delegate.Combine(this.valEventHandler, value);
            }
            remove
            {
                this.valEventHandler = (EventHandler<OpenXmlPackageValidationEventArgs>)Delegate.Remove(this.valEventHandler, value);
            }
        }

        /// <summary>
        /// Gets or sets the file format version that the validation is targeting.
        /// </summary>
        internal FileFormatVersions FileFormat
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Represents the Open XML package validation events.
    /// </summary>
    [SerializableAttribute]
    [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
    public sealed class OpenXmlPackageValidationEventArgs : EventArgs
    {
        private string _message;
        private string _partClassName;

        [NonSerializedAttribute]
        private OpenXmlPart _childPart;

        [NonSerializedAttribute]
        private OpenXmlPart _parentPart;

        internal OpenXmlPackageValidationEventArgs()
        {
        }

        /// <summary>
        /// Gets the message string of the event.
        /// </summary>
        public string Message
        {
            get
            {
                if (this._message == null && this.MessageId != null)
                {
                    return ExceptionMessages.ResourceManager.GetString(this.MessageId);
                }
                else
                {
                    return this._message;
                }
            }
            set
            {
                this._message = value;
            }
        }

        /// <summary>
        /// Gets the class name of the part.
        /// </summary>
        public string PartClassName
        {
            get { return _partClassName; }
            internal set { _partClassName = value; }
        }

        /// <summary>
        /// Gets the part that caused the event.
        /// </summary>
        public OpenXmlPart SubPart
        {
            get { return _childPart; }
            internal set { _childPart = value; }
        }

        /// <summary>
        /// Gets the part in which to process the validation.
        /// </summary>
        public OpenXmlPart Part
        {
            get { return _parentPart; }
            internal set { _parentPart = value; }
        }

        internal string MessageId
        {
            get;
            set;
        }

        /// <summary>
        /// The DataPartReferenceRelationship that caused the event.
        /// </summary>
        internal DataPartReferenceRelationship DataPartReferenceRelationship
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Represents an Open XML package exception class for errors.
    /// </summary>
    [SerializableAttribute]
    public sealed class OpenXmlPackageException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class. 
        /// </summary>
        public OpenXmlPackageException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class using the supplied error message. 
        /// </summary>
        /// <param name="message">The message that describes the error. </param>
        public OpenXmlPackageException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class using the supplied serialized data. 
        /// </summary>
        /// <param name="info">The serialized object data about the exception being thrown.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        private OpenXmlPackageException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPackageException class using the supplied error message and a reference to the inner exception that caused the current exception. 
        /// </summary>
        /// <param name="message">The error message that indicates the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public OpenXmlPackageException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    /// <summary>
    /// Represents the settings when opening a document.
    /// </summary>
    public class OpenSettings
    {
        bool? autoSave;
        MarkupCompatibilityProcessSettings _mcSettings;

        /// <summary>
        /// Gets or sets a value that indicates whether or not to auto save document modifications.
        /// The default value is true.
        /// </summary>
        public bool AutoSave
        {
            get
            {
                if (autoSave == null)
                {
                    return true;
                }
                return (bool)autoSave;
            }
            set
            {
                autoSave = value;
            }
        }

        /// <summary>
        /// Gets or sets the value of the markup compatibility processing mode.
        /// </summary>
        public MarkupCompatibilityProcessSettings MarkupCompatibilityProcessSettings
        {
            get
            {
                if (_mcSettings == null)
                    _mcSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.NoProcess, FileFormatVersions.Office2007);
                return _mcSettings;
            }
            set
            {
                _mcSettings = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates the maximum number of allowable characters in an Open XML part. A zero (0) value indicates that there are no limits on the size of the part. A non-zero value specifies the maximum size, in characters.
        /// </summary>
        /// <remarks>
        /// This property allows you to mitigate denial of service attacks where the attacker submits a package with an extremely large Open XML part. By limiting the size of the part, you can detect the attack and recover reliably.
        /// </remarks>
        public long MaxCharactersInPart { get; set; }
    }

    /// <summary>
    /// Represents markup compatibility processing settings.
    /// </summary>
    public class MarkupCompatibilityProcessSettings
    {
        /// <summary>
        /// Gets the markup compatibility process mode.
        /// </summary>
        public MarkupCompatibilityProcessMode ProcessMode { get; internal set; }

        /// <summary>
        /// Gets the target file format versions.
        /// </summary>
        public FileFormatVersions TargetFileFormatVersions { get; internal set; }

        /// <summary>
        /// Creates a MarkupCompatibilityProcessSettings object using the supplied process mode and file format versions.
        /// </summary>
        /// <param name="processMode">The process mode.</param>
        /// <param name="targetFileFormatVersions">The file format versions. This parameter is ignored if the value is NoProcess.</param>
        public MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode processMode, FileFormatVersions targetFileFormatVersions)
        {
            ProcessMode = processMode;
            TargetFileFormatVersions = targetFileFormatVersions;
        }

        private MarkupCompatibilityProcessSettings()
        {
            ProcessMode = MarkupCompatibilityProcessMode.NoProcess;
            TargetFileFormatVersions = FileFormatVersions.Office2007;
        }
    }

    /// <summary>
    /// Specifies the mode in which to process the markup compatibility tags in the document.
    /// </summary>
    public enum MarkupCompatibilityProcessMode
    {
        /// <summary>
        /// Do not process MarkupCompatibility tags.
        /// </summary>
        NoProcess = 0,

        /// <summary>
        /// Process the loaded parts.
        /// </summary>
        ProcessLoadedPartsOnly,

        /// <summary>
        /// Process all the parts in the package.
        /// </summary>
        ProcessAllParts,
    }

    /// <summary>
    /// Traversal parts in the <see cref="OpenXmlPackage"/> by breadth-first.
    /// </summary>
    internal class OpenXmlPackagePartIterator : IEnumerable<OpenXmlPart>
    {
        private OpenXmlPackage _package;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the OpenXmlPackagePartIterator class using the supplied OpenXmlPackage class.
        /// </summary>
        /// <param name="package">The OpenXmlPackage to use to enumerate parts.</param>
        public OpenXmlPackagePartIterator(OpenXmlPackage package)
        {
            Debug.Assert(package != null);
            this._package = package;
        }

        #endregion

        #region IEnumerable<OpenXmlPart> Members
        /// <summary>
        /// Gets an enumerator for parts in the whole package.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<OpenXmlPart> GetEnumerator()
        {
            return GetPartsByBreadthFirstTraversal();
        }

        // Traverses the parts graph by breath-first
        private IEnumerator<OpenXmlPart> GetPartsByBreadthFirstTraversal()
        {
            Debug.Assert(_package != null);
            var returnedParts = new List<OpenXmlPart>();
            Queue<OpenXmlPart> tmpQueue = new Queue<OpenXmlPart>();

            // Enqueue child parts of the package.
            foreach (var idPartPair in _package.Parts)
            {
                tmpQueue.Enqueue(idPartPair.OpenXmlPart);
            }

            while (tmpQueue.Count > 0)
            {
                var part = tmpQueue.Dequeue();
                returnedParts.Add(part);

                foreach (var subIdPartPair in part.Parts)
                {
                    if (!tmpQueue.Contains(subIdPartPair.OpenXmlPart)
                        && !returnedParts.Contains(subIdPartPair.OpenXmlPart))
                    {
                        tmpQueue.Enqueue(subIdPartPair.OpenXmlPart);
                    }
                }
            }
            return returnedParts.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        /// <summary>
        /// Gets an enumerator for parts in the whole package.
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
