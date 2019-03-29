// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal static class ElementPropertyCollection
    {
        public static ReadOnlyArray<ElementProperty<OpenXmlSimpleType>> GetProperties(Func<Type, Func<OpenXmlSimpleType>> activatorFactory, Type type)
        {
            SchemaIndex GetSchema(PropertyInfo property)
            {
                var schema = property.GetCustomAttribute<SchemaAttrAttribute>();
                var index = property.GetCustomAttribute<IndexAttribute>();

                return new SchemaIndex(schema, index);
            }

            return ElementPropertyCollection<OpenXmlSimpleType>.GetProperties(activatorFactory, type, GetSchema);
        }

        public static ReadOnlyArray<ElementProperty<OpenXmlElement>> GetElements(Func<Type, Func<OpenXmlElement>> activatorFactory, Func<Type, SchemaAttrAttribute> elementSchemaFactory, Type type)
        {
            SchemaIndex GetSchema(PropertyInfo property)
            {
                var index = property.GetCustomAttribute<IndexAttribute>();
                var schema = elementSchemaFactory(property.PropertyType);

                return new SchemaIndex(schema, index);
            }

            return ElementPropertyCollection<OpenXmlElement>.GetProperties(activatorFactory, type, GetSchema);
        }
    }
}
