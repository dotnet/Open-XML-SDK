// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a class for all extended parts (Application specific part).
    /// </summary>
    public class ExtendedPart : OpenXmlPart
    {
        private const string DefaultTargetExt = ".dat";

        private string _relationshipType;

        private static Dictionary<string, PartConstraintRule> _partConstraints = new Dictionary<string, PartConstraintRule>();
        private static Dictionary<string, PartConstraintRule> _dataPartReferenceConstraint = new Dictionary<string,PartConstraintRule>();

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
            : base( )
        {
            this._relationshipType = relationshipType;
        }

        /// <summary>
        /// The relationship type of the part.
        /// </summary>
        public override string RelationshipType
        {
            get
            {
                return this._relationshipType;
            }
        }

        /// <summary>
        /// The file extension to be used for the part in the package.
        /// </summary>
        internal override string TargetFileExtension
        {
            get
            {
                return DefaultTargetExt;
            }
        }

        /// <summary>
        /// The internal path to be used for the part name.
        /// </summary>
        internal override string TargetPath
        {
            get { return "udata"; }
        }

        /// <summary>
        /// The file base name to be used for the part name in the package
        /// </summary>
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

        internal sealed override IDictionary<string, PartConstraintRule> GetPartConstraint()
        {
            ThrowIfObjectDisposed();
            return _partConstraints;
        }

        internal sealed override IDictionary<string, PartConstraintRule> GetDataPartReferenceConstraint()
        {
            ThrowIfObjectDisposed();
            return _dataPartReferenceConstraint;
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
                throw new ArgumentNullException("contentType");
            }

            if (contentType == string.Empty)
            {
                throw new ArgumentException(ExceptionMessages.StringArgumentEmptyException, "contentType");
            }


            newPart.CreateInternal(this.InternalOpenXmlPackage, this.ThisOpenXmlPart, contentType, null);

            string relationshipId = this.AttachChild(newPart, id);

            this.ChildrenParts.Add(relationshipId, newPart);

            return;
        }

    }
}
