// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Defines the attribute which is used to decorate a property for its corresponding attribute information.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Attr"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments")]
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class SchemaAttrAttribute : Attribute
    {
        //string _type;
        string _tag;
        byte _nsId;

        /// <summary>
        /// Initializes a new instance of the SchemaAttrAttribute.
        /// </summary>
        /// <param name="nsId">Specifies the Namespace Id of the schema attribute.</param>
        /// <param name="tag">Specifies the Tag name of the schema attribute.</param>
        public SchemaAttrAttribute(byte nsId, string tag)
        {
            if (string.IsNullOrEmpty(tag))
            {
                throw new ArgumentNullException("tag");
            }

            _nsId = nsId;
            _tag = tag;
            
            
        }

        /// <summary>
        /// Gets/Sets the Tag name of the schema attribute.
        /// </summary>
        public string Tag
        {
            get { return _tag; }
            //set { _tag = value; }
        }

        /// <summary>
        /// Gets the Namespace Uri of the schema attribute.
        /// </summary>
        public string NamespaceUri
        {
            get
            {
                return NamespaceIdMap.GetNamespaceUri(_nsId);
            }
        }
    }

    /// <summary>
    /// Defines the attribute which is used to decorate a class for type of the possible child elements.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments"), AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public sealed class ChildElementInfoAttribute : Attribute
    {
        private Type _type;
        FileFormatVersions format;

        /// <summary>
        /// Initialize a new instance of ChildElementTypeAttribute.
        /// </summary>
        /// <param name="elementType">Specifies the type of the possible child element.</param>
        public ChildElementInfoAttribute(Type elementType)
        {
            _type = elementType;
            format = FileFormatVersions.Office2007 | FileFormatVersions.Office2010;
        }
        
        /// <summary>
        /// Initialize a new instance of ChildElementTypeAttribute.
        /// </summary>
        /// <param name="elementType">Specifies the type of the possible child element.</param>
        /// <param name="availableInOfficeVersion">Specifies the office version(s) where the child element is available.</param>
        public ChildElementInfoAttribute(Type elementType, FileFormatVersions availableInOfficeVersion)
        {
            _type = elementType;
            format = availableInOfficeVersion;
        }


        /// <summary>
        /// Get the  type of the possible child element.
        /// </summary>
        public Type ElementType
        {
            get { return _type; }
        }

        /// <summary>
        /// Gets the Office version(s) where the child element is available.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "InVersion")]
        public FileFormatVersions AvailableInVersion {
            get { return format; }
        }
    }
}
