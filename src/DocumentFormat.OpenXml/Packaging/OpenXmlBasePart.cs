// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Packaging;

#if FEATURE_XML_SCHEMA
using System.Xml;
using System.Xml.Schema;
#endif

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an abstract base class for all OpenXml parts.
    /// </summary>
    public abstract class OpenXmlPart : OpenXmlPartContainer
    {
        private OpenXmlPackage _openXmlPackage;
        private PackagePart _packagePart;
        private Uri _uri;

        /// <summary>
        /// Create an instance of <see cref="OpenXmlPart"/>
        /// </summary>
        protected internal OpenXmlPart()
            : base()
        {
        }

        #region methods for LoadPart(), NewPart( ), AddPartFrom( )

        internal void Load(OpenXmlPackage openXmlPackage, OpenXmlPart parent, Uri uriTarget, string id, Dictionary<Uri, OpenXmlPart> loadedParts)
        {
            if (uriTarget == null)
            {
                throw new ArgumentNullException(nameof(uriTarget));
            }

            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (openXmlPackage == null && parent == null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }
            else if (parent != null && openXmlPackage != null &&
                 parent.OpenXmlPackage != openXmlPackage)
            {
                throw new ArgumentOutOfRangeException(nameof(parent));
            }
            else if (parent != null && openXmlPackage == null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            _openXmlPackage = openXmlPackage;

            Debug.Assert(loadedParts.ContainsKey(uriTarget));

            _uri = uriTarget;

            // TODO: should we delay load?
            PackagePart metroPart = OpenXmlPackage.Package.GetPart(uriTarget);

            if (IsContentTypeFixed && metroPart.ContentType != ContentType)
            {
                var errorMessage = SR.Format(
                    ExceptionMessages.InvalidPartContentType,
                    metroPart.Uri.OriginalString,
                    metroPart.ContentType,
                    ContentType);

                throw new OpenXmlPackageException(errorMessage);
            }

            _packagePart = metroPart;

            // add the _uri to be reserved
            OpenXmlPackage.ReserveUri(ContentType, Uri);

            // load recursively
            RelationshipCollection relationshipCollection = new PackagePartRelationshipPropertyCollection(PackagePart);
            LoadReferencedPartsAndRelationships(openXmlPackage, this, relationshipCollection, loadedParts);
        }

        // can not use generic, at it will emit error
        // Compiler Error CS0310
        // The type 'typename' must have a public parameterless constructor in order to use it as parameter 'parameter' in the generic type or method 'generic'
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
        internal string GetTargetPath(string defaultPath)
        {
            if (TargetPathOfWord != null && _openXmlPackage is WordprocessingDocument)
            {
                return TargetPathOfWord;
            }
            else if (TargetPathOfExcel != null && _openXmlPackage is SpreadsheetDocument)
            {
                return TargetPathOfExcel;
            }
            else if (TargetPathOfPPT != null && _openXmlPackage is PresentationDocument)
            {
                return TargetPathOfPPT;
            }

            return defaultPath;
        }

        // create a new part in this package
        internal void CreateInternal(OpenXmlPackage openXmlPackage, OpenXmlPart parent, string contentType, string targetExt)
        {
            // openXmlPackage, parent can not be all null
            if (openXmlPackage == null && parent == null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }
            else if (parent != null && openXmlPackage != null &&
                 parent.OpenXmlPackage != openXmlPackage)
            {
                throw new ArgumentOutOfRangeException(nameof(parent));
            }
            else if (parent != null && openXmlPackage == null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            // throw exception to catch error in our code
            if (_packagePart != null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            _openXmlPackage = openXmlPackage;

            Uri parentUri;

            if (parent != null)
            {
                parentUri = parent.Uri;
            }
            else
            {
                parentUri = new Uri("/", UriKind.Relative);
            }

            //OpenXmlPart parentPart = this._ownerPart;

            //Uri is auto generated to make sure it's unique
            string targetPath = GetTargetPath(TargetPath);

            if (targetPath == null)
            {
                targetPath = ".";
            }

            string targetFileExt = targetExt;

            if (!IsContentTypeFixed)
            {
                if (!_openXmlPackage.PartExtensionProvider.TryGetValue(contentType, out targetFileExt))
                {
                    targetFileExt = targetExt;
                }
            }

            if (targetFileExt == null)
            {
                targetFileExt = TargetFileExtension;
            }

            _uri = _openXmlPackage.GetUniquePartUri(contentType, parentUri, targetPath, TargetName, targetFileExt);

            _packagePart = _openXmlPackage.CreateMetroPart(_uri, contentType);
        }

        // create a new part in this package
        internal void CreateInternal2(OpenXmlPackage openXmlPackage, OpenXmlPart parent, string contentType, Uri partUri)
        {
            // openXmlPackage, parent can not be all null
            if (openXmlPackage == null && parent == null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }
            else if (parent != null && openXmlPackage != null &&
                 parent.OpenXmlPackage != openXmlPackage)
            {
                throw new ArgumentOutOfRangeException(nameof(parent));
            }
            else if (parent != null && openXmlPackage == null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            // throw exception to catch error in our code
            if (_packagePart != null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            _openXmlPackage = openXmlPackage;

            Uri parentUri;

            if (parent != null)
            {
                parentUri = parent.Uri;
            }
            else
            {
                parentUri = new Uri("/", UriKind.Relative);
            }

            _uri = _openXmlPackage.GetUniquePartUri(contentType, parentUri, partUri);

            _packagePart = _openXmlPackage.CreateMetroPart(_uri, contentType);
        }

        #endregion

        #region public properties

        /// <summary>
        /// Gets a part that is in the OpenXmlPackage container.
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

            Dictionary<OpenXmlPart, bool> liveParts = new Dictionary<OpenXmlPart, bool>();

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

            if (sourceStream == null)
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
        public void ValidateXml(XmlSchemaSet schemas, ValidationEventHandler validationEventHandler)
        {
            ThrowIfObjectDisposed();

            if (schemas == null)
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
                if (validationEventHandler != null)
                {
                    xmlReaderSettings.ValidationEventHandler += validationEventHandler;
                }

                using (var xmlReader = XmlConvertingReaderFactory.Create(partStream, xmlReaderSettings))
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
        public void ValidateXml(string schemaFile, ValidationEventHandler validationEventHandler)
        {
            ThrowIfObjectDisposed();

            if (schemaFile == null)
            {
                throw new ArgumentNullException(nameof(schemaFile));
            }

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(null, schemaFile);

            ValidateXml(schemas, validationEventHandler);
        }
#endif

        /// <summary>
        /// Gets the root element of the current part.
        /// Returns null when the current part is empty or is not and XML content type.
        /// </summary>
        public OpenXmlPartRootElement RootElement
        {
            get
            {
                return PartRootElement;
            }
        }

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
        //internal OpenXmlPart ParentPart
        //{
        //    get
        //    {
        //        ThrowIfObjectDisposed();
        //        return this._ownerPart;
        //    }
        //}

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
        internal virtual bool IsContentTypeFixed
        {
            get
            {
                ThrowIfObjectDisposed();
                return false;
            }
        }

        // find all reachable parts from the package root, the dictionary also used for cycle reference defense
        internal sealed override void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
        {
            ThrowIfObjectDisposed();

            if (reachableParts == null)
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
        internal virtual string TargetPath { get { return null; } }

        /// <summary>
        /// Gets the internal path (Word specific TargetPath) to be used for the part name.
        /// </summary>
        internal virtual string TargetPathOfWord { get { return null; } }

        /// <summary>
        /// Gets the internal path (Excel specific TargetPath) to be used for the part name.
        /// </summary>
        internal virtual string TargetPathOfExcel { get { return null; } }

        /// <summary>
        /// Gets the internal path (PPT specific TargetPath) to be used for the part name.
        /// </summary>
        internal virtual string TargetPathOfPPT { get { return null; } }

        /// <summary>
        /// Gets the file base name to be used for the part name in the package.
        /// </summary>
        internal abstract string TargetName { get; }

        private const string DefaultTargetExt = ".xml";

        /// <summary>
        /// Gets the file extension to be used for the part in the package.
        /// </summary>
        internal virtual string TargetFileExtension
        {
            get { return DefaultTargetExt; }
        }

        // inherited class should have a static properties
        // public static string RelationshipType { get {return "xx"; } }
        // internal abstract string PartRelationshipType { get; }

        /// <summary>
        /// Gets or sets the root element field.
        /// </summary>
        /// <exception cref="InvalidOperationException">If the part does not have root element defined.</exception>
        private protected virtual OpenXmlPartRootElement InternalRootElement
        {
            get { return null; }
            set { throw new InvalidOperationException(); }
        }

        /// <summary>
        /// Gets the root element of the current part.
        /// </summary>
        /// <remarks>Returns null if the part is not a defined XML part.</remarks>
        internal virtual OpenXmlPartRootElement PartRootElement
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
        internal bool IsRootElementLoaded => InternalRootElement != null;

        /// <summary>
        /// Sets the PartRootElement to null.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Used by validator. To release the DOM and so the memory can be GC'ed.
        /// </remarks>
        internal OpenXmlPartRootElement SetPartRootElementToNull()
        {
            var rootElement = InternalRootElement;
            if (InternalRootElement != null)
            {
                InternalRootElement = null;
            }

            return rootElement;
        }

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
            Debug.Assert(InternalRootElement == null);

            using (Stream stream = GetStream(FileMode.OpenOrCreate, FileAccess.Read))
            {
                if (stream.Length == 0)
                {
                    return;
                }

                try
                {
                    var rootElement = new T();

                    if (rootElement.LoadFromPart(this, stream))
                    {
                        // set this part to the root Element
                        rootElement.OpenXmlPart = this;

                        // associate the root element with this part.
                        InternalRootElement = rootElement;
                    }
                }
                catch (InvalidDataException e)
                {
                    throw new InvalidDataException(ExceptionMessages.CannotLoadRootElement, e);
                }
            }
        }

        /// <summary>
        /// Set the RootElement to be the given partRootElement.
        /// Only used for generated part classes which derive from this OpenXmlBasePart.
        /// </summary>
        /// <param name="partRootElement">The given partRootElement. Can be null.</param>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when the part's root element has already be associated with another OpenXmlPart.</exception>
        internal void SetDomTree(OpenXmlPartRootElement partRootElement)
        {
            Debug.Assert(partRootElement != null);

            if (partRootElement.OpenXmlPart != null)
            {
                throw new ArgumentException(ExceptionMessages.PartRootAlreadyHasAssociation, nameof(partRootElement));
            }

            partRootElement.OpenXmlPart = this;

            if (InternalRootElement != null)
            {
                // clear the association from the previous root element.
                InternalRootElement.OpenXmlPart = null;
            }

            InternalRootElement = partRootElement;

            return;
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

            //this._ownerPart = null;
            if (InternalRootElement != null)
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
        protected sealed override void ThrowIfObjectDisposed()
        {
            if (_openXmlPackage == null)
            {
                throw new InvalidOperationException(ExceptionMessages.PartIsDestroyed);
            }
        }

        internal sealed override OpenXmlPackage InternalOpenXmlPackage
        {
            get { return _openXmlPackage; }
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

        #region MC Staffs
        internal MarkupCompatibilityProcessSettings MCSettings;
        #endregion

    }
}
