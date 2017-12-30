// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Schema;

namespace OfficeSchemaProcessor
{
    internal static class FlattenExtensions
    {
        public static void Flatten(this XmlSchema schema)
        {
            foreach (XmlSchemaType type in schema.SchemaTypes.Values)
            {
                FlattenComplexType(type as XmlSchemaComplexType);
            }
        }

        private static void FlattenComplexType(XmlSchemaComplexType cType)
        {
            if (cType == null || cType.Particle == null)
            {
                return;
            }

            if (cType.Particle is XmlSchemaGroupBase groupBase)
            {
                XmlSchemaSequence newParticle = new XmlSchemaSequence();
                GetElementsFromGroupBase(groupBase, newParticle);
                cType.Particle = newParticle;
            }
            else
            {
                throw new XmlSchemaException("particle of complex type contain invalid content");
            }
        }

        private static void GetElementsFromGroupBase(XmlSchemaGroupBase group, XmlSchemaSequence container)
        {
            if (group == null)
            {
                return;
            }

            foreach (XmlSchemaObject o in group.Items)
            {
                if (o is XmlSchemaElement)
                {
                    container.Items.Add(o);
                }
                else if (o is XmlSchemaGroupBase gBase)
                {
                    GetElementsFromGroupBase(gBase, container);
                }
                else
                {
                    throw new XmlSchemaException("Sequence particle contains unwanted content");
                }
            }
        }
    }
}
