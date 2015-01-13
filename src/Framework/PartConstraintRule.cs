// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Internal class for part constraint rule
    /// </summary>
    internal class PartConstraintRule
    {
        /// <summary>
        /// The class name for the relationship type.
        /// Used in validation event handler.
        /// </summary>
        internal string PartClassName;
        
        /// <summary>
        /// Content type of the part. null for non-fixed content type.
        /// Purpose: WorksheetCommentsPart / SlideCommentsPart / CommentsPart have same relatiohship type but different content type.
        /// </summary>
        internal string PartContentType;

        /// <summary>
        /// true if the min occurs > 0, (be required).
        /// </summary>
        internal bool MinOccursIsNonZero;

        /// <summary>
        /// true is max occurs > 1, (is multiple).
        /// </summary>
        internal bool MaxOccursGreatThanOne;

        /// <summary>
        /// The file format version (Office2007 / Office2010) information.
        /// </summary>
        internal FileFormatVersions FileFormat;

        /// <summary>
        /// Initialize a instance of PartConstraintRule class.
        /// </summary>
        /// <param name="partClassName">The class name of the part.</param>
        /// <param name="partContentType">The content type of the part.</param>
        /// <param name="minOccursIsNonZero">The MinOccursIsNonZero data.</param>
        /// <param name="maxOccursGreatThanOne">The MaxOccursGreatThanOne data.</param>
        /// <param name="fileFormat">The file format version information.</param>
        internal PartConstraintRule(string partClassName, string partContentType, 
                                    bool minOccursIsNonZero, bool maxOccursGreatThanOne,
                                    FileFormatVersions fileFormat)
        {
            this.PartClassName = partClassName;
            this.PartContentType = partContentType;
            this.MinOccursIsNonZero = minOccursIsNonZero;
            this.MaxOccursGreatThanOne = maxOccursGreatThanOne;
            this.FileFormat = fileFormat;
        }
    }
}
