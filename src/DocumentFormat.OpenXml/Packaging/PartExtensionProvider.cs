// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

#if FEATURE_SERIALIZATION
using System.Runtime.Serialization;
#endif

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines a provider which maintains a dictionary where the key is the content type and the value is a part extension.
    /// </summary>
    [Serializable]
    public sealed class PartExtensionProvider : Dictionary<string, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartExtensionProvider"/> class that is empty.
        /// </summary>
        public PartExtensionProvider()
            : base(StringComparer.Ordinal)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartExtensionProvider"/> class that contains elements copied from <paramref name="partExtProvider"/>.
        /// </summary>
        /// <param name="partExtProvider">The source <see cref="PartExtensionProvider"/> whose elements are copied to the new <see cref="PartExtensionProvider"/>.</param>
        public PartExtensionProvider(PartExtensionProvider partExtProvider)
            : base(partExtProvider, StringComparer.Ordinal)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PartExtensionProvider"/> that is empty, has the specified initial capacity.
        /// </summary>
        /// <param name="capacity">The initial number of elements that <see cref="PartExtensionProvider"/> can contain.</param>
        public PartExtensionProvider(int capacity)
            : base(capacity, StringComparer.Ordinal)
        {
        }

#if FEATURE_SERIALIZATION
        /// <summary>
        /// Initializes a new instance of <see cref="PartExtensionProvider"/> with serialized data.
        /// </summary>
        /// <param name="info">A <see cref="SerializationInfo"/> object containing the information required to serialize the PartExtensionProvider.</param>
        /// <param name="context">A <see cref="StreamingContext"/> structure containing the source and destination of the serialized stream associated with the PartExtensionProvider.</param>
        private PartExtensionProvider(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif

        /// <summary>
        /// Add a part extension for the specified content type.
        /// </summary>
        /// <param name="contentType">The content type.</param>
        /// <param name="partExtension">Part Extension (".xml") to be used for the part with the specified content type.</param>
        public void AddPartExtension(string contentType, string partExtension)
        {
            Add(contentType, partExtension);
        }

        /// <summary>
        /// Check to make sure the content type and part extension is in the provider. If not, they will be added.
        /// </summary>
        /// <param name="contentType">The content type</param>
        /// <param name="partExtension">Part Extension (".xml") to be used for the part with the specified content type.</param>
        /// <exception cref="ArgumentNullException">Thrown when either parameter is null.</exception>
        public void MakeSurePartExtensionExist(string contentType, string partExtension)
        {
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            if (partExtension == null)
            {
                throw new ArgumentNullException(nameof(partExtension));
            }

            if (TryGetValue(contentType, out string existedPartExtension) && string.Equals(existedPartExtension, partExtension, StringComparison.Ordinal))
            {
                return;
            }

            this[contentType] = partExtension;
        }
    }
}
