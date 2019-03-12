// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal static class ElementPropertyCollection
    {
        public static ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> GetProperties(PackageCache cache, Type type)
        {
            SchemaIndex GetSchema(PropertyInfo property)
            {
                var schema = property.GetCustomAttribute<SchemaAttrAttribute>();
                var index = property.GetCustomAttribute<IndexAttribute>();

                return new SchemaIndex(schema, index);
            }

            return ElementPropertyCollection<OpenXmlSimpleType>.GetProperties(cache, type, GetSchema);
        }

        public static ReadOnlyArray<ElementProperty<OpenXmlElement>> GetElements(PackageCache cache, Type type)
        {
            SchemaIndex GetSchema(PropertyInfo property)
            {
                var index = property.GetCustomAttribute<IndexAttribute>();
                var schema = cache.GetElementTypeInfo(property.PropertyType).Schema;

                return new SchemaIndex(schema, index);
            }

            return ElementPropertyCollection<OpenXmlElement>.GetProperties(cache, type, GetSchema);
        }
    }
}
