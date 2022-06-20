// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Packaging;
using System.Xml;

#if FEATURE_XML_SCHEMA
using System.ComponentModel;
using System.Xml.Schema;
#endif

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an abstract base class for all OpenXml parts.
    /// </summary>
    public abstract class OpenXmlPart : OpenXmlPartContainer
    {
        private const string DefaultTargetExt = ".xml";

        private OpenXmlPackage? _openXmlPackage;
        private PackagePart? _packagePart;
        private Uri? _uri;
        private bool _isLoading;

        /// <summary>
        /// Create an instance of <see cref="OpenXmlPart"/>
        /// </summary>
        protected internal OpenXmlPart()
            : base()
        {
        }

        #region methods for LoadPart(), NewPart( ), AddPartFrom( )

        internal void Load(OpenXmlPackage? openXmlPackage, OpenXmlPart? parent, Uri uriTarget, string id, Dictionary<Uri, OpenXmlPart> loadedParts)
        {
            if (uriTarget is null)
            {
                throw new ArgumentNullException(nameof(uriTarget));
            }

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (openXmlPackage is null && parent is null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }

            if (parent is not null && openXmlPackage is not null &&
                parent.OpenXmlPackage != openXmlPackage)
            {
                throw new ArgumentOutOfRangeException(nameof(parent));
            }

            if (parent is not null && openXmlPackage is null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            _openXmlPackage = openXmlPackage ?? throw new ArgumentNullException(nameof(openXmlPackage));

            Debug.Assert(loadedParts.ContainsKey(uriTarget));

            _uri = uriTarget;

            // TODO: should we delay load?
            var part = openXmlPackage.Package.GetPart(uriTarget);

            _packagePart = part;

            if (IsContentTypeFixed && !IsValidContentType(part))
            {
                var errorMessage = SR.Format(
                    ExceptionMessages.InvalidPartContentType,
                    part.Uri.OriginalString,
                    part.ContentType,
                    ContentType);

                throw new OpenXmlPackageException(errorMessage);
            }

            // add the _uri to be reserved
            openXmlPackage.ReserveUri(ContentType, Uri);

            // load recursively
            var relationshipCollection = new PackagePartRelationshipPropertyCollection(PackagePart, Features.GetNamespaceResolver());
            LoadReferencedPartsAndRelationships(openXmlPackage, this, relationshipCollection, loadedParts);
        }

        // cannot use generic, at it will emit error
        // Compiler Error CS0310
        // The type 'typename' must have a public parameterless constructor in order to use it as parameter 'parameter' in the generic type or method 'generic'
        internal sealed override OpenXmlPart NewPart(string relationshipType, string contentType)
        {
            ThrowIfObjectDisposed();

            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (this.GetPartMetadata().PartConstraints.TryGetValue(relationshipType, out var partConstraintRule))
            {
                if (!partConstraintRule.MaxOccursGreatThanOne)
                {
                    if (GetSubPart(relationshipType) is not null)
                    {
                        // already have one, can not add new one.
                        throw new InvalidOperationException(ExceptionMessages.OnlyOnePartAllowed);
                    }
                }

                OpenXmlPart child = CreateOpenXmlPart(relationshipType);

                child.CreateInternal(OpenXmlPackage, this, contentType, null);

                // add it and get the id
                string relationshipId = AttachChild(child);

                ChildrenRelationshipParts.Add(relationshipId, child);

                return child;
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }

        // get app specific TargetPath if exists
        private string? GetTargetPath(OpenXmlPackage package, string? defaultPath)
        {
            if (TargetPathOfWord is not null && package.ApplicationType == ApplicationType.Word)
            {
                return TargetPathOfWord;
            }
            else if (TargetPathOfExcel is not null && package.ApplicationType == ApplicationType.Excel)
            {
                return TargetPathOfExcel;
            }
            else if (TargetPathOfPPT is not null && package.ApplicationType == ApplicationType.PowerPoint)
            {
                return TargetPathOfPPT;
            }
            else
            {
                return defaultPath;
            }
        }

        // create a new part in this package
        internal void CreateInternal(OpenXmlPackage? openXmlPackage, OpenXmlPart? parent, string contentType, string? targetExt)
        {
            // openXmlPackage, parent can not be all null
            if (openXmlPackage is null && parent is null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }

            if (parent is not null && openXmlPackage is not null && parent.OpenXmlPackage != openXmlPackage)
            {
                throw new ArgumentOutOfRangeException(nameof(parent));
            }

            if (parent is not null && openXmlPackage is null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            // throw exception to catch error in our code
            if (_packagePart is not null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            _openXmlPackage = openXmlPackage ?? throw new InvalidOperationException();

            Uri parentUri = parent is not null ? parent.Uri : new Uri("/", UriKind.Relative);

            // OpenXmlPart parentPart = this._ownerPart;

            // Uri is auto generated to make sure it's unique
            var targetPath = GetTargetPath(openXmlPackage, TargetPath) ?? ".";

            string? targetFileExt = targetExt;

            if (!IsContentTypeFixed)
            {
                if (!openXmlPackage.PartExtensionProvider.TryGetValue(contentType, out targetFileExt))
                {
                    targetFileExt = targetExt;
                }
            }

            targetFileExt ??= TargetFileExtension;

            _uri = _openXmlPackage.GetUniquePartUri(contentType, parentUri, targetPath, TargetName, targetFileExt);

            _packagePart = _openXmlPackage.CreateMetroPart(_uri, contentType);
        }

        // create a new part in this package
        internal void CreateInternal2(OpenXmlPackage? openXmlPackage, OpenXmlPart? parent, string contentType, Uri partUri)
        {
            // openXmlPackage, parent can not be all null
            if (openXmlPackage is null && parent is null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }
            else if (parent is not null && openXmlPackage is not null && parent.OpenXmlPackage != openXmlPackage)
            {
                throw new ArgumentOutOfRangeException(nameof(parent));
            }
            else if (parent is not null && openXmlPackage is null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            // throw exception to catch error in our code
            if (_packagePart is not null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            _openXmlPackage = openXmlPackage ?? throw new InvalidOperationException();

            Uri parentUri = parent is not null ? parent.Uri : new Uri("/", UriKind.Relative);

            _uri = openXmlPackage.GetUniquePartUri(contentType, parentUri, partUri);

            _packagePart = openXmlPackage.CreateMetroPart(_uri, contentType);
        }

        #endregion

        #region public properties

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

                Debug.Assert(_uri.OriginalString.Equals(_packagePart.Uri.OriginalString, StringComparison.OrdinalIgnoreCase));

                return _uri;
            }
        }

        #endregion

        #region public methods

        /// <summary>
        /// Enumerates all parents that reference this part anywhere in the document.
        /// </summary>
        public IEnumerable<OpenXmlPart> GetParentParts()
        {
            ThrowIfObjectDisposed();

            Dictionary<OpenXmlPart, bool> liveParts = new();

            OpenXmlPackage.FindAllReachableParts(liveParts);

            foreach (OpenXmlPart part in liveParts.Keys)
            {
                if (part.IsChildPart(this))
                {
                    yield return part;
                }
            }
        }

        /// <summary>
        /// Returns the part content data stream.
        /// </summary>
        /// <returns>The content data stream for the part. </returns>
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
        /// Returns the part content stream that was opened using a specified FileMode and FileAccess.
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
        /// <exception cref="ArgumentNullException">Thrown when "sourceStream" is a null reference.</exception>
        public void FeedData(Stream sourceStream)
        {
            ThrowIfObjectDisposed();

            if (sourceStream is null)
            {
                throw new ArgumentNullException(nameof(sourceStream));
            }

            using Stream targetStream = GetStream(FileMode.Create);
            sourceStream.CopyTo(targetStream);
        }

        /// <summary>
        /// Unloads the RootElement.
        /// </summary>
        /// <returns>The unloaded RootElement</returns>
        /// <remarks>
        /// Releases the DOM so the memory can be GC'ed.
        /// </remarks>
        public OpenXmlPartRootElement? UnloadRootElement()
        {
            var rootElement = InternalRootElement;
            if (InternalRootElement is not null)
            {
                InternalRootElement = null;
            }

            return rootElement;
        }

        #endregion

        #region public virtual methods / properties

        /// <summary>
        /// Gets the content type (MIME type) of the content data in the part.
        /// </summary>
        public virtual string ContentType
        {
            get
            {
                ThrowIfObjectDisposed();
                return PackagePart.ContentType;
            }
        }

        /// <summary>
        /// Gets the relationship type of the part.
        /// </summary>
        public abstract string RelationshipType { get; }

#if FEATURE_XML_SCHEMA
        /// <summary>
        /// Validates the XML content of the part by using the specified schema.
        /// </summary>
        /// <param name="schemas">The set of XML schemas to be used.</param>
        /// <param name="validationEventHandler">ValidationEventHandler for validation events.</param>
        [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ValidateXml(XmlSchemaSet schemas, ValidationEventHandler validationEventHandler)
        {
            ThrowIfObjectDisposed();

            if (schemas is null)
            {
                throw new ArgumentNullException(nameof(schemas));
            }

            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings
            {
#if FEATURE_XML_PROHIBIT_DTD
                ProhibitDtd = true,
#else
                DtdProcessing = DtdProcessing.Prohibit,
#endif
                MaxCharactersInDocument = MaxCharactersInPart,
                Schemas = schemas,
                ValidationType = ValidationType.Schema,
            };

            using (var partStream = GetStream())
            {
                xmlReaderSettings.ValidationEventHandler += validationEventHandler;

                using (var xmlReader = XmlConvertingReaderFactory.Create(partStream, Features.GetNamespaceResolver(), xmlReaderSettings))
                {
                    // Validate XML data
                    while (xmlReader.Read())
                    {
                    }
                }
            }
        }

        /// <summary>
        /// Validates the XML content of the part by using the specified schema.
        /// </summary>
        /// <param name="schemaFile">The XML schema to be used.</param>
        /// <param name="validationEventHandler">ValidationEventHandler for validation events.</param>
        [Obsolete(ObsoleteAttributeMessages.ObsoleteV1ValidationFunctionality, false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ValidateXml(string schemaFile, ValidationEventHandler validationEventHandler)
        {
            ThrowIfObjectDisposed();

            if (schemaFile is null)
            {
                throw new ArgumentNullException(nameof(schemaFile));
            }

            XmlSchemaSet schemas = new();
            schemas.Add(null, schemaFile);

            ValidateXml(schemas, validationEventHandler);
        }
#endif

        /// <summary>
        /// Gets the root element of the current part.
        /// Returns null when the current part is empty or is not an XML content type.
        /// </summary>
        public OpenXmlPartRootElement? RootElement => PartRootElement;

        #endregion

        #region internal properties

        /// <summary>
        /// Gets the internal metro PackagePart element.
        /// </summary>
        internal PackagePart PackagePart
        {
            get
            {
                ThrowIfObjectDisposed();
                return _packagePart;
            }
        }

        ///// <summary>
        ///// Gets the parent part of the current part.
        ///// </summary>
        // internal OpenXmlPart ParentPart
        // {
        //    get
        //    {
        //        ThrowIfObjectDisposed();
        //        return this._ownerPart;
        //    }
        // }

        /// <summary>
        /// Gets a value that indicates the maximum allowable number of characters in an Open XML part. A zero (0) value specifies that the part can have an unlimited number of characters. A non-zero value specifies the maximum allowable number of characters in the part.
        /// </summary>
        /// <remarks>
        /// This property allows you to mitigate denial of service attacks where the attacker submits package with extremely large Opexn XML part. By limiting the size of a part, you can detect the attack and recover reliably.
        /// </remarks>
        internal long MaxCharactersInPart
        {
            get
            {
                ThrowIfObjectDisposed();
                return OpenXmlPackage.MaxCharactersInPart;
            }
        }

        #endregion

        #region internal virtual methods / properties

        /// <summary>
        /// Gets a value indicating whether the ContentType for the current part is fixed.
        /// </summary>
        internal bool IsContentTypeFixed => this is IFixedContentTypePart;

        /// <summary>
        /// Determines if the content type agrees with this part's constraints.
        /// </summary>
        /// <param name="part"></param>
        /// <returns>True if the content type is valid for this part. False otherwise.</returns>
        private protected virtual bool IsValidContentType(PackagePart part)
        {
            return part.ContentType == ContentType;
        }

        // find all reachable parts from the package root, the dictionary also used for cycle reference defense
        internal sealed override void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
        {
            ThrowIfObjectDisposed();

            if (reachableParts is null)
            {
                throw new ArgumentNullException(nameof(reachableParts));
            }

            reachableParts.Add(this, false);
            foreach (OpenXmlPart part in ChildrenRelationshipParts.Values)
            {
                if (!reachableParts.ContainsKey(part))
                {
                    part.FindAllReachableParts(reachableParts);
                }
            }
        }

        /// <summary>
        /// Gets the internal path to be used for the part name.
        /// </summary>
        internal virtual string? TargetPath => null;

        /// <summary>
        /// Gets the internal path (Word specific TargetPath) to be used for the part name.
        /// </summary>
        internal virtual string? TargetPathOfWord => null;

        /// <summary>
        /// Gets the internal path (Excel specific TargetPath) to be used for the part name.
        /// </summary>
        internal virtual string? TargetPathOfExcel => null;

        /// <summary>
        /// Gets the internal path (PPT specific TargetPath) to be used for the part name.
        /// </summary>
        internal virtual string? TargetPathOfPPT => null;

        /// <summary>
        /// Gets the file base name to be used for the part name in the package.
        /// </summary>
        internal abstract string TargetName { get; }

        /// <summary>
        /// Gets the file extension to be used for the part in the package.
        /// </summary>
        internal virtual string TargetFileExtension
        {
            get { return DefaultTargetExt; }
        }

        /// <summary>
        /// Gets or sets the root element field.
        /// </summary>
        /// <exception cref="InvalidOperationException">If the part does not have root element defined.</exception>
        private protected virtual OpenXmlPartRootElement? InternalRootElement
        {
            get { return null; }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets the root element of the current part.
        /// </summary>
        /// <remarks>Returns null if the part is not a defined XML part.</remarks>
        internal virtual OpenXmlPartRootElement? PartRootElement
        {
            get { return null; }
        }

        /// <summary>
        /// Indicates whether the current part is available in a specific version of an Office Application.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Returns true if the part is defined in the specified version.</returns>
        internal virtual bool IsInVersion(FileFormatVersions version)
        {
            return true;
        }

        #endregion

        #region internal methods

        /// <summary>
        /// Gets a value indicating whether the root element is loaded from the part or it has been set.
        /// </summary>
        [MemberNotNullWhen(true, nameof(RootElement))]
        public bool IsRootElementLoaded => InternalRootElement is not null;

        /// <summary>
        /// Load the DOM tree. And associate the DOM tree with this part.
        /// Only used for generated part classes which derive from this OpenXmlBasePart.
        /// </summary>
        /// <typeparam name="T">The type of the part's root element.</typeparam>
        /// <remarks>
        /// The ._rootElement will be assigned if the DOM is loaded.
        /// </remarks>
        internal void LoadDomTree<T>()
            where T : OpenXmlPartRootElement, new()
        {
            if (_isLoading)
            {
                throw new InvalidOperationException(ExceptionMessages.UnexpectedReentrancy);
            }

            _isLoading = true;

            Debug.Assert(InternalRootElement is null);

            try
            {
                var events = Features.Get<IPartRootEventsFeature>();
                events?.OnChange(EventType.Creating, this);

                using (Stream stream = GetStream(FileMode.OpenOrCreate, FileAccess.Read))
                {
                    if (stream.Length < 4)
                    {
                        // The OpenXmlPartRootElement.LoadFromPart() method requires at least four
                        // bytes from the data stream. The shortest well-formed XML document would
                        // be something like "<a/>".
                        return;
                    }

                    try
                    {
                        // Set OpenXmlPart before loading from part to be able to access
                        // OpenXmlPart and OpenXmlPackage while loading. If the OpenXmlPart
                        // property is set by the OpenXmlPartRootElement.LoadFromPart() method,
                        // OpenXmlReaderWriterTest.bug247883() unit test fails.
                        var rootElement = new T { OpenXmlPart = this };

                        if (rootElement.LoadFromPart(this, stream))
                        {
                            // associate the root element with this part.
                            InternalRootElement = rootElement;
                            events?.OnChange(EventType.Created, this);
                        }
                    }
                    catch (InvalidDataException e)
                    {
                        throw new InvalidDataException(ExceptionMessages.CannotLoadRootElement, e);
                    }
                }
            }
            finally
            {
                _isLoading = false;
            }
        }

        /// <summary>
        /// Set the RootElement to be the given partRootElement.
        /// Only used for generated part classes which derive from this OpenXmlBasePart.
        /// </summary>
        /// <param name="partRootElement">The given partRootElement. Can be null.</param>
        /// <exception cref="ArgumentException">Thrown when the part's root element has already be associated with another OpenXmlPart.</exception>
        internal void SetDomTree(OpenXmlPartRootElement partRootElement)
        {
            if (partRootElement.OpenXmlPart is not null)
            {
                throw new ArgumentException(ExceptionMessages.PartRootAlreadyHasAssociation, nameof(partRootElement));
            }

            var events = Features.Get<IPartRootEventsFeature>();
            events?.OnChange(EventType.Creating, this);

            partRootElement.OpenXmlPart = this;

            if (InternalRootElement?.OpenXmlPart is OpenXmlPart currentPart)
            {
                var otherEvents = currentPart.Features.Get<IPartRootEventsFeature>();
                otherEvents?.OnChange(EventType.Removing, currentPart);

                // clear the association from the previous root element.
                InternalRootElement.OpenXmlPart = null;

                otherEvents?.OnChange(EventType.Removed, currentPart);
            }

            InternalRootElement = partRootElement;
            events?.OnChange(EventType.Created, this);
        }

        // destroy itself (aka. dispose)
        internal void Destroy()
        {
            OpenXmlPackage.Package.DeletePart(Uri);

            ChildrenRelationshipParts.Clear();
            ReferenceRelationshipList.Clear();
            _openXmlPackage = null;
            _packagePart = null;
            _uri = null;

            // this._ownerPart = null;
            if (InternalRootElement is not null)
            {
                InternalRootElement.OpenXmlPart = null;
                InternalRootElement = null;
            }
        }

        #endregion

        #region protected methods

        /// <summary>
        /// Indicates whether the object is already disposed.
        /// </summary>
        [MemberNotNull(nameof(_openXmlPackage))]
        [MemberNotNull(nameof(_packagePart))]
        [MemberNotNull(nameof(_uri))]
        protected sealed override void ThrowIfObjectDisposed()
        {
            if (_openXmlPackage is null || _packagePart is null || _uri is null)
            {
                throw new InvalidOperationException(ExceptionMessages.PartIsDestroyed);
            }
        }

        internal sealed override OpenXmlPackage InternalOpenXmlPackage
        {
            get
            {
                ThrowIfObjectDisposed();
                return _openXmlPackage;
            }
        }

        internal sealed override OpenXmlPart ThisOpenXmlPart
        {
            get { return this; }
        }

        internal sealed override void DeleteRelationship(string id)
        {
            ThrowIfObjectDisposed();

            PackagePart.DeleteRelationship(id);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType)
        {
            ThrowIfObjectDisposed();

            return _packagePart.CreateRelationship(targetUri, targetMode, relationshipType);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id)
        {
            ThrowIfObjectDisposed();

            return _packagePart.CreateRelationship(targetUri, targetMode, relationshipType, id);
        }

        #endregion

        /// <inheritdoc/>
        public override IFeatureCollection Features
        {
            get
            {
                if (_features is null)
                {
                    if (_openXmlPackage is { } package)
                    {
                        _features = package.CreatePartFeatures(package.Features);
                    }
                    else
                    {
                        _features = CreatePartFeatures();
                    }

                    // Make writeable
                    _features = new FeatureCollection(_features);
                }

                return _features;
            }
        }

        #region MC Staffs

        internal MarkupCompatibilityProcessSettings? MCSettings { get; set; }

        #endregion
    }
}
