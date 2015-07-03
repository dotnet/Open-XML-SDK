// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            this.DataPart = dataPart;
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

            this.Initialize(dataPart.Uri, false, relationshipType, id);
            this.Container = containter;
            this.DataPart = dataPart;
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
                    throw new ArgumentOutOfRangeException("relationshipType");
            }
            dataPartReferenceRelationship.Container = containter;
            return dataPartReferenceRelationship;
        }
    }

    /// <summary>
    /// Represents an internal media reference relationship to a MediaDataPart element.
    /// </summary>
    public class MediaReferenceRelationship : DataPartReferenceRelationship
    {
        /// <summary>
        /// Represents the fixed value of the RelationshipType.
        /// </summary>
        internal const String RelationshipTypeConst = @"http://schemas.microsoft.com/office/2007/relationships/media";

        /// <summary>
        /// Gets the source relationship type for a media reference. 
        /// </summary>
        public static string MediaReferenceRelationshipType
        {
            get { return RelationshipTypeConst; }
        }

        /// <summary>
        /// Initializes a new instance of the MediaReferenceRelationship class.
        /// </summary>
        /// <remarks>
        /// A call to Initialize() must be made after calling this constructor.
        /// </remarks>
        internal MediaReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MediaReferenceRelationship class using 
        /// the supplied MediaDataPart and relationship ID.
        /// </summary>
        /// <param name="mediaDataPart">The target DataPart of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected MediaReferenceRelationship(MediaDataPart mediaDataPart, string id)
            : base(mediaDataPart, RelationshipTypeConst, id)
        {
        }

        /// <summary>
        /// Gets the relationship type for a media reference.
        /// </summary>
        public override string RelationshipType
        {
            get { return RelationshipTypeConst; }
        }
    }
    
    /// <summary>
    /// Represents an internal audio reference relationship to a MediaDataPart element.
    /// </summary>
    public class AudioReferenceRelationship : DataPartReferenceRelationship
    {
        /// <summary>
        /// Represents the fixed value of the RelationshipType.
        /// </summary>
        internal const String RelationshipTypeConst = @"http://schemas.openxmlformats.org/officeDocument/2006/relationships/audio";

        /// <summary>
        /// Gets the source relationship type for an audio reference. 
        /// </summary>
        public static string AudioReferenceRelationshipType
        {
            get { return RelationshipTypeConst; }
        }

        /// <summary>
        /// Initializes a new instance of the AudioReferenceRelationship.
        /// </summary>
        /// <remarks>
        /// A call to Initialize() must be made after calling this constructor.
        /// </remarks>
        internal AudioReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AudioReferenceRelationship using the supplied
        /// MediaDataPart and relationship ID.
        /// </summary>
        /// <param name="mediaDataPart">The target DataPart of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected AudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
            : base(mediaDataPart, RelationshipTypeConst, id)
        {
        }

        /// <summary>
        /// Gets the relationship type for an audio reference.
        /// </summary>
        public override string RelationshipType
        {
            get { return RelationshipTypeConst; }
        }
    }

    /// <summary>
    /// Represents an internal video reference relationship to a MediaDataPart element.
    /// </summary>
    public class VideoReferenceRelationship : DataPartReferenceRelationship
    {
        /// <summary>
        /// Represents the fixed value of the RelationshipType.
        /// </summary>
        internal const String RelationshipTypeConst = @"http://schemas.openxmlformats.org/officeDocument/2006/relationships/video";

        /// <summary>
        /// Gets the source relationship type for an audio reference. 
        /// </summary>
        public static string VideoReferenceRelationshipType
        {
            get { return RelationshipTypeConst; }
        }

        /// <summary>
        /// Initializes a new instance of the VideoReferenceRelationship class.
        /// </summary>
        /// <remarks>
        /// A call to Initialize() must be made after calling this constructor.
        /// </remarks>
        internal VideoReferenceRelationship()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VideoReferenceRelationship class using the supplied 
        /// MediaDataPart and relationship ID.
        /// </summary>
        /// <param name="mediaDataPart">The target DataPart of the reference relationship.</param>
        /// <param name="id">The relationship ID.</param>
        internal protected VideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
            : base(mediaDataPart, RelationshipTypeConst, id)
        {
        }

        /// <summary>
        /// Gets the relationship type for a video reference.
        /// </summary>
        public override string RelationshipType
        {
            get { return RelationshipTypeConst; }
        }
    }

}

