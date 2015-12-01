// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;
using System.IO.Packaging;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml;
using System.Globalization;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an abstract base class for all OpenXml parts.
    /// </summary>
    public abstract class OpenXmlPart : OpenXmlPartContainer
    {
        #region private data members
        
        private OpenXmlPackage _openXmlPackage;
        private PackagePart _metroPart;
        private Uri _uri;

        // parent part, for internal use only
        //private OpenXmlPart _ownerPart;

        private string documentClassNameOfWord = "DocumentFormat.OpenXml.Packaging.WordprocessingDocument";
        private string documentClassNameOfExcel = "DocumentFormat.OpenXml.Packaging.SpreadsheetDocument";
        private string documentClassNameOfPPT = "DocumentFormat.OpenXml.Packaging.PresentationDocument";

        #endregion

        #region constructors

        /// <summary>
        /// OpenXmlPart constructor
        /// </summary>
        internal protected OpenXmlPart()
            : base()
        {
        }

        #endregion

        #region methods for LoadPart(), NewPart( ), AddPartFrom( )

        internal void Load(OpenXmlPackage openXmlPackage, OpenXmlPart parent, Uri uriTarget, string id, Dictionary<Uri, OpenXmlPart> loadedParts)
        {
            if (uriTarget == null)
            {
                throw new ArgumentNullException("uriTarget");
            }

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            if (openXmlPackage == null && parent == null)
            {
                throw new ArgumentNullException(ExceptionMessages.PackageRelatedArgumentNullException);
            }
            else if (parent != null && openXmlPackage != null &&
                 parent.OpenXmlPackage != openXmlPackage)
            {
                throw new ArgumentOutOfRangeException("parent");
            }
            else if (parent != null && openXmlPackage == null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            this._openXmlPackage = openXmlPackage;
            //this._ownerPart = parent;

            Debug.Assert(loadedParts.ContainsKey(uriTarget));

            this._uri = uriTarget;

            // TODO: should we delay load?
            PackagePart metroPart = this.OpenXmlPackage.Package.GetPart(uriTarget);

            if (this.IsContentTypeFixed &&
                metroPart.ContentType != this.ContentType)
            {
                string errorMessage = String.Format(CultureInfo.CurrentUICulture,
                                                    ExceptionMessages.InvalidPartContentType,
                                                    metroPart.Uri.OriginalString,
                                                    metroPart.ContentType,
                                                    this.ContentType);

                OpenXmlPackageException e = new OpenXmlPackageException(errorMessage);

                //e.Data.Add("Part Uri", metroPart.Uri.OriginalString );
                //e.Data.Add("Part Content Type", metroPart.ContentType);
                //e.Data.Add("Expected Content Type", this.ContentType);
 
                throw e;
            }

            this._metroPart = metroPart;

            // add the _uri to be reserved
            this.OpenXmlPackage.ReserveUri(this.ContentType, this.Uri);

            // load recursively
            RelationshipCollection relationshipCollection = new PackagePartRelationshipPropertyCollection(this.PackagePart);
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
                throw new ArgumentNullException("contentType");
            }

            PartConstraintRule partConstraintRule;

            if (GetPartConstraint().TryGetValue(relationshipType, out partConstraintRule))
            {
                if (!partConstraintRule.MaxOccursGreatThanOne)
                {
                    if (this.GetSubPart(relationshipType) != null)
                    {
                        // already have one, can not add new one.
                        throw new InvalidOperationException(ExceptionMessages.OnlyOnePartAllowed);
                    }
                }

                OpenXmlPart child = CreateOpenXmlPart(relationshipType);

                child.CreateInternal(this.OpenXmlPackage, this, contentType, null);

                // add it and get the id
                string relationshipId = this.AttachChild(child);

                this.ChildrenParts.Add(relationshipId, child);

                return child;
            }
            throw new ArgumentOutOfRangeException("relationshipType");
        }

        // get app specific TargetPath if exists
        internal string GetTargetPath(string defaultPath)
        {
            string targetPath = null;

            if (this.TargetPathOfWord != null ||this.TargetPathOfExcel != null || this.TargetPathOfPPT != null)
            {
                string documentClassName = this._openXmlPackage.GetType().ToString();
                if (this.TargetPathOfWord != null && documentClassName == this.documentClassNameOfWord)
                {
                    targetPath = this.TargetPathOfWord;
                }
                else if (this.TargetPathOfExcel != null && documentClassName == this.documentClassNameOfExcel)
                {
                    targetPath = this.TargetPathOfExcel;
                }
                else if (this.TargetPathOfPPT != null && documentClassName == this.documentClassNameOfPPT)
                {
                    targetPath = this.TargetPathOfPPT;
                }
            }
            if (targetPath != null)
            {
                return targetPath;
            }
            else
            {
                return defaultPath;
            }
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
                throw new ArgumentOutOfRangeException("parent");
            }
            else if (parent != null && openXmlPackage == null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            // throw exception to catch error in our code
            if (this._metroPart != null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            this._openXmlPackage = openXmlPackage;

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
            string targetPath = this.GetTargetPath(this.TargetPath);

            if (targetPath == null)
            {
                targetPath = ".";
            }

            string targetFileExt = targetExt;

            if (!this.IsContentTypeFixed)
            {
                if (!this._openXmlPackage.PartExtensionProvider.TryGetValue(contentType, out targetFileExt))
                {
                    targetFileExt = targetExt;
                }
            }

            if (targetFileExt == null)
            {
                targetFileExt = this.TargetFileExtension;
            }

            this._uri = this._openXmlPackage.GetUniquePartUri(contentType, parentUri, targetPath, this.TargetName, targetFileExt);

            this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);
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
                throw new ArgumentOutOfRangeException("parent");
            }
            else if (parent != null && openXmlPackage == null)
            {
                openXmlPackage = parent.OpenXmlPackage;
            }

            // throw exception to catch error in our code
            if (this._metroPart != null)
            {
                throw new InvalidOperationException();
            }

            // set the _openXmlPackage so ThrowIfObjectDisposed( ) do not throw.
            this._openXmlPackage = openXmlPackage;

            Uri parentUri;

            if (parent != null)
            {
                parentUri = parent.Uri;
            }
            else
            {
                parentUri = new Uri("/", UriKind.Relative);
            }

            this._uri = this._openXmlPackage.GetUniquePartUri(contentType, parentUri, partUri);

            this._metroPart = this._openXmlPackage.CreateMetroPart(this._uri, contentType);

        }


        #endregion

        #region public properties

        /// <summary>
        /// Represents a part that is in the OpenXmlPackage container.
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
        /// Represents the internal part path in the package.
        /// </summary>
        public Uri Uri
        {
            get
            {
                ThrowIfObjectDisposed();

                Debug.Assert(this._uri.OriginalString.Equals(this._metroPart.Uri.OriginalString, StringComparison.OrdinalIgnoreCase));

                return this._uri;
            }
            //internal set
            //{
            //    ThrowIfObjectDisposed();
            //    this._uri = value;
            //}
        }

        #endregion

        #region public methods
        
        /// <summary>
        /// Enumerates all parents that reference this part anywhere in the document.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public IEnumerable<OpenXmlPart> GetParentParts()
        {
            ThrowIfObjectDisposed();

            Dictionary<OpenXmlPart, bool> liveParts = new Dictionary<OpenXmlPart, bool>();

            this.OpenXmlPackage.FindAllReachableParts(liveParts);

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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public Stream GetStream( )
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

            return this.PackagePart.GetStream( mode );
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

            return this.PackagePart.GetStream(mode, access);
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
                throw new ArgumentNullException("sourceStream");
            }

            using (Stream targetStream = this.GetStream(FileMode.Create))
            {
                CopyStream(sourceStream, targetStream);
            }
        }

        #endregion

        #region public virtual methods / properties

        /// <summary>
        /// Represents the content type (MIME type) of the content data in the part.
        /// </summary>
        public virtual string ContentType
        {
            get
            {
                ThrowIfObjectDisposed();
                return this.PackagePart.ContentType;
            }
        }

        /// <summary>
        /// The relationship type of the part.
        /// </summary>
        public abstract string RelationshipType { get; }

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
                throw new ArgumentNullException("schemas");
            }

            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.DtdProcessing = DtdProcessing.Prohibit; // set true explicitly for security fix
            xmlReaderSettings.MaxCharactersInDocument = this.MaxCharactersInPart;
            XmlReader xmlReader = null;

            // XML validator object

            using (Stream partStream = this.GetStream())
            {
                //xmlReaderSettings.Schemas.Add(null, schemaFile);
                xmlReaderSettings.Schemas = schemas;
                xmlReaderSettings.ValidationType = ValidationType.Schema;
                // Add validation event handler
                if (validationEventHandler != null)
                {
                    xmlReaderSettings.ValidationEventHandler += validationEventHandler;
                }

                using (xmlReader = XmlConvertingReaderFactory.Create(partStream, xmlReaderSettings))
                {
                    // Validate XML data
                    while (xmlReader.Read()) ;
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
                throw new ArgumentNullException("schemaFile");
            }

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(null, schemaFile);

            this.ValidateXml(schemas, validationEventHandler);
        }

        /// <summary>
        /// Gets the root element of the current part.
        /// Returns null when the current part is empty or is not and XML content type.
        /// </summary>
        public OpenXmlPartRootElement RootElement
        {
            get
            {
                return this.PartRootElement;
            }
        }

        #endregion 

        #region internal properties

        /// <summary>
        /// The internal metro PackagePart element.
        /// </summary>
        internal PackagePart PackagePart
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._metroPart;
            }
            // set { this._metroPart = value; }
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
                return this.OpenXmlPackage.MaxCharactersInPart;
            }
        }


        #endregion

        #region internal virtual methods / properties

        /// <summary>
        /// Indicates whether the ContentType for the current part is fixed. 
        /// </summary>
        internal virtual bool IsContentTypeFixed
        {
            get
            {
                ThrowIfObjectDisposed();
                return false;
            }
        }

        // find all reachable parts from the package root, the dictionary also used for cycle reference defence
        internal sealed override void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts)
        {
            ThrowIfObjectDisposed();

            if (reachableParts == null)
            {
                throw new ArgumentNullException("reachableParts");
            }

            reachableParts.Add(this, false);
            foreach (OpenXmlPart part in this.ChildrenParts.Values)
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
        /// Do not call this property outside of OpenXmlPart.
        /// </summary>
        /// <exception cref="InvalidOperationException">If the part does not have root element defined.</exception>
        internal virtual OpenXmlPartRootElement _rootElement
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
        /// Returns true when the root element is loaded from the part or it has been set.
        /// </summary>
        internal bool IsRootElementLoaded
        {
            get
            {
                return this._rootElement != null;
            }
        }

        /// <summary>
        /// Sets the PartRootElement to null. 
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Used by validator. To releaase the DOM and so the memory can be GC'ed.
        /// </remarks>
        internal OpenXmlPartRootElement SetPartRootElementToNull()
        {
            var rootElement = this._rootElement;
            if (this._rootElement != null)
            {
                this._rootElement = null;
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
        internal void LoadDomTree<T>() where T : OpenXmlPartRootElement, new()
        {
            Debug.Assert(this._rootElement == null);

            bool streamIsEmpty = true;

            using (Stream stream = this.GetStream(FileMode.OpenOrCreate, FileAccess.Read))
            {
                if ( stream.Length > 0 )
                {
                    streamIsEmpty = false;
                }

                if (!streamIsEmpty)
                {
                    T rootElement = new T();

                    try
                    {
                        if (rootElement.LoadFromPart(this, stream))
                        {
                            // set this part to the root Element
                            rootElement.OpenXmlPart = this;

                            // associate the root element with this part.
                            this._rootElement = rootElement;
                        }
                        else
                        {
                            // the part stream does not contain a XML root element.
                            // jus leave the .RootElement as null.
                        }
                    }
                    catch (InvalidDataException e)
                    {
                        throw new InvalidDataException(ExceptionMessages.CannotLoadRootElement, e);
                    }
                }
            }
                
            return;
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

            //if (partRootElement == null)
            //{
            //    if (this.RootElement != null)
            //    {
            //        // clear the association from the previous root element.
            //        this.RootElement.OpenXmlPart = null;
            //    }

            //    this.RootElement = null;

            //    return;
            //}

            if (partRootElement.OpenXmlPart != null)
            {
                throw new ArgumentException(ExceptionMessages.PartRootAlreadyHasAssociation, "partRootElement");
            }

            partRootElement.OpenXmlPart = this;

            if (this._rootElement != null)
            {
                // clear the association from the previous root element.
                this._rootElement.OpenXmlPart = null;
            }

            this._rootElement = partRootElement;

            return;
        }

        // destroy itself (aka. dispose)
        internal void Destroy()
        {
            this.OpenXmlPackage.Package.DeletePart(this.Uri);

            this.PartDictionary = null;
            this.ReferenceRelationshipList.Clear();
            this._openXmlPackage = null;
            this._metroPart = null;
            this._uri = null;
            //this._ownerPart = null;
            if (this._rootElement != null)
            {
                this._rootElement.OpenXmlPart = null;
                this._rootElement = null;
            }
        }

        #endregion

        #region protected methods

        /// <summary>
        /// Indicates whether the object is already disposed.
        /// </summary>
        protected sealed override void ThrowIfObjectDisposed( )
        {
            if (this._openXmlPackage == null)
            {
                throw new InvalidOperationException(ExceptionMessages.PartIsDestroyed);
            }
        }

        internal sealed override OpenXmlPackage InternalOpenXmlPackage
        {
            get { return this._openXmlPackage; }
        }

        internal sealed override OpenXmlPart ThisOpenXmlPart
        {
            get { return this; }
        }

        internal sealed override void DeleteRelationship(string id)
        {
            ThrowIfObjectDisposed();

            this.PackagePart.DeleteRelationship(id);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType)
        {
            ThrowIfObjectDisposed();

            return this._metroPart.CreateRelationship(targetUri, targetMode, relationshipType);
        }

        internal sealed override PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id)
        {
            ThrowIfObjectDisposed();

            return this._metroPart.CreateRelationship(targetUri, targetMode, relationshipType, id);
        }


        #endregion

        #region private methods
        internal static void CopyStream(Stream sourceStream, Stream targetStream)
        {
            if (sourceStream == null)
            {
                throw new ArgumentNullException("sourceStream");
            }
            
            using (BinaryReader sourceReader = new BinaryReader(sourceStream))
            {
                byte[] buffer = new byte[4096];

                int num = 0;
                do
                {
                    num = sourceReader.Read(buffer, 0, 4096);
                    if (num > 0)
                        targetStream.Write(buffer, 0, num);
                }
                while (num > 0);
            }
            
        }
        #endregion

        #region MC Staffs
        internal MarkupCompatibilityProcessSettings MCSettings;
        #endregion

    }
}
