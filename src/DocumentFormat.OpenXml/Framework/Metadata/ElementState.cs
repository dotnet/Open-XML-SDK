// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal readonly struct ElementState
    {
        public bool IsEmpty => Attributes.IsEmpty;

        public ElementState(ElementMetadata metadata)
        {
            Attributes = new AttributeCollection(metadata.Attributes);
            Metadata = metadata;
        }

        public AttributeCollection Attributes { get; }

        public ElementMetadata Metadata { get; }
    }
}
