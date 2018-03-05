// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Packaging
{
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
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Gets or sets the OpenXmlPart in the pair.
        /// </summary>
        public OpenXmlPart OpenXmlPart
        {
            get { return _part; }
            set { _part = value; }
        }

        /// <summary>
        /// Initializes a new instance of the IdPartPair with the specified id and part.
        /// </summary>
        /// <param name="id">The relationship ID.</param>
        /// <param name="part">The OpenXmlPart.</param>
        public IdPartPair(string id, OpenXmlPart part)
        {
            RelationshipId = id;
            OpenXmlPart = part;
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

            return _id.Equals(value._id) && (_part == value._part);
        }
    }
}
