﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO.Packaging;
using System.Linq;
using System.Xml;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the base class for OpenXmlPackage and OpenXmlPart.
    /// </summary>
    public abstract partial class OpenXmlPartContainer
    {
#pragma warning disable SA1401 // Fields should be private
        private protected IFeatureCollection? _features;
#pragma warning restore SA1401 // Fields should be private

        /// <summary>
        /// Initializes OpenXmlPartContainer.
        /// </summary>
        [SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Registered to be disposed with container")]
        protected OpenXmlPartContainer()
        {
            var childFeatures = new PartRelationshipsFeature(this);

            Features.Set<IPartRelationshipsFeature>(childFeatures);
            Features.Set<IReferenceRelationshipsFeature>(childFeatures);
        }

        /// <summary>
        /// Gets the children parts IDictionary.
        /// </summary>
        internal IPartRelationshipsFeature ChildrenRelationshipParts
        {
            get
            {
                ThrowIfObjectDisposed();
                return Features.GetRequired<IPartRelationshipsFeature>();
            }
        }

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

            if (referenceRelationship is null)
            {
                throw new ArgumentNullException(nameof(referenceRelationship));
            }

            if (referenceRelationship.Id is null || referenceRelationship.Container != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ReferenceRelationshipIsNotReferenced);
            }

            if (Features.GetRequired<IReferenceRelationshipsFeature>().Remove(referenceRelationship.Id))
            {
                return;
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

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (Features.GetRequired<IReferenceRelationshipsFeature>().Remove(id))
            {
                return;
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

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (Features.GetRequired<IReferenceRelationshipsFeature>().TryGetRelationship(id, out var existing))
            {
                return existing;
            }

            throw new KeyNotFoundException(ExceptionMessages.NoSpecifiedReferenceRelationship);
        }

        #endregion

        #region methods to operate ExternalRelationship

        /// <summary>
        /// Gets all external relationships.
        /// Hyperlink relationships are not included, use HyperlinkRelationship property to enumerate hyperlink relationships.
        /// </summary>
        public IEnumerable<ExternalRelationship> ExternalRelationships
        {
            get
            {
                ThrowIfObjectDisposed();
                return Features.GetRequired<IReferenceRelationshipsFeature>().Relationships.OfType<ExternalRelationship>();
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

            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            if (externalUri is null)
            {
                throw new ArgumentNullException(nameof(externalUri));
            }

            if (relationshipType == HyperlinkRelationship.RelationshipTypeConst)
            {
                throw new InvalidOperationException(ExceptionMessages.UseAddHyperlinkRelationship);
            }

            return Features.GetRequired<IReferenceRelationshipsFeature>().CreateExternalRelationship(relationshipType, externalUri);
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
        /// <exception cref="InvalidOperationException">Thrown when the relationship type is hyperlink relationship type (http://schemas.openxmlformats.org/officeDocument/2006/relationships/hyperlink). </exception>
        public ExternalRelationship AddExternalRelationship(string relationshipType, Uri externalUri, string id)
        {
            ThrowIfObjectDisposed();

            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            if (externalUri is null)
            {
                throw new ArgumentNullException(nameof(externalUri));
            }

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (relationshipType == HyperlinkRelationship.RelationshipTypeConst)
            {
                throw new InvalidOperationException(ExceptionMessages.UseAddHyperlinkRelationship);
            }

            return Features.GetRequired<IReferenceRelationshipsFeature>().CreateExternalRelationship(relationshipType, externalUri, id);
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

            if (externalRelationship is null)
            {
                throw new ArgumentNullException(nameof(externalRelationship));
            }

            if (externalRelationship.Id is null || externalRelationship.Container != this)
            {
                throw new InvalidOperationException(ExceptionMessages.ExternalRelationshipIsNotReferenced);
            }

            if (Features.GetRequired<IReferenceRelationshipsFeature>().Remove(externalRelationship.Id))
            {
                return;
            }

            throw new InvalidOperationException(ExceptionMessages.ExternalRelationshipIsNotReferenced);
        }

        /// <summary>
        /// Deletes the specified ExternalRelationship.
        /// </summary>
        /// <param name="id">The relationship ID of the ExternalRelationship.</param>
        /// <exception cref="ArgumentNullException">Thrown when the "id" parameter is null.</exception>
        /// <exception cref="KeyNotFoundException">Thrown when there is no ExternalRelationship with the specified relationship ID.</exception>
        public void DeleteExternalRelationship(string id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (Features.GetRequired<IReferenceRelationshipsFeature>().Remove(id))
            {
                return;
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
            => GetRelationship<ExternalRelationship>(id, ExceptionMessages.NoSpecifiedExternalRelationship);

        private T GetRelationship<T>(string? id, string errorMessage)
            where T : ReferenceRelationship
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (Features.GetRequired<IReferenceRelationshipsFeature>().TryGetRelationship(id, out var existing))
            {
                if (existing is T t)
                {
                    return t;
                }
            }

            throw new KeyNotFoundException(errorMessage);
        }

        #endregion

        #region methods to operate HyperlinkRelationship

        /// <summary>
        /// Gets all hyperlink relationships.
        /// </summary>
        public IEnumerable<HyperlinkRelationship> HyperlinkRelationships
        {
            get
            {
                ThrowIfObjectDisposed();
                return Features.GetRequired<IReferenceRelationshipsFeature>().Relationships.OfType<HyperlinkRelationship>();
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

            if (hyperlinkUri is null)
            {
                throw new ArgumentNullException(nameof(hyperlinkUri));
            }

            return Features.GetRequired<IReferenceRelationshipsFeature>().CreateHyperLink(hyperlinkUri, isExternal);
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

            if (hyperlinkUri is null)
            {
                throw new ArgumentNullException(nameof(hyperlinkUri));
            }

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return Features.GetRequired<IReferenceRelationshipsFeature>().CreateHyperLink(hyperlinkUri, isExternal, id);
        }

        #endregion

        #region methods to operate DataPartReferenceRelationship

        /// <summary>
        /// Gets all <see cref="DataPartReferenceRelationship"/> relationships.
        /// </summary>
        public IEnumerable<DataPartReferenceRelationship> DataPartReferenceRelationships
        {
            get
            {
                ThrowIfObjectDisposed();
                return Features.GetRequired<IReferenceRelationshipsFeature>().Relationships.OfType<DataPartReferenceRelationship>();
            }
        }

        /// <summary>
        /// Adds a new <see cref="DataPartReferenceRelationship"/> relationship to the specified <see cref="MediaDataPart"/>.
        /// </summary>
        /// <param name="mediaDataPart">The target <see cref="MediaDataPart"/> of the reference relationship.</param>
        /// <returns>An new <see cref="DataPartReferenceRelationship"/>. </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="mediaDataPart"/> is null reference.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the specified <paramref name="mediaDataPart"/> is not in this document.</exception>
        internal T AddDataPartReferenceRelationship<T>(MediaDataPart mediaDataPart)
            where T : DataPartReferenceRelationship
        {
            ThrowIfObjectDisposed();

            if (mediaDataPart is null)
            {
                throw new ArgumentNullException(nameof(mediaDataPart));
            }

            if (mediaDataPart.OpenXmlPackage != InternalOpenXmlPackage)
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignMediaDataPart);
            }

            return AddDataPartReferenceRelationshipInternal<T>(mediaDataPart);
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
        internal T AddDataPartReferenceRelationship<T>(MediaDataPart mediaDataPart, string id)
            where T : DataPartReferenceRelationship
        {
            ThrowIfObjectDisposed();

            if (mediaDataPart is null)
            {
                throw new ArgumentNullException(nameof(mediaDataPart));
            }

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (mediaDataPart.OpenXmlPackage != InternalOpenXmlPackage)
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignMediaDataPart);
            }

            return AddDataPartReferenceRelationshipInternal<T>(mediaDataPart, id);
        }

        private T AddDataPartReferenceRelationshipInternal<T>(MediaDataPart mediaDataPart, string? id = null)
            where T : DataPartReferenceRelationship
        {
            var relationshipType = DataPartReferenceRelationship.GetRelationshipType<T>();
            return (T)Features.GetRequired<IReferenceRelationshipsFeature>().CreateDataPartRelationship(relationshipType, mediaDataPart, id);
        }

        /// <summary>
        /// Adds a new <see cref="DataPartReferenceRelationship"/> relationship.
        /// </summary>
        /// <param name="dataPartReferenceRelationship">The <see cref="DataPartReferenceRelationship"/>.</param>
        /// <returns>The same <see cref="DataPartReferenceRelationship"/>. </returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="dataPartReferenceRelationship"/> is null reference.</exception>
        internal DataPartReferenceRelationship AddDataPartReferenceRelationship(DataPartReferenceRelationship dataPartReferenceRelationship)
        {
            if (dataPartReferenceRelationship is null)
            {
                throw new ArgumentNullException(nameof(dataPartReferenceRelationship));
            }

            var dataPart = dataPartReferenceRelationship.DataPart;

            return Features.GetRequired<IReferenceRelationshipsFeature>()
                .CreateDataPartRelationship(dataPartReferenceRelationship.RelationshipType, dataPart, dataPartReferenceRelationship.Id);
        }

        #endregion

        #region methods to operate parts

        /// <summary>
        /// Gets all parts which are relationship targets of this part.
        /// </summary>
        public IEnumerable<IdPartPair> Parts
        {
            get
            {
                ThrowIfObjectDisposed();

                foreach (var item in ChildrenRelationshipParts)
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

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (ChildrenRelationshipParts.TryGetPart(id, out var part))
            {
                return part;
            }
            else
            {
                // return null;
                throw new ArgumentOutOfRangeException(nameof(id));
            }
        }

        /// <summary>
        /// Try to get the child part by the relationship ID.
        /// </summary>
        /// <param name="id">The relationship ID of the part.</param>
        /// <param name="part">The part.</param>
        /// <returns>Return <c>true</c> when the part with the specified id exist, otherwise <c>false</c></returns>
        public bool TryGetPartById(string id, [MaybeNullWhen(false)] out OpenXmlPart part)
        {
            ThrowIfObjectDisposed();

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return ChildrenRelationshipParts.TryGetPart(id, out part);
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

            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (ChildrenRelationshipParts.Contains(part))
            {
                foreach (var idPartPair in ChildrenRelationshipParts)
                {
                    if (part == idPartPair.Value)
                    {
                        return idPartPair.Key;
                    }
                }
            }

            throw new ArgumentOutOfRangeException(nameof(part));
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

            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (newRelationshipId is null)
            {
                throw new ArgumentNullException(nameof(newRelationshipId));
            }

            var oldId = default(string);

            foreach (var idPartPair in ChildrenRelationshipParts)
            {
                if (idPartPair.Key == newRelationshipId)
                {
                    throw new ArgumentException(ExceptionMessages.RelationshipIdConflict, nameof(newRelationshipId));
                }

                if (idPartPair.Value == part)
                {
                    if (oldId is not null)
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

            if (oldId is null)
            {
                // the part is not a sub part.
                throw new ArgumentOutOfRangeException(nameof(part));
            }

            // Add a new relationship, and then remove the old relationship
            ChildrenRelationshipParts.Add(part, newRelationshipId);
            ChildrenRelationshipParts.Remove(oldId);

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
        public virtual T AddPart<T>(T part)
            where T : OpenXmlPart
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
        public virtual T AddPart<T>(T part, string id)
            where T : OpenXmlPart
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
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
            if (targetPart is null)
            {
                throw new ArgumentNullException(nameof(targetPart));
            }

            if (!IsInSamePackage(targetPart))
            {
                throw new InvalidOperationException(ExceptionMessages.PartNotInSamePackage);
            }

            var addedPart = AddPart<OpenXmlPart>(targetPart);
            var relationshipId = GetIdOfPart(addedPart);
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
            if (targetPart is null)
            {
                throw new ArgumentNullException(nameof(targetPart));
            }

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (!IsInSamePackage(targetPart))
            {
                throw new InvalidOperationException(ExceptionMessages.PartNotInSamePackage);
            }
#if DEBUG
            var addedPart = AddPart<OpenXmlPart>(targetPart, id);
            Debug.Assert(GetIdOfPart(addedPart) == id);
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
        public T AddNewPart<T>()
            where T : OpenXmlPart, IFixedContentTypePart
        {
            return AddNewPartInternal<T>();
        }

        /// <summary>
        /// Adds a new part of type T.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <param name="id">The relationship id.</param>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        public T AddNewPart<T>(string id)
            where T : OpenXmlPart, IFixedContentTypePart
        {
            return AddNewPartInternal<T>(null, id);
        }

        /// <summary>
        /// Adds a new part of type T.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <param name="contentType">The content type of the part. Must match the defined content type if the part is fixed content type.</param>
        /// <param name="id">The relationship id. The id will be automatically generated if this param is null.</param>
        /// <returns>The added part.</returns>
        /// <exception cref="OpenXmlPackageException">When the part is not allowed to be referenced by this part.</exception>
        /// <exception cref="ArgumentOutOfRangeException">When the part is fixed content type and the passed in contentType does not match the defined content type.</exception>
        /// <exception cref="ArgumentNullException">Thrown when "contentType" is null reference.</exception>
        /// <remarks>Mainly used for adding not-fixed content type part - ImagePart, etc</remarks>
        public virtual T AddNewPart<T>(string contentType, string id)
            where T : OpenXmlPart
        {
            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            return AddNewPartInternal<T>(contentType, id);
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
        public ExtendedPart AddExtendedPart(string relationshipType, string contentType, string targetExt, string? rId)
        {
            ThrowIfObjectDisposed();

            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (targetExt is null)
            {
                throw new ArgumentNullException(nameof(targetExt));
            }

            var child = new ExtendedPart(relationshipType);

            child.CreateInternal(InternalOpenXmlPackage, ThisOpenXmlPart, contentType, targetExt);

            ChildrenRelationshipParts.Add(child, rId);

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
            ThrowIfObjectDisposed();

            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
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
            ThrowIfObjectDisposed();

            // if (part is null)
            // {
            //    throw new ArgumentNullException(nameof(part));
            // }
            if (part is null)
            {
                return false;
            }

            if (part.OpenXmlPackage != InternalOpenXmlPackage ||
                !ChildrenRelationshipParts.Contains(part))
            {
                throw new InvalidOperationException(ExceptionMessages.ForeignOpenXmlPart);
            }

            var relationshipId = GetIdOfPart(part);

            return DeletePart(relationshipId);
        }

        /// <summary>
        /// Deletes all the parts which are in the passed in collection from the document.
        /// </summary>
        /// <param name="partsToBeDeleted">The parts to be deleted.</param>
        /// <exception cref="ArgumentNullException">Thrown when "partsToBeDeleted" is null reference.</exception>
        public void DeleteParts<T>(IEnumerable<T> partsToBeDeleted)
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            if (partsToBeDeleted is null)
            {
                throw new ArgumentNullException(nameof(partsToBeDeleted));
            }

            var relationshipIds = new List<string>();

            foreach (OpenXmlPart part in partsToBeDeleted)
            {
                var relationshipId = GetIdOfPart(part);
                relationshipIds.Add(relationshipId);
            }

            foreach (var relationshipId in relationshipIds)
            {
                DeletePart(relationshipId);
            }
        }

        #endregion

        #region methods to operate annotation

        /// <summary>
        /// Adds an object to the annotation list of this PartContainer.
        /// </summary>
        /// <param name="annotation">The annotation to add to this PartContainer.</param>
        public void AddAnnotation(object annotation) => Features.GetRequired<AnnotationsFeature>().AddAnnotation(annotation);

        /// <summary>
        /// Get the first annotation object of the specified type from this PartContainer.
        /// </summary>
        /// <typeparam name="T">The type of the annotation to retrieve.</typeparam>
        /// <returns>The first annotation object of the specified type.</returns>
        public T? Annotation<T>()
            where T : class
        {
            return Features.GetRequired<AnnotationsFeature>().Annotation<T>();
        }

        /// <summary>
        /// Get the first annotation object of the specified type from this PartContainer.
        /// </summary>
        /// <param name="type">The type of the annotation to retrieve.</param>
        /// <returns>The first annotation object of the specified type.</returns>
        public object? Annotation(Type type)
        {
            return Features.GetRequired<AnnotationsFeature>().Annotation(type);
        }

        /// <summary>
        /// Gets a collection of annotations of the specified type for this PartContainer.
        /// </summary>
        /// <typeparam name="T">The type of the annotations to retrieve.</typeparam>
        /// <returns>An IEnumerable(T) of object that contains the annotations for this PartContainer.</returns>
        public IEnumerable<T> Annotations<T>()
            where T : class
        {
            return Features.GetRequired<AnnotationsFeature>().Annotations<T>();
        }

        /// <summary>
        /// Gets a collection of annotations of the specified type for this PartContainer.
        /// </summary>
        /// <param name="type">The Type of the annotations to retrieve.</param>
        /// <returns>An IEnumerable(T) of object that contains the annotations for this PartContainer.</returns>
        public IEnumerable<object> Annotations(Type type) => Features.GetRequired<AnnotationsFeature>().Annotations(type);

        /// <summary>
        /// Removes the annotations of the specified type from this PartContainer.
        /// </summary>
        /// <typeparam name="T">The Type of the annotations to remove.</typeparam>
        public void RemoveAnnotations<T>()
            where T : class
        {
            Features.GetRequired<AnnotationsFeature>().RemoveAnnotations<T>();
        }

        /// <summary>
        /// Removes the annotations of the specified type from this PartContainer.
        /// </summary>
        /// <param name="type">The Type of the annotations to remove.</param>
        public void RemoveAnnotations(Type type) => Features.GetRequired<AnnotationsFeature>().RemoveAnnotations(type);

        #endregion

        #endregion

        /// <summary>
        /// Enumerates all the children parts of the specified type <typeparamref name="T"/> of this part.
        /// </summary>
        /// <typeparam name="T">Derived class from OpenXmlPart.</typeparam>
        /// <returns></returns>
        public IEnumerable<T> GetPartsOfType<T>()
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            return ChildrenRelationshipParts.Parts.OfType<T>();
        }

        #region internal methods

        /// <summary>
        /// Adds a new part of type T.
        /// </summary>
        /// <typeparam name="T">The class of the part.</typeparam>
        /// <returns>The added part.</returns>
        internal T AddNewPartInternal<T>()
            where T : OpenXmlPart, IFixedContentTypePart
        {
            ThrowIfObjectDisposed();

            var part = Features.GetRequired<ITypedPartFactoryFeature>().Create<T>();

            if (part is null)
            {
                throw new OpenXmlPackageException(ExceptionMessages.AddedPartIsNotAllowed);
            }

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
        internal T AddNewPartInternal<T>(string? contentType, string? id)
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            // validate id
            if (id is not null)
            {
                if (id.Length == 0)
                {
                    throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, nameof(id));
                }

                try
                {
                    XmlConvert.VerifyNCName(id);
                }
                catch (XmlException)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidXmlIDStringException, nameof(id));
                }

                if (ChildrenRelationshipParts.Contains(id))
                {
                    throw new ArgumentException(ExceptionMessages.RelationshipIdConflict, nameof(id));
                }
            }

            // If ContentType is null, we handle it later. An empty string, however, is not allowed
            if (contentType?.Length == 0)
            {
                throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, nameof(contentType));
            }

            // Use reflection to create the instance as the default constructor of part is not public
            var part = Features.GetRequired<ITypedPartFactoryFeature>().Create<T>();

            if (part is ExtendedPart)
            {
                throw new ArgumentOutOfRangeException(nameof(T), ExceptionMessages.ExtendedPartNotAllowed);
            }

            if (part is null)
            {
                throw new OpenXmlPackageException(ExceptionMessages.AddedPartIsNotAllowed);
            }

            if (contentType is not null && part.IsContentTypeFixed && !string.Equals(contentType, part.ContentType, StringComparison.Ordinal))
            {
                throw new ArgumentOutOfRangeException(nameof(contentType), ExceptionMessages.ErrorContentType);
            }

            try
            {
                InitPart(part, contentType ?? part.ContentType, id);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.AddedPartIsNotAllowed, e);
            }
            catch (InvalidOperationException e)
            {
                throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed, e);
            }

            return part;
        }

        /// <summary>
        /// Initializes a new created part
        /// </summary>
        /// <param name="newPart">The part to be initialized.</param>
        /// <param name="contentType">The content type of the part.</param>
        internal void InitPart(OpenXmlPart newPart, string contentType)
        {
            InitPart(newPart, contentType, null);
        }

        /// <summary>
        /// Initializes a new created part
        /// </summary>
        /// <param name="newPart">The part to be initialized.</param>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="id">The relationship id.</param>
        internal virtual void InitPart(OpenXmlPart newPart, string contentType, string? id)
        {
            ThrowIfObjectDisposed();

            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (contentType.Length == 0)
            {
                throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException);
            }

            if (Features.GetRequired<IPartConstraintFeature>().TryGetRule(newPart.RelationshipType, out var partConstraintRule))
            {
                if (!partConstraintRule.MaxOccursGreatThanOne)
                {
                    if (GetSubPart(newPart.RelationshipType) is not null)
                    {
                        // already have one, can not add new one.
                        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
                    }
                }

                // Invalid part (same relationship type, but wrong (is different to be expected )content type
                if (partConstraintRule.ContentType is not null && contentType != partConstraintRule.ContentType)
                {
                    throw new ArgumentOutOfRangeException(nameof(newPart));
                }

                newPart.CreateInternal(InternalOpenXmlPackage, ThisOpenXmlPart, contentType, targetExt: null);

                ChildrenRelationshipParts.Add(newPart, id);

                return;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(newPart));
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
        internal virtual OpenXmlPart AddPartFrom(OpenXmlPart subPart, string? rId)
        {
            ThrowIfObjectDisposed();

            if (subPart is null)
            {
                throw new ArgumentNullException(nameof(subPart));
            }

            if (subPart.OpenXmlPackage == InternalOpenXmlPackage)
            {
                if (IsChildPart(subPart))
                {
                    if (rId is not null && rId != GetIdOfPart(subPart))
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

            if (Features.GetRequired<IPartConstraintFeature>().TryGetRule(subPart.RelationshipType, out var partConstraintRule))
            {
                if (partConstraintRule.ContentType is not null && subPart.ContentType != partConstraintRule.ContentType)
                {
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
                    var child = GetSubPart(subPart.RelationshipType);

                    if (child is not null)
                    {
                        throw new OpenXmlPackageException(ExceptionMessages.OnlyOnePartAllowed);
                    }

                    return SetSubPart(subPart, rId);
                }
            }
            else
            {
                if (subPart is ExtendedPart)
                {
                    return AddSubPart(subPart, rId);
                }
                else
                {
                    throw new InvalidOperationException(ExceptionMessages.AddedPartIsNotAllowed);
                }
            }
        }

        /// <summary>
        /// Sets part which is only one in the parent
        /// </summary>
        /// <param name="part"></param>
        /// <param name="rId">A unique relationship identifier.</param>
        /// <returns>The part added to the parent. Different with the passed in part.</returns>
        internal OpenXmlPart SetSubPart(OpenXmlPart part, string? rId)
        {
            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            // only one part has the same relationshipType allowed
            // delete the old one
            // OpenXmlPart child = this.GetSubPart(part.RelationshipType);

            // if (child is not null)
            // {
            //    // already have one, remove
            //    // TODO: should we throw?
            //    this.DeletePart(child);
            // }
            return AddSubPart(part, rId);
        }

        /// <summary>
        /// Adds the part to the parent.
        /// </summary>
        /// <param name="part"></param>
        /// <param name="rId">A unique relationship identifier.</param>
        /// <returns>The part added to the parent. Different with the passed in part.</returns>
        internal OpenXmlPart AddSubPart(OpenXmlPart part, string? rId)
        {
            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            // check if part is shared
            if (part.OpenXmlPackage == InternalOpenXmlPackage)
            {
                // it is a part shared in the same package
                ChildrenRelationshipParts.Add(part, rId);

                return part;
            }
            else
            {
                return AddSubPartFromOtherPackage(part, false, rId);
            }
        }

        // Add part which is from other package to this package
        // All child parts will also be added
        // partDictionary used to map new part from the source part and to detect cycle reference in source part
        internal OpenXmlPart AddSubPartFromOtherPackage(OpenXmlPart part, bool keepIdAndUri, string? rId)
        {
            var partDictionary = new Dictionary<OpenXmlPart, OpenXmlPart>();
            var dataPartsDictionary = new Dictionary<DataPart, DataPart?>();

            return AddSubPartFromOtherPackage(part, partDictionary, dataPartsDictionary, keepIdAndUri, rId);
        }

        // Add part which is from other package to this package
        // All child parts will also be added
        // partDictionary used to map new part from the source part and to detect cycle reference in source part
        private OpenXmlPart AddSubPartFromOtherPackage(OpenXmlPart part, IDictionary<OpenXmlPart, OpenXmlPart> partDictionary,
                                                       Dictionary<DataPart, DataPart?> dataPartsDictionary,
                                                       bool keepIdAndUri, string? rId)
        {
            if (keepIdAndUri)
            {
                if (rId is null)
                {
                    throw new ArgumentNullException(nameof(rId));
                }
            }

            if (partDictionary.TryGetValue(part, out var child))
            {
                // already processed
                ChildrenRelationshipParts.Add(child, rId);

                return child;
            }
            else
            {
                // find the current extension of the file

                // new a part and add it
                child = CreateOpenXmlPart(part.RelationshipType);

                // try to keep the same name
                child.CreateInternal(InternalOpenXmlPackage, ThisOpenXmlPart, part.ContentType, part.Uri);

                // if (keepIdAndUri)
                // {
                //    child.CreateInternal2(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, part.ContentType, part.Uri);
                // }
                // else
                // {
                //    child.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, part.ContentType, null);
                // }

                // copy the stream
                using (var stream = part.GetStream())
                {
                    child.FeedData(stream);
                }

                ChildrenRelationshipParts.Add(child, rId);

                // add to processed node list
                partDictionary.Add(part, child);

                // copy all the child parts recursively
                // call AddSubPart( ) so that make sure all descendant parts are added to the package.
                foreach (var idPartPair in part.Parts)
                {
                    child.AddSubPartFromOtherPackage(idPartPair.OpenXmlPart, partDictionary, dataPartsDictionary, true, idPartPair.RelationshipId);
                }

                // copy all external relationships
                foreach (var externalRel in part.ExternalRelationships)
                {
                    child.AddExternalRelationship(externalRel.RelationshipType, externalRel.Uri, externalRel.Id);
                }

                // copy all hyperlink relationships
                foreach (var hyperlinkRel in part.HyperlinkRelationships)
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

                UpdateDataParts(dataPartsDictionary);

                // then create data part reference relationship
                foreach (var dataPartReferenceRelationship in part.DataPartReferenceRelationships)
                {
                    if (dataPartsDictionary[dataPartReferenceRelationship.DataPart] is MediaDataPart newDataPart)
                    {
                        child.Features.GetRequired<IReferenceRelationshipsFeature>().CreateDataPartRelationship(dataPartReferenceRelationship.RelationshipType, newDataPart, dataPartReferenceRelationship.Id);
                    }
                }

                return child;
            }
        }

        // Updates of existing dictionary keys during enumeration are only allowed after net 5.0.
        // Before that we need a temporary dictionary to store the updated values for the keys.
#if NET5_0_OR_GREATER
        private void UpdateDataParts(Dictionary<DataPart, DataPart?> dataPartsDictionary)
        {
            foreach (var (key, value) in dataPartsDictionary)
            {
                if (value is null)
                {
                    var newDataPart = new MediaDataPart(InternalOpenXmlPackage, key.ContentType, key.Uri);

                    // copy the stream
                    using (var stream = key.GetStream())
                    {
                        newDataPart.FeedData(stream);
                    }

                    InternalOpenXmlPackage.AddDataPartToList(newDataPart);
                    dataPartsDictionary[key] = newDataPart;
                }
            }
        }
#else
        private void UpdateDataParts(Dictionary<DataPart, DataPart?> dataPartsDictionary)
        {
            var updatedParts = new Dictionary<DataPart, DataPart>();
            foreach (var item in dataPartsDictionary)
            {
                var key = item.Key;
                var value = item.Value;
                if (value is null)
                {
                    var newDataPart = new MediaDataPart(InternalOpenXmlPackage, key.ContentType, key.Uri);

                    // copy the stream
                    using (var stream = key.GetStream())
                    {
                        newDataPart.FeedData(stream);
                    }

                    InternalOpenXmlPackage.AddDataPartToList(newDataPart);
                    updatedParts.Add(key, newDataPart);
                }
            }

            foreach (var updatedItem in updatedParts)
            {
                dataPartsDictionary[updatedItem.Key] = updatedItem.Value;
            }
        }
#endif

        /// <summary>
        /// Deletes the specified part in the package root layer.
        /// </summary>
        /// <param name="id">The relationship ID of the part to be deleted.</param>
        /// <returns>true if the part is successfully removed; otherwise, false. This method also returns false if the part was not found.</returns>
        internal bool DeletePartCore(string id)
        {
            var liveParts = new Dictionary<OpenXmlPart, bool>();
            var processedParts = new Dictionary<OpenXmlPart, bool>();

            if (!TryGetPartById(id, out var child))
            {
                return false;
            }

            var events = Features.Get<IPartEventsFeature>();
            events?.OnChange(child, EventType.Deleting);

            child.FindAllReachableParts(processedParts);

            // remove from the collection
            ChildrenRelationshipParts.Remove(id);

            // find all live parts
            InternalOpenXmlPackage.FindAllReachableParts(liveParts);

            var toBeDeletedParts = new Dictionary<OpenXmlPart, bool>();

            foreach (var part in processedParts.Keys)
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
                Relationships.Remove(id);
            }
            else
            {
                Debug.Assert(toBeDeletedParts.ContainsKey(child));

                child.DeleteAllParts(processedParts, toBeDeletedParts);

                Relationships.Remove(id);

                if (toBeDeletedParts.TryGetValue(child, out var partRemoved))
                {
                    if (!partRemoved)
                    {
                        child.Destroy();
                        toBeDeletedParts[child] = true;
                    }
                }
            }

            events?.OnChange(child, EventType.Deleted);

            return true;
        }

        /// <summary>
        /// Deletes all the parts of the specified type.
        /// </summary>
        internal void DeletePartsOfType<T>()
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            var relationshipIds = new List<string>();

            foreach (var idPartPair in ChildrenRelationshipParts)
            {
                if (idPartPair.Value is T)
                {
                    relationshipIds.Add(idPartPair.Key);
                }
            }

            foreach (var relationshipId in relationshipIds)
            {
                DeletePart(relationshipId);
            }
        }

        /// <summary>
        /// Deletes all the parts which is the specified part type from package recursively.
        /// </summary>
        internal void DeletePartsRecursivelyOfTypeBase<T>()
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            DeletePartsOfType<T>();

            // remove recursively
            foreach (var child in ChildrenRelationshipParts.Parts)
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

            if (ChildrenRelationshipParts.Count > 0)
            {
                var subPartsShouldBeDeleted = new Collection<OpenXmlPart>();

                foreach (var idPartPair in ChildrenRelationshipParts)
                {
                    // do not process it again if already processed, cycle reference defense
                    if (!processedParts[idPartPair.Value])
                    {
                        // mark it as processed
                        processedParts[idPartPair.Value] = true;
                        if (toBeDeletedParts.TryGetValue(idPartPair.Value, out var isDeleted))
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
                    Relationships.Remove(idPartPair.Key);
                }

                ChildrenRelationshipParts.Clear();

                foreach (var child in subPartsShouldBeDeleted)
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
        internal OpenXmlPart? GetSubPart(string relationshipType)
        {
            ThrowIfObjectDisposed();

            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            // there should be only one part of this type
            foreach (var part in ChildrenRelationshipParts.Parts)
            {
                if (part.RelationshipType == relationshipType)
                {
                    return part;
                }
            }

            return null;
        }

        internal T? GetSubPartOfType<T>()
            where T : OpenXmlPart
        {
            ThrowIfObjectDisposed();

            foreach (var part in GetPartsOfType<T>())
            {
                return part;
            }

            return null;
        }

        internal OpenXmlPart? GetPart(string relationshipType)
            => ChildrenRelationshipParts.Parts.FirstOrDefault(v => v.RelationshipType == relationshipType);

        internal bool IsChildPart(OpenXmlPart part)
        {
            ThrowIfObjectDisposed();

            if (part is null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            if (part.OpenXmlPackage != InternalOpenXmlPackage)
            {
                throw new ArgumentOutOfRangeException(nameof(part));
            }

            return ChildrenRelationshipParts.Contains(part);
        }

        /// <summary>
        /// Creates an strong typed OpenXmlPart instance based on the relationship type. For and only for loading.
        /// </summary>
        /// <param name="relationshipType">The relationship type of the new part.</param>
        /// <returns>The created new part.</returns>
        internal OpenXmlPart CreateOpenXmlPart(string relationshipType)
        {
            return Features.GetRequired<IPartFactoryFeature>().Create(relationshipType) ?? new ExtendedPart(relationshipType);
        }

        #endregion

        #region abstract / virtual internal methods to be implemented by derived classes.

        /// <summary>
        /// Gets the internal OpenXmlPackage instance
        /// </summary>
        internal abstract OpenXmlPackage InternalOpenXmlPackage { get; }

        internal abstract OpenXmlPart? ThisOpenXmlPart { get; }

        /// <summary>
        /// Test whether the object is already disposed.
        /// </summary>
        protected abstract void ThrowIfObjectDisposed();

        internal abstract IRelationshipCollection Relationships { get; }

        // find all reachable parts from the package root, the dictionary also used for cycle reference defense
        internal abstract void FindAllReachableParts(IDictionary<OpenXmlPart, bool> reachableParts);

        #endregion

        // Checks if the target part is in the same OpenXmlPackage as this part.
        private bool IsInSamePackage(OpenXmlPart targetPart)
        {
            return InternalOpenXmlPackage is not null &&
                targetPart.OpenXmlPackage is not null &&
                targetPart.OpenXmlPackage == InternalOpenXmlPackage;
        }

        /// <summary>
        /// Gets the features associated with this part.
        /// </summary>
        public virtual IFeatureCollection Features
        {
            get
            {
                ThrowIfObjectDisposed();

                if (_features is null)
                {
                    _features = new FeatureCollection(FeatureCollection.Default);
                }

                return _features;
            }
        }
    }
}
