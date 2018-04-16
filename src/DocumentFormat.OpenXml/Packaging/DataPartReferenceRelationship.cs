// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an internal reference relationship to a DataPart element.
    /// </summary>
    public class DataPartReferenceRelationship : ReferenceRelationship
    {
        /// <summary>
        /// Initializes a new instance of the DataPartReferenceRelationship class.
        /// </summary>
        /// <remarks>
        /// A call to Initialize() must be made after calling this constructor.
        /// </remarks>
        internal DataPartReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPartReferenceRelationship class using the supplied
        /// DataPart, relationship type, and relationship ID.
        /// </summary>
        /// <param name="dataPart">The target DataPart of the reference relationship.</param>
        /// <param name="relationshipType">The relationship type of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected DataPartReferenceRelationship(DataPart dataPart, string relationshipType, string id)
            : base(dataPart.Uri, false, relationshipType, id)
        {
            DataPart = dataPart;
        }

        /// <summary>
        /// Gets the referenced target DataPart.
        /// </summary>
        public virtual DataPart DataPart
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the current instance of the DataPartRelationship class.
        /// </summary>
        /// <param name="containter">The owner <see cref="OpenXmlPartContainer"/> that holds the <see cref="ReferenceRelationship"/>.</param>
        /// <param name="dataPart">The target DataPart of the reference relationship.</param>
        /// <param name="relationshipType">The relationship type of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal void Initialize(OpenXmlPartContainer containter, DataPart dataPart, string relationshipType, string id)
        {
            Debug.Assert(containter != null);
            Debug.Assert(dataPart != null);

            Initialize(dataPart.Uri, false, relationshipType, id);
            Container = containter;
            DataPart = dataPart;
        }

        internal static bool IsDataPartReferenceRelationship(string relationshipType)
        {
            switch (relationshipType)
            {
                case MediaReferenceRelationship.RelationshipTypeConst:
                case AudioReferenceRelationship.RelationshipTypeConst:
                case VideoReferenceRelationship.RelationshipTypeConst:
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Creates a new instance of the DataPartRelationship class based on the relationship type.
        /// </summary>
        /// <param name="containter">The owner <see cref="OpenXmlPartContainer"/> that holds the <see cref="ReferenceRelationship"/>.</param>
        /// <param name="dataPart">The target DataPart of the reference relationship.</param>
        /// <param name="relationshipType">The relationship type of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal static DataPartReferenceRelationship CreateDataPartReferenceRelationship(OpenXmlPartContainer containter, DataPart dataPart, string relationshipType, string id)
        {
            Debug.Assert(containter != null);
            Debug.Assert(dataPart != null);

            DataPartReferenceRelationship dataPartReferenceRelationship;

            switch (relationshipType)
            {
                case MediaReferenceRelationship.RelationshipTypeConst:
                    dataPartReferenceRelationship = new MediaReferenceRelationship((MediaDataPart)dataPart, id);
                    break;

                case AudioReferenceRelationship.RelationshipTypeConst:
                    dataPartReferenceRelationship = new AudioReferenceRelationship((MediaDataPart)dataPart, id);
                    break;

                case VideoReferenceRelationship.RelationshipTypeConst:
                    dataPartReferenceRelationship = new VideoReferenceRelationship((MediaDataPart)dataPart, id);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(relationshipType));
            }

            dataPartReferenceRelationship.Container = containter;
            return dataPartReferenceRelationship;
        }
    }
}
