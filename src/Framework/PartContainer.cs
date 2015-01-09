// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.IO;
using System.IO.Packaging;
using System.Diagnostics;
using System.Globalization;
using System.Xml;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the base class for OpenXmlPackage and OpenXmlPart.
    /// </summary>
    public abstract class OpenXmlPartContainer
    {
        private Dictionary<string, OpenXmlPart> _childrenPartsDictionary = new Dictionary<string, OpenXmlPart>();
        private LinkedList<ReferenceRelationship> _referenceRelationships = new LinkedList<ReferenceRelationship>();
        private object _annotations;

        /// <summary>
        /// Initializes OpenXmlPartContainer.
        /// </summary>
        protected OpenXmlPartContainer()
        {
        }

        #region internal properties

        /// <summary>
        /// Gets the children parts IDictionary.
        /// </summary>
        internal IDictionary<string, OpenXmlPart> ChildrenParts
        {
            get
            {
                ThrowIfObjectDisposed();
                return this.PartDictionary;
            }
        }

        /// <summary>
        /// Gets or sets the children parts dictionary.
        /// </summary>
        internal Dictionary<string, OpenXmlPart> PartDictionary
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._childrenPartsDictionary;
            }
            set
            {
                ThrowIfObjectDisposed();
                this._childrenPartsDictionary = value;
            }
        }

        /// <summary>
        /// Gets the ReferenceRelationship list.
        /// </summary>
        internal LinkedList<ReferenceRelationship> ReferenceRelationshipList
        {
            get
            {
                ThrowIfObjectDisposed();
                return this._referenceRelationships;
            }
        }

        #endregion

        #region public methods / properties

        #region methods to operate ReferenceRelationship

        /// <summary>
        /// Deletes the specified reference relationship.
        /// </summary>
        /// <param name="referenceRelationship">The reference relationship to be deleted.</param>
        /// <exception cref="ArgumentNullException">Thrown when "referenceRelationship" is null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the reference relationship is not referenced by this part.</exception>
        public void DeleteReferenceRelationship(ReferenceRelationship referenceRelationship)
        {
            ThrowIfObjectDisposed();

            if (referenceRelationship == null)
            {
                throw new ArgumentNullException("referenceRelationship");
            }

            if (referenceRelationship.Id == null || referenceRelationship.Container != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ReferenceRelationshipIsNotReferenced);
            }

            if (this.ReferenceRelationshipList.Contains(referenceRelationship))
            {
                this.ReferenceRelationshipList.Remove(referenceRelationship);
                this.DeleteRelationship(referenceRelationship.Id);
                referenceRelationship.Container = null;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.ReferenceRelationshipIsNotReferenced);
            }
        }

        /// <summary>
        /// Deletes the specified reference relationship.
        /// </summary>
        /// <param name="id">The relationship ID of the ReferenceRelationship.</param>
        /// <exception cref="ArgumentNullException">Thrown when the "id" parameter is null.</exception>
        /// <exception cref="KeyNotFoundException">Thrown when there is no ReferenceRelationship with the specified relationship ID.</exception>
        public void DeleteReferenceRelationship(string id)
        {
            ThrowIfObjectDisposed();

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            foreach (var referenceRelationship in this.ReferenceRelationshipList)
            {
                if (referenceRelationship.Id == id)
                {
                    this.ReferenceRelationshipList.Remove(referenceRelationship);
                    this.DeleteRelationship(referenceRelationship.Id);
                    referenceRelationship.Container = null;
                    return;
                }
            }

            throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedReferenceRelationship);
        }

        /// <summary>
        /// Gets the specified ReferenceRelationship. 
        /// </summary>
        /// <param name="id">The relationship ID of the ReferenceRelationship.</param>
        /// <returns>Returns the ReferenceRelationship which has the relationship ID. </returns>
        /// <exception cref="ArgumentNullException">Thrown when the "id" parameter is null.</exception>
        /// <exception cref="KeyNotFoundException">Thrown when there is no ReferenceRelationship with the specified relationship ID.</exception>
        public ReferenceRelationship GetReferenceRelationship(string id)
        {
            ThrowIfObjectDisposed();

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            foreach (var referenceRelatinship in this.ReferenceRelationshipList)
            {
                if (referenceRelatinship.Id == id)
                {
                    return referenceRelatinship;
                }
            }

            throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedReferenceRelationship);
        }

        #endregion

        #region methods to operate ExternalRelationship

        /// <summary>
        /// Enumerates all external relationships.
        /// Hyperlink relationships are not included, use HyperlinkRelationship property to enumerate hyperlink relationships.
        /// </summary>
        public IEnumerable<ExternalRelationship> ExternalRelationships
        {
            get
            {
                ThrowIfObjectDisposed();
                return this.ReferenceRelationshipList.OfType<ExternalRelationship>();
            }
        }

        /// <summary>
        /// Adds an external relationship.
        /// Do not add hyperlink relationships through this method. Use AddHyperlinkRelationship() instead.
        /// </summary>
        /// <param name="relationshipType">The relationship type.</param>
        /// <param name="externalUri">The external URI.</param>
        /// <returns>An ExternalRelationship with the relationship ID. </returns>
        /// <exception cref="ArgumentNullException">Thrown when "relationshipType" or the "externalUri" is null reference.</exception>
        public ExternalRelationship AddExternalRelationship(string relationshipType, Uri externalUri)
        {
            ThrowIfObjectDisposed();

            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }

            if (externalUri == null)
            {
                throw new ArgumentNullException("externalUri");
            }

            if (relationshipType == HyperlinkRelationship.RelationshipTypeConst)
            {
                throw new InvalidOperationException(ExceptionMessages.UseAddHyperlinkRelationship);
            }

            PackageRelationship relationship = this.CreateRelationship(externalUri, TargetMode.External, relationshipType);

            ExternalRelationship externalRel = new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id);
            externalRel.Container = this;
            this.ReferenceRelationshipList.AddLast(externalRel);
            return externalRel;
        }

        /// <summary>
        /// Adds an external relationship.
        /// Do not add hyperlink relationships through this method. Use AddHyperlinkRelationship() instead.
        /// </summary>
        /// <param name="relationshipType">The relationship type.</param>
        /// <param name="externalUri">The external URI.</param>
        /// <param name="id">The desired relationship ID. </param>
        /// <returns>An ExternalRelationship with the relationship ID. </returns>
        /// <exception cref="ArgumentNullException">Thrown when "relationshipType" or the "externalUri" is null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the relatioship type is hyperlink relationship type (http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink). </exception>
        public ExternalRelationship AddExternalRelationship(string relationshipType, Uri externalUri, string id)
        {
            ThrowIfObjectDisposed();

            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }

            if (externalUri == null)
            {
                throw new ArgumentNullException("externalUri");
            }

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            if (relationshipType == HyperlinkRelationship.RelationshipTypeConst)
            {
                throw new InvalidOperationException(ExceptionMessages.UseAddHyperlinkRelationship);
            }

            PackageRelationship relationship = this.CreateRelationship(externalUri, TargetMode.External, relationshipType, id);

            ExternalRelationship externalRel = new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id);
            externalRel.Container = this;
            this.ReferenceRelationshipList.AddLast(externalRel);
            return externalRel;
        }

        /// <summary>
        /// Deletes the specified external relationship.
        /// </summary>
        /// <param name="externalRelationship">The external relationship to be deleted.</param>
        /// <exception cref="ArgumentNullException">Thrown when "externalRelationship" is null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the external relationship is not referenced by this part.</exception>
        public void DeleteExternalRelationship(ExternalRelationship externalRelationship)
        {
            ThrowIfObjectDisposed();

            if (externalRelationship == null)
            {
                throw new ArgumentNullException("externalRelationship");
            }

            if (externalRelationship.Id == null || externalRelationship.Container != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ExternalRelationshipIsNotReferenced);
            }

            if (this.ReferenceRelationshipList.Contains(externalRelationship))
            {
                this.ReferenceRelationshipList.Remove(externalRelationship);
                this.DeleteRelationship(externalRelationship.Id);
                externalRelationship.Container = null;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.ExternalRelationshipIsNotReferenced);
            }
        }

        /// <summary>
        /// Deletes the specified ExternalRelationship. 
        /// </summary>
        /// <param name="id">The relationship ID of the ExternalRelationship.</param>
        /// <exception cref="ArgumentNullException">Thrown when the "id" parameter is null.</exception>
        /// <exception cref="KeyNotFoundException">Thrown when there is no ExternalRelationship with the specified relationship ID.</exception>
        public void DeleteExternalRelationship(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            foreach (var externalRelationship in this.ReferenceRelationshipList.OfType<ExternalRelationship>())
            {
                if (externalRelationship.Id == id)
                {
                    this.ReferenceRelationshipList.Remove(externalRelationship);
                    this.DeleteRelationship(externalRelationship.Id);
                    externalRelationship.Container = null;
                    return;
                }
            }

            throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedExternalRelationship);
        }

        /// <summary>
        /// Gets the specified ExternalRelationship. 
        /// </summary>
        /// <param name="id">The relationship ID of the ExternalRelationship.</param>
        /// <returns>Returns the ExternalRelationship which has the relationship ID. </returns>
        /// <exception cref="ArgumentNullException">Thrown when the "id" parameter is null.</exception>
        /// <exception cref="KeyNotFoundException">Thrown when there is no ExternalRelationship with the specified relationship ID.</exception>
        public ExternalRelationship GetExternalRelationship(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            foreach (var externalRelationship in this.ReferenceRelationshipList.OfType<ExternalRelationship>())
            {
                if (externalRelationship.Id == id)
                {
                    return externalRelationship;
                }
            }

            throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedExternalRelationship);
        }

        #endregion 

        #region methods to operate HyperlinkRelationship

        /// <summary>
        /// Enumerates all hyperlink relationships.
        /// </summary>
        public IEnumerable<HyperlinkRelationship> HyperlinkRelationships
        {
            get
            {
                ThrowIfObjectDisposed();
                return this.ReferenceRelationshipList.OfType<HyperlinkRelationship>();
            }
        }

        /// <summary>
        /// Adds a new hyperlink relationship.
        /// </summary>
        /// <param name="hyperlinkUri">The URI of the hyperlink.</param>
        /// <param name="isExternal">Is the hyperlink external to the <see cref="OpenXmlPackage"/>.</param>
        /// <returns>An HyperlinkRelationship with the relationship ID. </returns>
        /// <exception cref="ArgumentNullException">Thrown when "hyperlinkUri" is null reference.</exception>
        public HyperlinkRelationship AddHyperlinkRelationship(Uri hyperlinkUri, bool isExternal)
        {
            ThrowIfObjectDisposed();

            if (hyperlinkUri == null)
            {
                throw new ArgumentNullException("hyperlinkUri");
            }

            TargetMode targetMode = isExternal ? TargetMode.External : TargetMode.Internal;
            PackageRelationship relationship = this.CreateRelationship(hyperlinkUri, targetMode, HyperlinkRelationship.RelationshipTypeConst);

            HyperlinkRelationship hyperlinkRel = new HyperlinkRelationship(relationship.TargetUri, isExternal, relationship.Id);
            hyperlinkRel.Container = this;
            this.ReferenceRelationshipList.AddLast(hyperlinkRel);
            return hyperlinkRel;
        }

        /// <summary>
        /// Adds a new hyperlink relationship.
        /// </summary>
        /// <param name="hyperlinkUri">The URI of the hyperlink.</param>
        /// <param name="isExternal">Is the hyperlink external to the <see cref="OpenXmlPackage"/>.</param>
        /// <param name="id">The desired relationship ID. </param>
        /// <returns>An HyperlinkRelationship with the relationship ID. </returns>
        /// <exception cref="ArgumentNullException">Thrown when "hyperlinkUri" or "id" is null reference.</exception>
        public HyperlinkRelationship AddHyperlinkRelationship(Uri hyperlinkUri, bool isExternal, string id)
        {
            ThrowIfObjectDisposed();

            if (hyperlinkUri == null)
            {
                throw new ArgumentNullException("hyperlinkUri");
            }

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            PackageRelationship relationship = this.CreateRelationship(hyperlinkUri, TargetMode.External, HyperlinkRelationship.RelationshipTypeConst, id);

            HyperlinkRelationship hyperlinkRel = new HyperlinkRelationship(relationship.TargetUri, isExternal, relationship.Id);
            hyperlinkRel.Container = this;
            this.ReferenceRelationshipList.AddLast(hyperlinkRel);
            return hyperlinkRel;
        }

        #endregion

        #region methods to operate DataPartReferenceRelationship

        /// <summary>
        /// Enumerates all <see cref="DataPartReferenceRelationship"/> relationships.
        /// </summary>
        public IEnumerable<DataPartReferenceRelationship> DataPartReferenceRelationships
        {
            get
            {
                ThrowIfObjectDisposed();

                return this.ReferenceRelationshipList.OfType<DataPartReferenceRelationship>();
            }
        }

        /// <summary>
        /// Adds a new <see cref="DataPartReferenceRelationship"/> relationship to the specified <see cref="MediaDataPart"/>.
        /// </summary>
        /// <param name="mediaDataPart">The target <see cref="MediaDataPart"/> of the reference relationship.</param>
        /// <returns>An new <see cref="DataPartReferenceRelationship"/>. </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
        internal T AddDataPartReferenceRelationship<T>(MediaDataPart mediaDataPart) where T : DataPartReferenceRelationship
        {
            ThrowIfObjectDisposed();

            if (mediaDataPart == null)
            {
                throw new ArgumentNullException("mediaDataPart");
            }

            if (mediaDataPart.OpenXmlPackage != this.InternalOpenXmlPackage)
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignMediaDataPart);
            }

            T dataPartReferenceRelationship = (T)Activator.CreateInstance(typeof(T), true);

            PackageRelationship relationship = this.CreateRelationship(mediaDataPart.Uri, TargetMode.Internal, dataPartReferenceRelationship.RelationshipType);

            dataPartReferenceRelationship.Initialize(this, mediaDataPart, dataPartReferenceRelationship.RelationshipType, relationship.Id);
            this.ReferenceRelationshipList.AddLast(dataPartReferenceRelationship);
            return dataPartReferenceRelationship;
        }

        /// <summary>
        /// Adds a new <see cref="DataPartReferenceRelationship"/> relationship to the specified <see cref="MediaDataPart"/>.
        /// </summary>
        /// <param name="mediaDataPart">The target <see cref="MediaDataPart"/> of the reference relationship.</param>
        /// <param name="id">The desired relationship ID. </param>
        /// <returns>An new <see cref="DataPartReferenceRelationship"/> with the relationship ID. </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null reference.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="id"/> is null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
        internal T AddDataPartReferenceRelationship<T>(MediaDataPart mediaDataPart, string id) where T : DataPartReferenceRelationship
        {
            ThrowIfObjectDisposed();

            if (mediaDataPart == null)
            {
                throw new ArgumentNullException("mediaDataPart");
            }

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            if (mediaDataPart.OpenXmlPackage != this.InternalOpenXmlPackage)
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignMediaDataPart);
            }

            T dataPartReferenceRelationship = (T)Activator.CreateInstance(typeof(T), true);

            PackageRelationship relationship = this.CreateRelationship(mediaDataPart.Uri, TargetMode.Internal, dataPartReferenceRelationship.RelationshipType, id);

            dataPartReferenceRelationship.Initialize(this, mediaDataPart, dataPartReferenceRelationship.RelationshipType, relationship.Id);
            this.ReferenceRelationshipList.AddLast(dataPartReferenceRelationship);
            return dataPartReferenceRelationship;
        }

        /// <summary>
        /// Adds a new <see cref="DataPartReferenceRelationship"/> relationship.
        /// </summary>
        /// <param name="dataPartReferenceRelationship">The <see cref="DataPartReferenceRelationship"/>.</param>
        /// <returns>The same <see cref="DataPartReferenceRelationship"/>. </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataPartReferenceRelationship"/> is null reference.</exception>
        internal DataPartReferenceRelationship AddDataPartReferenceRelationship(DataPartReferenceRelationship dataPartReferenceRelationship)
        {
            if (dataPartReferenceRelationship == null)
            {
                throw new ArgumentNullException("dataPartReferenceRelationship");
            }

            var mediaDataPart = dataPartReferenceRelationship.DataPart;
            this.CreateRelationship(mediaDataPart.Uri, TargetMode.Internal, dataPartReferenceRelationship.RelationshipType, dataPartReferenceRelationship.Id);
            this.ReferenceRelationshipList.AddLast(dataPartReferenceRelationship);
            return dataPartReferenceRelationship;
        }


        #endregion

        #region methods to operate parts

        /// <summary>
        /// Enumerates all parts which are relationship targets of this part.
        /// </summary>
        public IEnumerable<IdPartPair> Parts
        {
            get
            {
                ThrowIfObjectDisposed();

                foreach (KeyValuePair<string, OpenXmlPart> item in this.PartDictionary)
                {
                    yield return new IdPartPair(item.Key, item.Value);
                }
            }
        }

        /// <summary>
        /// Gets the child part through the relationship ID.
        /// </summary>
        /// <param name="id">The relationship ID of the part.</param>
        /// <returns>The part.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part with the specified id does not exist.</exception>
        public OpenXmlPart GetPartById(string id)
        {
            ThrowIfObjectDisposed();

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            OpenXmlPart part = null;

            if (this.PartDictionary.TryGetValue(id, out part))
            {
                return part;
            }
            else
            {
                // return null;
                throw new ArgumentOutOfRangeException("id");
            }
        }

        /// <summary>
        /// Gets the relationship ID of the part.
        /// </summary>
        /// <param name="part">The part.</param>
        /// <returns>The relationship ID of the part.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "part" is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part does not exist.</exception>
        public string GetIdOfPart(OpenXmlPart part)
        {
            ThrowIfObjectDisposed();

            if (part == null)
            {
                throw new ArgumentNullException("part");
            }

            if (this.PartDictionary.ContainsValue(part))
            {
                foreach (KeyValuePair<string, OpenXmlPart> idPartPair in this.PartDictionary)
                {
                    if (part == idPartPair.Value)
                    {
                        return idPartPair.Key;
                    }
                }
            }

            throw new ArgumentOutOfRangeException("part");
        }

        /// <summary>
        /// Changes the relationship ID of the part.
        /// </summary>
        /// <param name="part">The target part.</param>
        /// <param name="newRelationshipId">The new relationship ID of the part.</param>
        /// <returns>The old relationship ID of the part.</returns>
        /// <exception cref="ArgumentNullException">Throw when "part" is null reference or the newRelationshipId is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part does not exist under this part.</exception>
        /// <exception cref="ArgumentException">Thrown when the specified relationship id is already used by another part.</exception>
        public string ChangeIdOfPart(OpenXmlPart part, string newRelationshipId)
        {
            ThrowIfObjectDisposed();

            if (part == null)
            {
                throw new ArgumentNullException("part");
            }

            if (newRelationshipId == null)
            {
                throw new ArgumentNullException("newRelationshipId");
            }

            string oldId = null;
            foreach (var idPartPair in this.ChildrenParts)
            {
                if (idPartPair.Key == newRelationshipId)
                {
                    throw new ArgumentException(ExceptionMessages.RelationshipIdConflict, "newRelationshipId");
                }

                if (idPartPair.Value == part)
                {
                    if (oldId != null)
                    {
                        // There are multiple relationship to the same part, 
                        // This case should not exist in current design.
                        throw new InvalidOperationException(ExceptionMessages.MultipleRelationshipsToSamePart);
                    }
                    else
                    {
                        oldId = idPartPair.Key;
                    }
                }
            }

            if (oldId == null)
            {
                // the part is not a sub part.
                throw new ArgumentOutOfRangeException("part");
            }

            // Add a new relationship, and then remove the old relationship
            this.CreateRelationship(part.Uri, TargetMode.Internal, part.RelationshipType, newRelationshipId);
            this.ChildrenParts.Add(newRelationshipId, part);

            this.DeleteRelationship(oldId);
            this.ChildrenParts.Remove(oldId);

            return oldId;
        }

        /// <summary>
        /// Adds the part to the document.
        /// Must use the returned part to operate on the part added to the document.
        /// </summary>
        /// <typeparam name="T">Derived class from OpenXmlPart.</typeparam>
        /// <param name="part">The part to be added to the document.</param>
        /// <returns>The part added to the document. This is different from the passed in part.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "part" is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part is not allowed to be added.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when one instance of the same type part already exists and multiple instances of that type are not allowed.</exception>
        public virtual T AddPart<T>(T part) where T : OpenXmlPart
        {
            return (T)AddPartFrom(part, null);
        }



        /// <summary>
        /// Adds the part to the document with a given relationship identifier (ID).
        /// Must use the returned part to operate on the part added to the document
        /// </summary>
        /// <typeparam name="T">Derived class from OpenXmlPart.</typeparam>
        /// <param name="part">The part to be added to the document.</param>
        /// <param name="id">A unique relationship identifier.</param>
        /// <returns>The part added to the document. This is different from the passed in part.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "part" or the "id" is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part is not allowed to be added.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when one instance of same type part already exists and multiple instances of that type are not allowed.</exception>
        public virtual T AddPart<T>(T part, string id) where T : OpenXmlPart
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            return (T)AddPartFrom(part, id);
        }

        /// <summary>
        /// Adds a relationship for the specified part to this part.
        /// </summary>
        /// <param name="targetPart">The part to add relationship for.</param>
        /// <returns>A unique relationship identifier.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "part" or the "id" is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part is no allowed to be added.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when one instance of same type part already exists and multiple instance of that type is not allowed.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the <paramref name="targetPart"/> and this part are not in the same OpenXmlPackage.</exception>
        public string CreateRelationshipToPart(OpenXmlPart targetPart)
        {
            if (targetPart == null)
            {
                throw new ArgumentNullException("targetPart");
            }
            if (!IsInSamePackage(targetPart))
            {
                throw new InvalidOperationException(ExceptionMessages.PartNotInSamePackage);
            }
                

            OpenXmlPart addedPart = AddPart<OpenXmlPart>(targetPart);
            string relationshipId = this.GetIdOfPart(addedPart);
            Debug.Assert(!string.IsNullOrEmpty(relationshipId));
            return relationshipId;
        }

        /// <summary>
        /// Adds a relationship for the specified part to this part.
        /// </summary>
        /// <param name="targetPart">The part to add a relationship for.</param>
        /// <param name="id">A unique relationship identifier.</param>
        /// <returns>A unique relationship identifier.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "part" or the "id" is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part is no allowed to be added.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when one instance of same type part already exists and multiple instance of that type is not allowed.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the <paramref name="targetPart"/> and this part are not in the same OpenXmlPackage.</exception>
        public string CreateRelationshipToPart(OpenXmlPart targetPart, string id)
        {
            if (targetPart == null)
            {
                throw new ArgumentNullException("targetPart");
            }
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            if (!IsInSamePackage(targetPart))
            {
                throw new InvalidOperationException(ExceptionMessages.PartNotInSamePackage);
            }
#if DEBUG
            OpenXmlPart addedPart = AddPart<OpenXmlPart>(targetPart, id);
            Debug.Assert(this.GetIdOfPart(addedPart) == id);
#else
            AddPart<OpenXmlPart>(targetPart, id);
#endif
            return id;
        }

        /// <summary>
        /// Adds a new part of type T.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        public T AddNewPart<T>() where T : OpenXmlPart, IFixedContentTypePart
        {
            return this.AddNewPartInternal<T>();
        }

        /// <summary>
        /// Adds a new part of type T.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <param name="id">The relationship id.</param>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        public T AddNewPart<T>(string id) where T : OpenXmlPart, IFixedContentTypePart
        {
            return this.AddNewPartInternal<T>(null, id);
        }

        /// <summary>
        /// Adds a new part of type T.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <param name="contentType">The content type of the part. Must match the defined content type if the part is fixed content type.</param>
        /// <param name="id">The relationship id. The id will be automaticly generated if this param is null.</param>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        /// <exception cref="ArgumentOutOfRangeException">When the part is fixed content type and the passed in contentType does not match the defined content type.</exception>
        /// <exception cref="ArgumentNullException">Thrown when "contentType" is null reference.</exception>
        /// <remarks>Mainly used for adding not-fixed content type part - ImagePart, etc</remarks>
        public virtual T AddNewPart<T>(string contentType, string id) where T : OpenXmlPart
        {
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }

            return this.AddNewPartInternal<T>(contentType, id);
        }

        /// <summary>
        /// Adds an extended part ( Application specific part ).
        /// </summary>
        /// <param name="relationshipType">The relationship type of the part.</param>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="targetExt">The desired part name extension in the package.</param>
        /// <returns>The new ExtendedPart.</returns>
        public ExtendedPart AddExtendedPart(string relationshipType, string contentType, string targetExt)
        {
            return AddExtendedPart(relationshipType, contentType, targetExt, null);
        }

        /// <summary>
        /// Adds an extended part ( Application specific part ). 
        /// </summary>
        /// <param name="relationshipType">The relationship type of the part.</param>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="targetExt">The desired part name extension in the package.</param>
        /// <param name="rId">The desired relationship ID.</param>
        /// <returns>The new ExtendedPart.</returns>
        public ExtendedPart AddExtendedPart(string relationshipType, string contentType, string targetExt, string rId)
        {
            ThrowIfObjectDisposed();

            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }

            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }

            if (targetExt == null)
            {
                throw new ArgumentNullException("targetExt");
            }

            ExtendedPart child = new ExtendedPart(relationshipType);

            child.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, contentType, targetExt);

            // add it
            string relationshipId = this.AttachChild(child, rId);

            this.ChildrenParts.Add(relationshipId, child);

            return child;
        }

        /// <summary>
        /// Deletes the specified child part from this part.
        /// </summary>
        /// <param name="id">The relationship ID of the part to be deleted.</param>
        /// <returns>True if the part is successfully removed; otherwise, false. This method also returns false if the part was not found.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "id" is null reference.</exception>
        public bool DeletePart(string id)
        {
            this.ThrowIfObjectDisposed();

            if (id == null)
            {
                throw new ArgumentNullException("id");
            }

            return DeletePartCore(id);
        }

        /// <summary>
        /// Deletes a specified part in the package root layer.
        /// </summary>
        /// <param name="part">The part to be deleted.</param>
        /// <returns>True if the part is successfully removed; otherwise, false. This method also returns false if the part was not found or the parameter is null.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the part is not referenced by this part.</exception>
        public bool DeletePart(OpenXmlPart part)
        {
            this.ThrowIfObjectDisposed();

            //if (part == null)
            //{
            //    throw new ArgumentNullException("part");
            //}
            if (part == null)
            {
                return false;
            }

            if (part.OpenXmlPackage != this.InternalOpenXmlPackage ||
                !this.PartDictionary.ContainsValue(part))
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignOpenXmlPart);
            }

            string relationshipId = this.GetIdOfPart(part);

            return this.DeletePart(relationshipId);
        }

        /// <summary>
        /// Deletes all the parts which are in the passed in collection from the document.
        /// </summary>
        /// <param name="partsToBeDeleted">The parts to be deleted.</param>
        /// <exception cref="ArgumentNullException">Thrown when "partsToBeDeleted" is null reference.</exception>
        public void DeleteParts<T>(IEnumerable<T> partsToBeDeleted) where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            if (partsToBeDeleted == null)
            {
                throw new ArgumentNullException("partsToBeDeleted");
            }

            StringCollection relationshipIds = new StringCollection();

            foreach (OpenXmlPart part in partsToBeDeleted)
            {
                string relationshipId = this.GetIdOfPart(part);
                relationshipIds.Add(relationshipId);
            }

            foreach (string relationshipId in relationshipIds)
            {
                DeletePart(relationshipId);
            }
        }


        /// <summary>
        /// Gets the count of all parts of type T.
        /// </summary>
        /// <typeparam name="T">The type of the part.</typeparam>
        /// <returns>The number of parts of this type.</returns>
        public int GetPartsCountOfType<T>() where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            int partsCount = 0;

            foreach (KeyValuePair<string, OpenXmlPart> idPartPair in this.ChildrenParts)
            {
                if (idPartPair.Value is T)
                {
                    partsCount++;
                }
            }

            return partsCount;
        }

        #endregion

        #region methods to operate annotation

        /// <summary>
        /// Adds an object to the annotation list of this PartContainer.
        /// </summary>
        /// <param name="annotation">The annotation to add to this PartContainer.</param>
        public void AddAnnotation(object annotation)
        {
            if (annotation == null)
            {
                throw new ArgumentNullException("annotation");
            }
            if (this._annotations == null)
            {
                this._annotations = (annotation is object[]) ? new object[] { annotation } : annotation;
            }
            else
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    this._annotations = new object[] { this._annotations, annotation };
                }
                else
                {
                    int index = 0;
                    while ((index < annotations.Length) && (annotations[index] != null))
                    {
                        index++;
                    }
                    if (index == annotations.Length)
                    {
                        Array.Resize<object>(ref annotations, index * 2);
                        this._annotations = annotations;
                    }
                    annotations[index] = annotation;
                }
            }
        }

        /// <summary>
        /// Get the first annotation object of the specified type from this PartContainer.
        /// </summary>
        /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
        /// <returns>The first annotation object of the specified type.</returns>
        public T Annotation<T>() where T : class
        {
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];

                if (annotations == null)
                {
                    return (this._annotations as T);
                }

                for (int i = 0; i < annotations.Length; i++)
                {
                    object obj = annotations[i];

                    if (obj == null)
                    {
                        break;
                    }

                    T t = obj as T;
                    if (t != null)
                    {
                        return t;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Get the first annotation object of the specified type from this PartContainer.
        /// </summary>
        /// <param name="type">The type of the annotation to retrieve.</param>
        /// <returns>The first annotation object of the specified type.</returns>
        public Object Annotation(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (type.IsInstanceOfType(this._annotations))
                    {
                        return this._annotations;
                    }
                }
                else
                {
                    for (int i = 0; i < annotations.Length; i++)
                    {
                        object obj = annotations[i];
                        if (obj == null)
                        {
                            break;
                        }
                        if (type.IsInstanceOfType(obj))
                        {
                            return obj;
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a collection of annotations of the specified type for this PartContainer.
        /// </summary>
        /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
        /// <returns>An IEnumerable(T) of object that contains the annotations for this PartContainer.</returns>
        public IEnumerable<T> Annotations<T>() where T : class
        {
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (this._annotations is T)
                    {
                        yield return (T)this._annotations;
                    }
                }
                else
                {
                    for (int i = 0; i < annotations.Length; i++)
                    {
                        object obj = annotations[i];
                        if (obj == null)
                        {
                            break;
                        }
                        if (obj is T)
                        {
                            yield return (T)obj;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets a collection of annotations of the specified type for this PartContainer.
        /// </summary>
        /// <param name="type">The Type of the annotations to retrieve.</param>
        /// <returns>An IEnumerable(T) of object that contains the annotations for this PartContainer.</returns>
        public IEnumerable<Object> Annotations(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (type.IsInstanceOfType(this._annotations))
                    {
                        yield return this._annotations;
                    }
                }
                else
                {
                    for (int i = 0; i < annotations.Length; i++)
                    {
                        object obj = annotations[i];
                        if (obj == null)
                        {
                            break;
                        }
                        if (type.IsInstanceOfType(obj))
                        {
                            yield return obj;
                        }
                    }
                }
            }


        }

        /// <summary>
        /// Removes the annotations of the specified type from this PartContainer.
        /// </summary>
        /// <typeparam name="T">The Type of the annotations to remove.</typeparam>
        public void RemoveAnnotations<T>() where T : class
        {
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (this._annotations is T)
                    {
                        this._annotations = null;
                    }
                }
                else
                {
                    int index = 0;
                    int num = 0;
                    while (index < annotations.Length)
                    {
                        object obj = annotations[index];
                        if (obj == null)
                        {
                            break;
                        }
                        if (!(obj is T))
                        {
                            annotations[num++] = obj;
                        }
                        index++;
                    }
                    if (num != 0)
                    {
                        while (num < index)
                        {
                            annotations[num++] = null;
                        }
                    }
                    else
                    {
                        this._annotations = null;
                    }
                }
            }

        }

        /// <summary>
        /// Removes the annotations of the specified type from this PartContainer.
        /// </summary>
        /// <param name="type">The Type of the annotations to remove.</param>
        public void RemoveAnnotations(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (this._annotations != null)
            {
                object[] annotations = this._annotations as object[];
                if (annotations == null)
                {
                    if (type.IsInstanceOfType(this._annotations))
                    {
                        this._annotations = null;
                    }
                }
                else
                {
                    int index = 0;
                    int num = 0;
                    while (index < annotations.Length)
                    {
                        object o = annotations[index];
                        if (o == null)
                        {
                            break;
                        }
                        if (!type.IsInstanceOfType(o))
                        {
                            annotations[num++] = o;
                        }
                        index++;
                    }
                    if (num != 0)
                    {
                        while (num < index)
                        {
                            annotations[num++] = null;
                        }
                    }
                    else
                    {
                        this._annotations = null;
                    }
                }
            }

        }

        #endregion

        #endregion

        #region IEnumerable for children parts
  
        /// <summary>
        /// Enumerates all the children parts of the specified type "T" of this part.
        /// </summary>
        /// <typeparam name="T">Derived class from OpenXmlPart.</typeparam>
        /// <returns></returns>
        public IEnumerable<T> GetPartsOfType<T>() where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            foreach (OpenXmlPart part in this.PartDictionary.Values)
            {
                if (part is T)
                {
                    yield return (T)part;
                }
            }
        }

        /// <summary>
        /// Gets all the children parts of the specified type "T" into "partCollection" of this part.
        /// </summary>
        /// <typeparam name="T">Derived class from OpenXmlPart.</typeparam>
        /// <param name="partCollection">The part collection to be filled in.</param>
        /// <exception cref="ArgumentNullException">Thrown when "partCollection" is null reference.</exception>
        public void GetPartsOfType<T>(ICollection<T> partCollection) where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            if (partCollection == null)
            {
                throw new ArgumentNullException("partCollection");
            }

            partCollection.Clear();

            foreach (T part in GetPartsOfType<T>())
            {
                partCollection.Add(part);
            }
        }

        #endregion

        #region internal methods

        /// <summary>
        /// Adds a new part of type T.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <returns>The added part.</returns>
        internal T AddNewPartInternal<T>() where T : OpenXmlPart, IFixedContentTypePart
        {
            ThrowIfObjectDisposed();

            // use reflection to create the instance. As the default contructor of part is not "public"
            T part = (T)Activator.CreateInstance(typeof(T), true);

            try
            {
                InitPart(part, part.ContentType);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new OpenXmlPackageException(ExceptionMessages.AddedPartIsNotAllowed);
            }
            catch (InvalidOperationException)
            {
                throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
            }

            return part;
        }

        /// <summary>
        /// Adds a new part of type T
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="id">The part relationship id.</param>
        /// <returns>The added part.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
        internal T AddNewPartInternal<T>(string contentType, string id) where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            //validate id
            if (id != null)
            {
                if (id == string.Empty)
                {
                    throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, "id");
                }

                try
                {
                    XmlConvert.VerifyNCName(id);
                }
                catch (XmlException)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidXmlIDStringException, "id");
                }

                if (this.ChildrenParts.ContainsKey(id))
                {
                    throw new ArgumentException(ExceptionMessages.RelationshipIdConflict, "id");
                }
            }

            if (contentType == string.Empty)
            {
                throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, "contentType");
            }

            // use reflection to create the instance. As the default contructor of part is not "public"
            T part = (T)Activator.CreateInstance(typeof(T), true);

            if (part is ExtendedPart)
            {
                throw new ArgumentOutOfRangeException("T", ExceptionMessages.ExtendedPartNotAllowed);
            }

            if (contentType != null && part.IsContentTypeFixed && part.ContentType != contentType)
            {
                // should we throw? or just ignore?
                // throw new OpenXmlPackageException(ExceptionMessages.ErrorContentType);
                throw new ArgumentOutOfRangeException("contentType", ExceptionMessages.ErrorContentType);
            }

            if (contentType == null)
            {
                contentType = part.ContentType;
            }

            try
            {
                InitPart(part, contentType, id);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new OpenXmlPackageException(ExceptionMessages.AddedPartIsNotAllowed);
            }
            catch (InvalidOperationException)
            {
                throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
            }

            return part;
        }

        /// <summary>
        /// Initilizes a new created part
        /// </summary>
        /// <typeparam name="T">The type of the part, must be derived from OpenXmlPart.</typeparam>
        /// <param name="newPart">The part to be initialized.</param>
        /// <param name="contentType">The content type of the part.</param>
        internal void InitPart<T>(T newPart, string contentType) where T : OpenXmlPart
        {
            InitPart(newPart, contentType, null);
        }

        /// <summary>
        /// Initilizes a new created part
        /// </summary>
        /// <typeparam name="T">The type of the part, must be derived from OpenXmlPart.</typeparam>
        /// <param name="newPart">The part to be initialized.</param>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="id">The relationship id.</param>
        internal virtual void InitPart<T>(T newPart, string contentType, string id) where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }

            if (contentType == string.Empty)
            {
                throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException);
            }

            PartConstraintRule partConstraintRule;

            if (GetPartConstraint().TryGetValue(newPart.RelationshipType, out partConstraintRule))
            {
                if (!partConstraintRule.MaxOccursGreatThanOne)
                {
                    if (this.GetSubPartOfType<T>() != null)
                    {
                        // already have one, can not add new one.
                        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
                    }
                }

                // Invalid part (same relationship type, but wrong (is different to be expected )content type 
                if (partConstraintRule.PartContentType != null && contentType != partConstraintRule.PartContentType)
                {
                    throw new ArgumentOutOfRangeException("newPart");
                }

                newPart.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, contentType, null);

                string relationshipId = this.AttachChild(newPart, id);

                this.ChildrenParts.Add(relationshipId, newPart);

                return;
            }
            //else if (newPart is ExtensionPart)
            //{
            //    newPart.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, contentType, null);

            //    // add it and get the id
            //    string relationshipId = this.AttachChild(newPart);

            //    this.ChildParts.Add(relationshipId, newPart);

            //    return;
            //}
            else
            {
                throw new ArgumentOutOfRangeException("newPart");
            }
        }

        /// <summary>
        /// Adds a new part.
        /// </summary>
        /// <param name="subPart">The part to be added.</param>
        /// <param name="rId">A unique relationship identifier. null to create new id.</param>
        /// <returns>The added part. May diff with the passed in part.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "subPart" is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part is no allowed to be added.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when one instance of same type part already exists and multiple instance of that type is not allowed.</exception>
        internal virtual OpenXmlPart AddPartFrom(OpenXmlPart subPart, string rId)
        {
            this.ThrowIfObjectDisposed();

            if (subPart == null)
            {
                throw new ArgumentNullException("subPart");
            }

            if (subPart.OpenXmlPackage == this.InternalOpenXmlPackage)
            {
                if (this.IsChildPart(subPart))
                {
                    if (rId != null && rId != this.GetIdOfPart(subPart))
                    {
                        // Do NOT allow one sub part is referenced more than once.
                        throw new InvalidOperationException(ExceptionMessages.PartExistsWithDifferentRelationshipId);
                    }
                    else
                    {
                        // just return it
                        // an shared part
                        return subPart;
                    }
                }
            }

            PartConstraintRule partConstraintRule;

            if (!GetPartConstraint().TryGetValue(subPart.RelationshipType, out partConstraintRule))
            {
                if (subPart is ExtendedPart) // || subPart is ExtensionPart)
                {
                    return AddSubPart(subPart, rId);
                }
                else
                {
                    //throw new ArgumentOutOfRangeException("subPart");                    
                    throw new InvalidOperationException(ExceptionMessages.AddedPartIsNotAllowed);
                }
            }
            else
            {
                if (partConstraintRule.PartContentType != null && subPart.ContentType != partConstraintRule.PartContentType)
                {
                    //throw new ArgumentOutOfRangeException("subPart");                    
                    throw new InvalidOperationException(ExceptionMessages.AddedPartIsNotAllowed);
                }

                if (partConstraintRule.MaxOccursGreatThanOne)
                {
                    return AddSubPart(subPart, rId);
                }
                else
                {
                    // Bug #19351
                    // return SetSubPart(subPart, rId);
                    OpenXmlPart child = this.GetSubPart(subPart.RelationshipType);

                    if (child != null)
                    {
                        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
                    }

                    return SetSubPart(subPart, rId);
                }
            }

        }

        /// <summary>
        /// Sets part which is only one in the parent
        /// </summary>
        /// <param name="part"></param>
        /// <param name="rId">A unique relationship identifier.</param>
        /// <returns>The part added to the parent. Different with the passed in part.</returns>
        internal OpenXmlPart SetSubPart(OpenXmlPart part, string rId)
        {
            if (part == null)
            {
                throw new ArgumentNullException("part");
            }

            // only one part has the same relationshipType allowed
            // delete the old one
            //OpenXmlPart child = this.GetSubPart(part.RelationshipType);

            //if (child != null)
            //{
            //    // already have one, remove
            //    // TODO: should we throw?
            //    this.DeletePart(child);
            //}

            return this.AddSubPart(part, rId);

        }

        /// <summary>
        /// Adds the part to the parent. 
        /// </summary>
        /// <param name="part"></param>
        /// <param name="rId">A unique relationship identifier.</param>
        /// <returns>The part added to the parent. Different with the passed in part.</returns>
        internal OpenXmlPart AddSubPart(OpenXmlPart part, string rId)
        {
            if (part == null)
            {
                throw new ArgumentNullException("part");
            }

            // check if part is shared
            if (part.OpenXmlPackage == this.InternalOpenXmlPackage)
            {
                // it is a part shared in the same package
                string relationshipId = this.AttachChild(part, rId);

                this.ChildrenParts.Add(relationshipId, part);

                return part;
            }
            else
            {
                return this.AddSubPartFromOtherPackage(part, false, rId);
            }
        }

        // Add part which is from other package to this package
        // All child parts will also be added
        // partDictionary used to map new part from the source part and to detect cycle reference in source part
        internal OpenXmlPart AddSubPartFromOtherPackage(OpenXmlPart part, bool keepIdAndUri, string rId)
        {
            Dictionary<OpenXmlPart, OpenXmlPart> partDictionary = new Dictionary<OpenXmlPart, OpenXmlPart>();
            Dictionary<DataPart, DataPart> dataPartsDictionary = new Dictionary<DataPart, DataPart>();
            return this.AddSubPartFromOtherPackage(part, partDictionary, dataPartsDictionary, keepIdAndUri, rId);
        }

        // Add part which is from other package to this package
        // All child parts will also be added
        // partDictionary used to map new part from the source part and to detect cycle reference in source part
        private OpenXmlPart AddSubPartFromOtherPackage(OpenXmlPart part, IDictionary<OpenXmlPart, OpenXmlPart> partDictionary,
                                                        IDictionary<DataPart, DataPart> dataPartsDictionary,
                                                        bool keepIdAndUri, string rId)
        {
            if (keepIdAndUri)
            {
                if (rId == null)
                {
                    throw new ArgumentNullException("rId");
                }
            }

            OpenXmlPart child;
            if (partDictionary.TryGetValue(part, out child))
            {
                // already processed

                string relationshipId;

                relationshipId = this.AttachChild(child, rId);

                this.ChildrenParts.Add(relationshipId, child);

                return child;

            }
            else
            {
                // find the current extension of the file

                // new a part and add it
                child = CreateOpenXmlPart(part.RelationshipType);

                // try to keep the same name
                child.CreateInternal2(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, part.ContentType, part.Uri);

                //if (keepIdAndUri)
                //{
                //    child.CreateInternal2(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, part.ContentType, part.Uri);
                //}
                //else
                //{
                //    child.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, part.ContentType, null);
                //}

                // copy the stream
                using (Stream stream = part.GetStream())
                {
                    child.FeedData(stream);
                }

                string relationshipId = this.AttachChild(child, rId);

                this.ChildrenParts.Add(relationshipId, child);

                // add to processed node list
                partDictionary.Add(part, child);

                // copy all the child parts recursively
                // call AddSubPart( ) so that make sure all descendant parts are added to the package.
                foreach (IdPartPair idPartPair in part.Parts)
                {
                    child.AddSubPartFromOtherPackage(idPartPair.OpenXmlPart, partDictionary, dataPartsDictionary, true, idPartPair.RelationshipId);
                }

                // copy all external relationships
                foreach (ExternalRelationship externalRel in part.ExternalRelationships)
                {
                    child.AddExternalRelationship(externalRel.RelationshipType, externalRel.Uri, externalRel.Id);
                }

                // copy all hyperlink relationships
                foreach (HyperlinkRelationship hyperlinkRel in part.HyperlinkRelationships)
                {
                    child.AddHyperlinkRelationship(hyperlinkRel.Uri, hyperlinkRel.IsExternal, hyperlinkRel.Id);
                }


                // First, we need copy the referenced media data part.
                foreach (var dataPartReferenceRelationship in part.DataPartReferenceRelationships)
                {
                    if (!dataPartsDictionary.ContainsKey(dataPartReferenceRelationship.DataPart))
                    {
                        dataPartsDictionary.Add(dataPartReferenceRelationship.DataPart, null);
                    }
                }

                foreach (var item in dataPartsDictionary)
                {
                    if (item.Value == null)
                    {
                        var dataPart = item.Key;

                        MediaDataPart newDataPart = new MediaDataPart();

                        newDataPart.CreateInternal2(this.InternalOpenXmlPackage, dataPart.ContentType, dataPart.Uri);

                        // copy the stream
                        using (Stream stream = dataPart.GetStream())
                        {
                            newDataPart.FeedData(stream);
                        }

                        this.InternalOpenXmlPackage.AddDataPartToList(newDataPart);

                        dataPartsDictionary[dataPart] = newDataPart;
                    }
                }

                // then create data part reference relationship
                foreach (var dataPartReferenceRelationship in part.DataPartReferenceRelationships)
                {
                    MediaDataPart newDataPart = (MediaDataPart)dataPartsDictionary[dataPartReferenceRelationship.DataPart];
                    Debug.Assert(newDataPart != null);

                    DataPartReferenceRelationship newDataPartReference = DataPartReferenceRelationship.CreateDataPartReferenceRelationship(this, newDataPart, dataPartReferenceRelationship.RelationshipType, dataPartReferenceRelationship.Id);
                    this.ReferenceRelationshipList.AddLast(newDataPartReference);
                }

                return child;
            }

        }


        /// <summary>
        /// Attachs the child to the package (create the relationship)
        /// </summary>
        /// <param name="part">The part to be attached.</param>
        /// <returns>The relationship ID.</returns>
        internal string AttachChild(OpenXmlPart part)
        {
            return AttachChild(part, null);
        }


        /// <summary>
        /// Attachs the child to the package (create the relationship)
        /// </summary>
        /// <param name="part">The part to be attached.</param>
        /// <param name="rId">The desired relationship ID.</param>
        /// <returns>The relationship ID.</returns>
        internal string AttachChild(OpenXmlPart part, string rId)
        {
            if (rId == null)
            {
                PackageRelationship relationship = this.CreateRelationship(part.Uri, TargetMode.Internal, part.RelationshipType);
                return relationship.Id;
            }
            else
            {
                PackageRelationship relationship = this.CreateRelationship(part.Uri, TargetMode.Internal, part.RelationshipType, rId);
                return relationship.Id;
            }
        }

        /// <summary>
        /// Deletes the specified part in the package root layer.
        /// </summary>
        /// <param name="id">The relationship ID of the part to be deleted.</param>
        /// <returns>true if the part is successfully removed; otherwise, false. This method also returns false if the part was not found.</returns>
        internal bool DeletePartCore(string id)
        {
            Dictionary<OpenXmlPart, bool> liveParts = new Dictionary<OpenXmlPart, bool>();
            Dictionary<OpenXmlPart, bool> processedParts = new Dictionary<OpenXmlPart, bool>();

            OpenXmlPart child = GetPartById(id);

            if (child == null)
            {
                // TODO: should we throw? or just return?
                return false;
            }

            child.FindAllReachableParts(processedParts);

            // remove from the collection
            this.ChildrenParts.Remove(id);

            // find all live parts
            this.InternalOpenXmlPackage.FindAllReachableParts(liveParts);

            Dictionary<OpenXmlPart, bool> toBeDeletedParts = new Dictionary<OpenXmlPart, bool>();

            foreach (OpenXmlPart part in processedParts.Keys)
            {
                if (!liveParts.ContainsKey(part))
                {
                    toBeDeletedParts.Add(part, false);
                }
            }

            processedParts[child] = true;

            if (toBeDeletedParts.Count == 0)
            {
                // the child part is shared by other part, just delete the relationship
                this.DeleteRelationship(id);
            }
            else
            {
                Debug.Assert(toBeDeletedParts.ContainsKey(child));

                child.DeleteAllParts(processedParts, toBeDeletedParts);

                this.DeleteRelationship(id);

                bool partRemoved;

                if (toBeDeletedParts.TryGetValue(child, out partRemoved))
                {
                    if (!partRemoved)
                    {
                        child.Destroy();
                        toBeDeletedParts[child] = true;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Deletes all the parts of the specified type.
        /// </summary>
        internal void DeletePartsOfType<T>() where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            StringCollection relationshipIds = new StringCollection();

            foreach (KeyValuePair<string, OpenXmlPart> idPartPair in this.ChildrenParts)
            {
                if (idPartPair.Value is T)
                {
                    relationshipIds.Add(idPartPair.Key);
                }
            }

            foreach (string relationshipId in relationshipIds)
            {
                DeletePart(relationshipId);
            }
        }

        /// <summary>
        /// Deletes all the parts which is the specified part type from package recursively.
        /// </summary>
        internal void DeletePartsRecursivelyOfTypeBase<T>() where T : OpenXmlPart
        {
            this.ThrowIfObjectDisposed();

            DeletePartsOfType<T>();

            // remove recursively 
            foreach (OpenXmlPart child in this.ChildrenParts.Values)
            {
                child.DeletePartsRecursivelyOfTypeBase<T>();
            }
        }

        /// <summary>
        /// Removes all child parts of this part.
        /// </summary>
        internal void DeleteAllParts(Dictionary<OpenXmlPart, bool> processedParts, Dictionary<OpenXmlPart, bool> toBeDeletedParts)
        {
            ThrowIfObjectDisposed();

            if (this.PartDictionary.Count > 0)
            {
                Collection<OpenXmlPart> subPartsShouldBeDeleted = new Collection<OpenXmlPart>();

                foreach (KeyValuePair<string, OpenXmlPart> idPartPair in this.ChildrenParts)
                {
                    bool isDeleted;

                    // do not process it again if already processed, cycle reference defense
                    if (!processedParts[idPartPair.Value])
                    {
                        // mark it as processed
                        processedParts[idPartPair.Value] = true;
                        if (toBeDeletedParts.TryGetValue(idPartPair.Value, out isDeleted))
                        {
                            // only delete the physical part from the package when it should be deleted and has not been deleted.
                            if (!isDeleted)
                            {
                                idPartPair.Value.DeleteAllParts(processedParts, toBeDeletedParts);
                                subPartsShouldBeDeleted.Add(idPartPair.Value);
                            }
                        }
                    }
                    // else, already processed, just delete the relationship
                    // TODO: is this necessary? Will Package.DeletePart also delete it's .rels?
                    DeleteRelationship(idPartPair.Key);
                }
                this.ChildrenParts.Clear();

                foreach (OpenXmlPart child in subPartsShouldBeDeleted)
                {
                    // delete the part from the package
                    child.Destroy();
                    toBeDeletedParts[child] = true;
                }
            }
        }

        /// <summary>
        /// Gets the sub part which is the specified relationship type.
        /// </summary>
        /// <param name="relationshipType">The relationship type of the part.</param>
        /// <returns>return null if no one.</returns>
        /// <remarks>Only used for maxOccurence=1 part.</remarks>
        internal OpenXmlPart GetSubPart(string relationshipType)
        {
            ThrowIfObjectDisposed();

            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }

            // there should be only one part of this type
            foreach (OpenXmlPart part in this.PartDictionary.Values)
            {
                if (part.RelationshipType == relationshipType)
                {
                    return part;
                }
            }

            return null;
        }

        internal T GetSubPartOfType<T>() where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            foreach (T part in GetPartsOfType<T>())
            {
                return part;
            }
            return null;
        }

        internal bool IsChildPart(OpenXmlPart part)
        {
            ThrowIfObjectDisposed();

            if (part == null)
            {
                throw new ArgumentNullException("part");
            }

            if (part.OpenXmlPackage != this.InternalOpenXmlPackage)
            {
                throw new ArgumentOutOfRangeException("part");
            }

            return this.PartDictionary.ContainsValue(part);
        }

        /// <summary>
        /// Creates an strong typed OpenXmlPart instance based on the relationship type. For and only for loading.
        /// </summary>
        /// <param name="relationshipType">The relationship type of the new part.</param>
        /// <returns>The created new part.</returns>
        internal OpenXmlPart CreateOpenXmlPart(string relationshipType)
        {
            ThrowIfObjectDisposed();

            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }

            OpenXmlPart part = null;

            if (this.GetPartConstraint().ContainsKey(relationshipType))
            {
                part = CreatePartCore(relationshipType);
            }
            else
            {
                part = GlobalPartFactory.CreateOpenXmlPart(this.InternalOpenXmlPackage, relationshipType);
            }

            return part;
        }

        /// <summary>
        /// Loads all children parts and relationships recursively. 
        /// </summary>
        /// <param name="openXmlPackage">The OpenXmlPackage.</param>
        /// <param name="sourcePart">The source part. Be null if loading from the package root.</param>
        /// <param name="relationshipCollection">The relationships of the source part (or the package).</param>
        /// <param name="loadedParts">Temp collection to detect loaded (shared) parts.</param>
        internal void LoadReferencedPartsAndRelationships(OpenXmlPackage openXmlPackage, OpenXmlPart sourcePart,
                                                     RelationshipCollection relationshipCollection, Dictionary<Uri, OpenXmlPart> loadedParts)
        {
            DataPart dataPart;
            foreach (RelationshipProperty relationship in relationshipCollection)
            {
                if (relationship.RelationshipType == HyperlinkRelationship.RelationshipTypeConst)
                {
                    // Fix bug #517956 - both internal and external hyperlinks should be loaded as HyperlinkRelationship.
                    this.ReferenceRelationshipList.AddLast(new HyperlinkRelationship(relationship.TargetUri, relationship.TargetMode == TargetMode.External ? true : false, relationship.Id) { Container = this });
                }
                else
                {
                    if (relationship.TargetMode == TargetMode.Internal)
                    {
                        if (!relationship.TargetUri.ToString().Equals("NULL", StringComparison.OrdinalIgnoreCase)) // fix bug O14#12085
                        {
                            // Resolve the Relationship Target Uri
                            //   so the Document Part can be retrieved.

                            // when sourcePart is null, use the package root as sourceUri.
                            Uri sourceUri = sourcePart == null ? new Uri("/", UriKind.Relative) : sourcePart.Uri;
                            Uri uriTarget = PackUriHelper.ResolvePartUri(sourceUri, relationship.TargetUri);

                            OpenXmlPart child;

                            if (loadedParts.TryGetValue(uriTarget, out child))
                            {
                                // shared part, already loaded

                                // shared part should have same relationship type
                                if (child.RelationshipType != relationship.RelationshipType)
                                {
                                    throw new OpenXmlPackageException(ExceptionMessages.SamePartWithDifferentRelationshipType);

                                }
                                this.ChildrenParts.Add(relationship.Id, child);
                            }
                            else if (DataPartReferenceRelationship.IsDataPartReferenceRelationship(relationship.RelationshipType))
                            {
                                if ((dataPart = openXmlPackage.FindDataPart(uriTarget)) == null)
                                {
                                    // Load the part as MediaDataPart.
                                    dataPart = new MediaDataPart();
                                    var packagePart = openXmlPackage.Package.GetPart(uriTarget);
                                    dataPart.Load(openXmlPackage, packagePart);
                                    openXmlPackage.AddDataPartToList(dataPart);
                                }

                                // Already loaded data part. Create reference relationship.
                                var referenceRelationship = DataPartReferenceRelationship.CreateDataPartReferenceRelationship(this, dataPart, relationship.RelationshipType, relationship.Id);
                                this.ReferenceRelationshipList.AddLast(referenceRelationship);

                            }
                            else
                            {
                                child = CreateOpenXmlPart(relationship.RelationshipType);
                                child.MCSettings = openXmlPackage.MarkupCompatibilityProcessSettings;
                                // add it to loaded part list
                                loadedParts.Add(uriTarget, child);

                                child.Load(openXmlPackage, sourcePart, uriTarget, relationship.Id, loadedParts);

                                this.ChildrenParts.Add(relationship.Id, child);
                            }
                        }
                    }
                    else
                    {
                        this.ReferenceRelationshipList.AddLast(new ExternalRelationship(relationship.TargetUri, relationship.RelationshipType, relationship.Id) { Container = this });
                    }
                }
            }
        }

