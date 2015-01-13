// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a Part Extension Provider which maintains a (Content Type, Part Extension (".xml")) dictionary.
    /// Used in OpenXmlPackage derived classes.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [SerializableAttribute]
    public sealed class PartExtensionProvider : Dictionary<string, string>
    {
        /// <summary>
        /// Initializes a new instance of the PartExtensionProvider class that is empty.
        /// </summary>
        public PartExtensionProvider() : base ( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the PartExtensionProvider class that contains elements copied from the specified PartExtensionProvider.
        /// </summary>
        /// <param name="partExtProvider">The source PartExtensionProvider whose elements are copied to the new PartExtensionProvider.</param>
        public PartExtensionProvider(PartExtensionProvider partExtProvider)
            : base(partExtProvider)
        {
        }

        /// <summary>
        /// Initializes a new instance of the class that is empty, has the specified initial capacity.
        /// </summary>
        /// <param name="capacity">The initial number of elements that the PartExtensionProvider can contain.</param>
        public PartExtensionProvider(int capacity)
            : base(capacity)
        {
        }

        // This is the serialization constructor.
        // Satisfies rule: ImplementSerializationConstructors.

        /// <summary>
        /// Initializes a new instance of the Dictionary class with serialized data. 
        /// </summary>
        /// <param name="info">A System.Runtime.Serialization.SerializationInfo object containing the information required to serialize the PartExtensionProvider.</param>
        /// <param name="context">A System.Runtime.Serialization.StreamingContext structure containing the source and destination of the serialized stream associated with the PartExtensionProvider.</param>
        private PartExtensionProvider(
           SerializationInfo info, 
           StreamingContext context) : base ( info, context )
        {
        }

        /// <summary>
        /// Add a part extension for the specified ContentType.
        /// </summary>
        /// <param name="contentType">ContentType.</param>
        /// <param name="partExtension">Part Extension (".xml") to be used for the part with the specified content type.</param>
        public void AddPartExtension(string contentType, string partExtension)
        {
            base.Add(contentType, partExtension);
        }

        /// <summary>
        /// Check to make sure the (contentType, partExtension) is in the provider.
        /// The (contentType, partExtension) will be added to the provider if it does not exist in the provider.
        /// </summary>
        /// <param name="contentType">ContentType</param>
        /// <param name="partExtension">Part Extension (".xml") to be used for the part with the specified content type.</param>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is null.</exception>
        public void MakeSurePartExtensionExist(string contentType, string partExtension)
        {
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }

            if (partExtension == null)
            {
                throw new ArgumentNullException("partExtension");
            }

            string existedPartExtension = null;
            if ( base.TryGetValue( contentType, out existedPartExtension ) )
            {
                if ( existedPartExtension == partExtension )
                {
                    return;
                }
            }

            base.Add(contentType, partExtension);
        }
        
    }
}
