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
    public abstract partial class OpenXmlPart : OpenXmlPartContainer
    {
        private OpenXmlPackage? _openXmlPackage;
        private PackagePart? _packagePart;
        private bool _isLoading;

        /// <summary>
        /// Create an instance of <see cref="OpenXmlPart"/>
        /// </summary>
        protected internal OpenXmlPart()
            : base()
        {
        }

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

            SetPackage(openXmlPackage, parent);

            Debug.Assert(loadedParts.ContainsKey(uriTarget));

            // TODO: should we delay load?
            var part = _openXmlPackage.Package.GetPart(uriTarget);

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
            Features.GetRequired<IPartUriFeature>().ReserveUri(ContentType, Uri);

            // load recursively
            var relationshipCollection = new PackagePartRelationshipPropertyCollection(PackagePart, Features.GetNamespaceResolver());
            LoadReferencedPartsAndRelationships(_openXmlPackage, this, relationshipCollection, loadedParts);
        }

        internal void CreateInternal(OpenXmlPackage? openXmlPackage, OpenXmlPart? parent, string contentType, string? targetExt)
        {
            SetPackage(openXmlPackage, parent);

            Uri parentUri = parent is not null ? parent.Uri : new Uri("/", UriKind.Relative);

            var targets = GetAndVerifyTargetFeature(_openXmlPackage, contentType, targetExt);
            var uri = Features.GetRequired<IPartUriFeature>().CreatePartUri(contentType, parentUri, targets.Path, targets.Name, targets.Extension);

            CreatePart(_openXmlPackage, uri, contentType);
        }

        internal void CreateInternal(OpenXmlPackage? openXmlPackage, OpenXmlPart? parent, string contentType, Uri partUri)
        {
            SetPackage(openXmlPackage, parent);

            var parentUri = parent is not null ? parent.Uri : new Uri("/", UriKind.Relative);
            var uri = _openXmlPackage.Features.GetRequired<IPartUriFeature>().EnsureUniquePartUri(contentType, parentUri, partUri);

            CreatePart(_openXmlPackage, uri, contentType);
        }

        [MemberNotNull(nameof(_packagePart))]
        private void CreatePart(OpenXmlPackage package, Uri uri, string contentType)
        {
            _packagePart = package.CreateMetroPart(uri, contentType);
        }

        [MemberNotNull(nameof(_openXmlPackage))]
        private void SetPackage(OpenXmlPackage? openXmlPackage, OpenXmlPart? parent)
        {
            // throw exception to catch error in our code
            if (_packagePart is not null)
            {
                throw new InvalidOperationException();
            }

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

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            _openXmlPackage = openXmlPackage ?? throw new InvalidOperationException();
        }

        private ITargetFeature GetAndVerifyTargetFeature(OpenXmlPackage openXmlPackage, string contentType, string? targetExt)
        {
            var targets = Features.GetRequired<ITargetFeature>();

            if (!IsContentTypeFixed)
            {
                if (!openXmlPackage.PartExtensionProvider.TryGetValue(contentType, out var found))
                {
                    targetExt = found;
                }

                if (targetExt is not null && targets.Extension != targetExt)
                {
                    var updated = new UpdatedExtensionTargetFeature(targets, targetExt);

                    Features.Set<ITargetFeature>(updated);

                    return updated;
                }
            }

            return targets;
        }

        private sealed class UpdatedExtensionTargetFeature : ITargetFeature
        {
            private readonly ITargetFeature _other;

            public UpdatedExtensionTargetFeature(ITargetFeature other, string extension)
            {
                _other = other;
                Extension = extension;
            }

            public string Path => _other.Path;

            public string Name => _other.Name;

            public string Extension { get; }
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
                return _openXmlPackage;
            }
        }

        /// <summary>
        /// Gets the internal part path in the package.
        /// </summary>
        public Uri Uri => PackagePart.Uri;

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
        protected sealed override void ThrowIfObjectDisposed()
        {
            if (_openXmlPackage is null || _packagePart is null)
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
        public override IFeatureCollection Features => _features ??= new PartFeatureCollection(this);

        #region MC Staffs

        internal MarkupCompatibilityProcessSettings? MCSettings { get; set; }

        #endregion
    }
}
