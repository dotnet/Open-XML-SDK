﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a class for all extended parts (Application specific part).
    /// </summary>
    public class ExtendedPart : OpenXmlPart
    {
        /// <summary>
        /// Initialize a new instance of ExtendedPart.
        /// </summary>
        /// <param name="relationshipType"></param>
        internal protected ExtendedPart(string relationshipType)
            : base()
        {
            RelationshipType = relationshipType;
        }

        /// <inheritdoc/>
        public override string RelationshipType { get; }

        /// <summary>
        /// Whether this part is available in a specific version of Office Application.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Always returns false.</returns>
        internal override bool IsInVersion(FileFormatVersions version) => false;

        /// <summary>
        /// Adds a new part.
        /// </summary>
        /// <param name="subPart">The part to be added.</param>
        /// <param name="rId">A unique relationship identifier. null to create new id.</param>
        /// <returns>The added part. May diff with the passed in part.</returns>
        /// <exception cref="ArgumentNullException">Thrown when "subPart" is null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the part is no allowed to be added.</exception>
        /// <exception cref="OpenXmlPackageException">Thrown when one instance of same type part already exists and multiple instance of that type is not allowed.</exception>
        internal override OpenXmlPart AddPartFrom(OpenXmlPart subPart, string? rId)
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

            return AddSubPart(subPart, rId);
        }

        /// <summary>
        /// Initialize a new created part
        /// </summary>
        /// <param name="newPart">The part to be initialized.</param>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="id">The relationship id.</param>
        internal override void InitPart(OpenXmlPart newPart, string contentType, string? id)
        {
            ThrowIfObjectDisposed();

            if (contentType is null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (contentType.Length == 0)
            {
                throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, nameof(contentType));
            }

            newPart.CreateInternal(InternalOpenXmlPackage, ThisOpenXmlPart, contentType, targetExt: null);

            ChildrenRelationshipParts.Add(newPart, id);
        }

        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new ExtendPartFeatures(this);

        private sealed class ExtendPartFeatures : PartFeatureCollection, ITargetFeature
        {
            public ExtendPartFeatures(OpenXmlPart part)
                : base(part)
            {
            }

            string ITargetFeature.Extension => ".dat";

            string ITargetFeature.Path => "udata";

            string ITargetFeature.Name => "data";
        }
    }
}