#pragma warning disable 0618 // CS0618: A class member was marked with the Obsolete attribute, such that a warning will be issued when the class member is referenced.

        /// <summary>
        /// Validates the package ( do not validate the xml content in each part ).
        /// </summary>
        /// <param name="validationSettings">OpenXmlPackageValidationSettings for validation events.</param>
        /// <param name="processedParts">Parts already processed.</param>
        internal void ValidateInternal(OpenXmlPackageValidationSettings validationSettings, Dictionary<OpenXmlPart, bool> processedParts)
        {
            EventHandler<OpenXmlPackageValidationEventArgs> valEventHandler = validationSettings.GetEventHandler();

            Debug.Assert(valEventHandler != null);

            this.ValidateDataPartReferenceRelationships(validationSettings);

            // count all parts of same type
            Dictionary<string, int> partOccurs = new Dictionary<string, int>();

            foreach (OpenXmlPart part in this.ChildrenParts.Values)
            {
                int occurs = 0;
                partOccurs.TryGetValue(part.RelationshipType, out occurs);

                partOccurs[part.RelationshipType] = occurs + 1;


                if (!(this is ExtendedPart) &&
                    !this.GetPartConstraint().Keys.Contains(part.RelationshipType) &&
                    part.IsInVersion(validationSettings.FileFormat))
                {
                    OpenXmlPackageValidationEventArgs eventArgs = new OpenXmlPackageValidationEventArgs();
                    eventArgs.MessageId = "PartIsNotAllowed";
                    eventArgs.PartClassName = part.RelationshipType;
                    eventArgs.Part = this.ThisOpenXmlPart;
                    eventArgs.SubPart = part;

                    valEventHandler(this, eventArgs);
                }

                // if the part is not defined in this version, then should not report error, just treat it as ExtendedPart.
            }

            foreach (KeyValuePair<string, PartConstraintRule> constraintRulePair in this.GetPartConstraint())
            {
                string relatinshipType = constraintRulePair.Key;
                PartConstraintRule constraintRule = constraintRulePair.Value;

                // validate the required parts
                if (constraintRule.MinOccursIsNonZero
                    // only check rules apply to the specified version.
                    && constraintRule.FileFormat.Includes(validationSettings.FileFormat))
                {
                    // must have one
                    if (null == this.GetSubPart(relatinshipType))
                    {
                        OpenXmlPackageValidationEventArgs eventArgs = new OpenXmlPackageValidationEventArgs();
                        eventArgs.MessageId = "RequiredPartDoNotExist";
                        eventArgs.PartClassName = constraintRule.PartClassName;
                        eventArgs.Part = this.ThisOpenXmlPart;

                        valEventHandler(this, eventArgs);
                    }
                }

                // check for parts MaxOccursGreatThanOne=false, but do have multiple instance
                if (!constraintRule.MaxOccursGreatThanOne 
                    // only check rules apply to the specified version.
                    && constraintRule.FileFormat.Includes(validationSettings.FileFormat))
                {
                    int occurs = 0;
                    if (partOccurs.TryGetValue(relatinshipType, out occurs))
                    {
                        if (occurs > 1)
                        {
                            OpenXmlPackageValidationEventArgs eventArgs = new OpenXmlPackageValidationEventArgs();
                            eventArgs.MessageId = "OnlyOnePartAllowed";
                            eventArgs.PartClassName = constraintRule.PartClassName;
                            eventArgs.Part = this.ThisOpenXmlPart;
#if DEBUG
                            eventArgs.SubPart = this.GetSubPart(relatinshipType);
#endif
                            valEventHandler(this, eventArgs);
                        }
                    }
                }
            }


            foreach (OpenXmlPart part in this.ChildrenParts.Values)
            {
                if (!processedParts.ContainsKey(part))
                {
                    if (!(part is ExtendedPart))//&& ! (part is ExtensionPart))
                    {
                        PartConstraintRule rule = null;

                        if (this.GetPartConstraint().TryGetValue(part.RelationshipType, out rule))
                        {
                            if (rule.FileFormat.Includes(validationSettings.FileFormat))
                            {
                                // validate content type
                                if (rule.PartContentType != null && part.ContentType != rule.PartContentType)
                                {
                                    OpenXmlPackageValidationEventArgs eventArgs = new OpenXmlPackageValidationEventArgs();
                                    string message = String.Format(CultureInfo.CurrentUICulture,
                                                                        ExceptionMessages.InvalidContentTypePart,
                                                                        rule.PartContentType);
                                    eventArgs.Message = message;
                                    eventArgs.MessageId = "InvalidContentTypePart";
                                    eventArgs.SubPart = part;
                                    eventArgs.Part = this.ThisOpenXmlPart;

                                    valEventHandler(this, eventArgs);
                                }
                            }
                            else
                            {
                                // if the part is not defined in this version, then should not report error, just treat it as ExtendedPart.
                            }
                        }
                    }
                    else
                    {
#if DEBUG
                        // check the relationship type
                        if (part.RelationshipType.StartsWith(@"http://schemas.openxmlformats.org", StringComparison.OrdinalIgnoreCase))
                        {
                            OpenXmlPackageValidationEventArgs eventArgs = new OpenXmlPackageValidationEventArgs();
                            eventArgs.MessageId = "ExtendedPartIsOpenXmlPart";
                            eventArgs.SubPart = part;
                            eventArgs.Part = this.ThisOpenXmlPart;

                            valEventHandler(this, eventArgs);
                        }
#endif
                    }
                    processedParts.Add(part, true);

                    part.ValidateInternal(validationSettings, processedParts);
                }
            }
        }

        internal void ValidateDataPartReferenceRelationships(OpenXmlPackageValidationSettings validationSettings)
        {
            EventHandler<OpenXmlPackageValidationEventArgs> valEventHandler = validationSettings.GetEventHandler();
            Debug.Assert(valEventHandler != null);

            // At current, only meida / audio / video reference. There are all [0, unbounded].
            // So just check whether the reference is allowed.

            foreach (var dataPartReference in this.DataPartReferenceRelationships)
            {
                PartConstraintRule constraintRule;
                if (!this.GetDataPartReferenceConstraint().TryGetValue(dataPartReference.RelationshipType, out constraintRule))
                {
                    OpenXmlPackageValidationEventArgs eventArgs = new OpenXmlPackageValidationEventArgs();
                    eventArgs.MessageId = "DataPartReferenceIsNotAllowed";
                    eventArgs.PartClassName = dataPartReference.RelationshipType;
                    eventArgs.Part = this.ThisOpenXmlPart;
                    eventArgs.SubPart = null;
                    eventArgs.DataPartReferenceRelationship = dataPartReference;

                    valEventHandler(this, eventArgs);
                }
            }
        }

        #endregion

        #region abstract / virtual internal methods to be implemented by derived classes.

        /// <summary>
        /// Internal OpenXmlPackage instance 
        /// </summary>
        abstract internal OpenXmlPackage InternalOpenXmlPackage { get; }

        abstract internal OpenXmlPart ThisOpenXmlPart { get; }

        /// <summary>
        /// Get the constraint rule
        /// </summary>
        /// <returns>The constraint rule.</returns>
        abstract internal IDictionary<string, PartConstraintRule> GetPartConstraint();

        /// <summary>
        /// Get the constraint rule of DataPartReferenceRelationship.
        /// </summary>
        /// <returns>The constraint rule.</returns>
        abstract internal IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint();

        /// <summary>
        /// Test whether the object is already disposed.
        /// </summary>
        abstract protected void ThrowIfObjectDisposed();

        /// <summary>
        /// Create the object of strong typed class according the relationshipType
        /// </summary>
        /// <param name="relationshipType">The relationship type of the class.</param>
        /// <returns>A new object of strong typed class.</returns>
        virtual internal OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();

            return new ExtendedPart(relationshipType);
        }

        abstract internal OpenXmlPart NewPart(string relationshipType, string contentType);

        abstract internal void DeleteRelationship(string id);
        abstract internal PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType);
        abstract internal PackageRelationship CreateRelationship(Uri targetUri, TargetMode targetMode, string relationshipType, string id);

        // find all reachable parts from the package root, the dictionary also used for cycle reference defence
        abstract internal void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts);

        #endregion

        // Checks if the target part is in the same OpenXmlPackage as this part.
        private bool IsInSamePackage(OpenXmlPart targetPart)
        {
            return this.InternalOpenXmlPackage != null &&
                targetPart.OpenXmlPackage != null &&
                targetPart.OpenXmlPackage == this.InternalOpenXmlPackage;
        }

    }

    /// <summary>
    /// Represents a (RelationshipId, OpenXmlPart) pair.
    /// </summary>
    public class IdPartPair
    {
        private string _id;
        private OpenXmlPart _part;

        /// <summary>
        /// Gets or sets the relationship ID in the pair.
        /// </summary>
        public string RelationshipId
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Gets or sets the OpenXmlPart in the pair.
        /// </summary>
        public OpenXmlPart OpenXmlPart
        {
            get { return this._part; }
            set { this._part = value; }
        }

        /// <summary>
        /// Initializes a new instance of the IdPartPair with the specified id and part.
        /// </summary>
        /// <param name="id">The relationship ID.</param>
        /// <param name="part">The OpenXmlPart.</param>
        public IdPartPair(string id, OpenXmlPart part)
        {
            this.RelationshipId = id;
            this.OpenXmlPart = part;
        }

        /// <summary>
        /// Determines whether this instance and another specified IdPartPair object have the same value. 
        /// </summary>
        /// <param name="value">An IdPartPair.</param>
        /// <returns>True if the value of the value parameter is the same as this instance; otherwise, false.</returns>
        public bool Equals(IdPartPair value)
        {
            //Check for null
            if (value == null)
            {
                return false;
            }

            return (this._id.Equals(value._id)) && (this._part == value._part);
        }
    }


    /// <summary>
    /// Global OpenXmlPart factory to create strong typed OpenXmlPart based on the relationship type.
    /// </summary>
    internal static partial class GlobalPartFactory
    {
        /// <summary>
        /// Create an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="openXmlPackage">The container OpenXmlPackage.</param>
        /// <param name="relationshipType">The relationship type of the target part.</param>
        /// <returns>An instance of OpenXmlPart.</returns>
        internal static OpenXmlPart CreateOpenXmlPart(OpenXmlPackage openXmlPackage, string relationshipType)
        {
            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }

            OpenXmlPart openXmlPart = null;

            CreatePartCore(openXmlPackage, relationshipType, ref openXmlPart);

            if (openXmlPart == null)
            {
                openXmlPart = new ExtendedPart(relationshipType); 
            }

            return openXmlPart;
        }

        /// <summary>
        /// Create an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="openXmlPackage">The container OpenXmlPackage.</param>
        /// <param name="relationshipType">The relationship type of the target part.</param>
        /// <param name="openXmlPart">The created instance of OpenXmlPart.</param>
        /// <remarks>This partial method will be generated by code generaotr.</remarks>
        static partial void CreatePartCore(OpenXmlPackage openXmlPackage, string relationshipType, ref OpenXmlPart openXmlPart);
    }

    /************************ the following are code template for code generator ****** 
    /// <summary>
    /// Global OpenXmlPart factory to create strong typed OpenXmlPart based on the relationship type.
    /// </summary>
    internal static partial class GlobalPartFactory
    {
        /// <summary>
        /// Create an instance of OpenXmlPart according to the given relationship type.
        /// </summary>
        /// <param name="relationshipType">The relationship type.</param>
        /// <param name="openXmlPart">The created instance of OpenXmlPart.</param>
        /// <remarks>This partial method will be generated by code generator.</remarks>
        static partial void CreatePartCore(string relationshipType, ref OpenXmlPart openXmlPart)
        {
            if (relationshipType == null)
            {
                throw new ArgumentNullException("relationshipType");
            }
            switch (relationshipType)
            {
                default:
                    return;
            }
        }
    }
    ******************************/
}
