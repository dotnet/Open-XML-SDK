// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
