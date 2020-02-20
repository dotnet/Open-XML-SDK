// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using DocumentFormat.OpenXml.Validation.Schema;

namespace DocumentFormat.OpenXml.Framework
{
    internal static class ParticleExtensions
    {
        public static ParticleCollection<TElement> GetCollection<TElement>(this CompiledParticle compiled, OpenXmlCompositeElement element)
            where TElement : OpenXmlElement
            => new ParticleCollection<TElement>(compiled, element);

        public static TElement Get<TElement>(this CompiledParticle compiled, OpenXmlCompositeElement element)
            where TElement : OpenXmlElement
        {
            if (compiled is null)
            {
                return null;
            }

            OpenXmlElement child = element.FirstChild;

            if (child is null)
            {
                return null;
            }

            do
            {
                if (child.GetType() == typeof(TElement))
                {
                    return (TElement)child;
                }

                child = child.Next;
            } while (child != element.FirstChild);

            return null;
        }

        public static bool Set<TElement>(this CompiledParticle compiled, OpenXmlCompositeElement parent, TElement value)
            where TElement : OpenXmlElement
        {
            if (compiled is null)
            {
                return false;
            }

            var collection = GetCollection<TElement>(compiled, parent);

            collection.Clear();
            return collection.Add(value);
        }

        public static CompiledParticle Compile(this ParticleConstraint particle)
            => new CompiledParticle(particle);
    }
}
