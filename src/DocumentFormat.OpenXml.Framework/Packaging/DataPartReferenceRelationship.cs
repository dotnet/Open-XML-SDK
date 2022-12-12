// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Represents an internal reference relationship to a DataPart element.
    /// </summary>
    public class DataPartReferenceRelationship : ReferenceRelationship
    {
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
            DataPart = dataPart ?? throw new ArgumentNullException(nameof(dataPart));
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
        internal DataPartReferenceRelationship(OpenXmlPartContainer containter, DataPart dataPart, string relationshipType, string id)
            : base(dataPart.Uri, false, relationshipType, id)
        {
            Container = containter;
            DataPart = dataPart;
        }

        internal static bool IsDataPartReferenceRelationship(string relationshipType)
            => relationshipType switch
            {
                MediaReferenceRelationship.RelationshipTypeConst or AudioReferenceRelationship.RelationshipTypeConst or VideoReferenceRelationship.RelationshipTypeConst => true,
                _ => false,
            };

        /// <summary>
        /// Creates a new instance of the DataPartRelationship class based on the relationship type.
        /// </summary>
        /// <param name="container">The owner <see cref="OpenXmlPartContainer"/> that holds the <see cref="ReferenceRelationship"/>.</param>
        /// <param name="dataPart">The target DataPart of the reference relationship.</param>
        /// <param name="relationshipType">The relationship type of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal static DataPartReferenceRelationship Create(OpenXmlPartContainer container, DataPart dataPart, string relationshipType, string id)
        {
            DataPartReferenceRelationship dataPartReferenceRelationship = relationshipType switch
            {
                MediaReferenceRelationship.RelationshipTypeConst => new MediaReferenceRelationship((MediaDataPart)dataPart, id),
                AudioReferenceRelationship.RelationshipTypeConst => new AudioReferenceRelationship((MediaDataPart)dataPart, id),
                VideoReferenceRelationship.RelationshipTypeConst => new VideoReferenceRelationship((MediaDataPart)dataPart, id),
                _ => throw new ArgumentOutOfRangeException(nameof(relationshipType)),
            };
            dataPartReferenceRelationship.Container = container;
            return dataPartReferenceRelationship;
        }

        internal static string GetRelationshipType<T>()
            where T : DataPartReferenceRelationship
        {
            if (typeof(T) == typeof(VideoReferenceRelationship))
            {
                return VideoReferenceRelationship.RelationshipTypeConst;
            }
            else if (typeof(T) == typeof(AudioReferenceRelationship))
            {
                return AudioReferenceRelationship.RelationshipTypeConst;
            }
            else if (typeof(T) == typeof(MediaReferenceRelationship))
            {
                return MediaReferenceRelationship.RelationshipTypeConst;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.DataPartReferenceIsNotAllowed);
            }
        }
    }
}
