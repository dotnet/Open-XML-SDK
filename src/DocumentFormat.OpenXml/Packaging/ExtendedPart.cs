// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a class for all extended parts (Application specific part).
    /// </summary>
    public class ExtendedPart : OpenXmlPart
    {
        private const string DefaultTargetExt = ".dat";

        private string _relationshipType;

        /// <summary>
        /// Default constructor.
        /// </summary>
        protected ExtendedPart()
            : base()
        {
        }

        /// <summary>
        /// Initialize a new instance of ExtendedPart.
        /// </summary>
        /// <param name="relationshipType"></param>
        internal protected ExtendedPart(string relationshipType)
            : base()
        {
            _relationshipType = relationshipType;
        }

        /// <inheritdoc/>
        public override string RelationshipType
        {
            get
            {
                return _relationshipType;
            }
        }

        /// <inheritdoc/>
        internal override string TargetFileExtension
        {
            get
            {
                return DefaultTargetExt;
            }
        }

        /// <inheritdoc/>
        internal override string TargetPath
        {
            get { return "udata"; }
        }

        /// <inheritdoc/>
        internal override string TargetName
        {
            get { return "data"; }
        }

        internal sealed override bool IsContentTypeFixed
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Whether this part is available in a specific version of Office Application.
        /// </summary>
        /// <param name="version">The Office file format version.</param>
        /// <returns>Always returns false.</returns>
        internal override bool IsInVersion(FileFormatVersions version)
        {
            return false;
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
        internal override OpenXmlPart AddPartFrom(OpenXmlPart subPart, string rId)
        {
            ThrowIfObjectDisposed();

            if (subPart == null)
            {
                throw new ArgumentNullException(nameof(subPart));
            }

            if (subPart.OpenXmlPackage == InternalOpenXmlPackage)
            {
                if (IsChildPart(subPart))
                {
                    if (rId != null && rId != GetIdOfPart(subPart))
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
        /// Init a new created part
        /// </summary>
        /// <typeparam name="T">The type of the part, must be derived from OpenXmlPart.</typeparam>
        /// <param name="newPart">The part to be initialized.</param>
        /// <param name="contentType">The content type of the part.</param>
        /// <param name="id">The relationship id.</param>
        internal override void InitPart<T>(T newPart, string contentType, string id)
        {
            ThrowIfObjectDisposed();

            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (contentType.Length == 0)
            {
                throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, nameof(contentType));
            }

            newPart.CreateInternal(InternalOpenXmlPackage, ThisOpenXmlPart, contentType, null);

            string relationshipId = AttachChild(newPart, id);

            ChildrenRelationshipParts.Add(relationshipId, newPart);

            return;
        }
    }
}
