// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    /// <summary>
    /// A view over the metadata of an element and the values of its attributes, which the element holds in separate
    /// fields so that each can be created and published on its own.
    /// </summary>
    internal readonly struct ElementState
    {
        // Only the attribute values are stored as the attribute metadata is available from the element metadata,
        // which saves a field on every element.
        private readonly object?[] _attributeData;

        public ElementState(IElementMetadata metadata)
            : this(metadata, AttributeCollection.CreateData(metadata.Attributes))
        {
        }

        public ElementState(IElementMetadata metadata, object?[] attributeData)
        {
            Metadata = metadata;
            _attributeData = attributeData;
        }

        public AttributeCollection Attributes => new(Metadata.Attributes, _attributeData);

        public IElementMetadata Metadata { get; }
    }
}
