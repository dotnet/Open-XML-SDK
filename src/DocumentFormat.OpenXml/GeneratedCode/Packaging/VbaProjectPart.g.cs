﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the VbaProjectPart
    /// </summary>
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class VbaProjectPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.vbaProject";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2006/relationships/vbaProject";
        private static PartConstraintCollection _partConstraints;

        /// <summary>
        /// Creates an instance of the VbaProjectPart OpenXmlType
        /// </summary>
        internal protected VbaProjectPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override PartConstraintCollection PartConstraints
        {
            get
            {
                if (_partConstraints is null)
                {
                    _partConstraints = new PartConstraintCollection
                    {
                        PartConstraintRule.Create<VbaDataPart>(false, false)
                    };
                }

                return _partConstraints;
            }
        }

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "vbaProject";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        /// <summary>
        /// Gets the VbaDataPart of the VbaProjectPart
        /// </summary>
        public VbaDataPart VbaDataPart => GetSubPartOfType<VbaDataPart>();

        /// <inheritdoc/>
        internal sealed override OpenXmlPart CreatePartCore(string relationshipType)
        {
            ThrowIfObjectDisposed();
            if (relationshipType is null)
            {
                throw new ArgumentNullException(nameof(relationshipType));
            }

            switch (relationshipType)
            {
                case VbaDataPart.RelationshipTypeConstant:
                    return new VbaDataPart();
            }

            throw new ArgumentOutOfRangeException(nameof(relationshipType));
        }
    }
}
