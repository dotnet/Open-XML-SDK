// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Framework
{
    internal static class ElementPropertyExtensions
    {
        public static ElementPropertyCollection<T> WrapElement<T>(this ReadOnlyArray<ElementProperty<T>> array, OpenXmlElement element) => new ElementPropertyCollection<T>(element, array);
    }
}
