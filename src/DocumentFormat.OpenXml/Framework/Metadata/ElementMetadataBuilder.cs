// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework.Metadata
{
    internal class ElementMetadataBuilder
    {
        private readonly List<IElementMetadataBuilder> _list = new List<IElementMetadataBuilder>();

        public ElementMetadataBuilder<TElement> AddElement<TElement>()
            where TElement : OpenXmlElement
        {
            var builder = new ElementMetadataBuilder<TElement>();
            _list.Add(builder);
            return builder;
        }

        public ElementProperty<OpenXmlSimpleType>[] Build()
        {
            var final = new List<ElementProperty<OpenXmlSimpleType>>();

            foreach (var list in _list)
            {
                final.AddRange(list.Build());
            }

            return final.ToArray();
        }
    }
}
