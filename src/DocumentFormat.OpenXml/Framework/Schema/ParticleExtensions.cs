// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using DocumentFormat.OpenXml.Validation.Schema;

namespace DocumentFormat.OpenXml.Framework
{
    /// <summary>
    /// These extensions are set up so that it is easier to test a <see cref="CompiledParticle"/> against an <see cref="OpenXmlCompositeElement"/>.
    /// </summary>
    internal static class ParticleExtensions
    {
        public static ParticleCollection GetCollection<TElement>(this CompiledParticle compiled, OpenXmlCompositeElement element)
            where TElement : OpenXmlElement
            => new ParticleCollection(typeof(TElement), compiled, element);

        public static TElement Get<TElement>(this CompiledParticle compiled, OpenXmlCompositeElement element)
            where TElement : OpenXmlElement
        {
            if (compiled is null)
            {
                return null;
            }

            var child = element.FirstChild;

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

        public static bool Set(this CompiledParticle compiled, OpenXmlCompositeElement parent, OpenXmlElement value)
        {
            if (compiled is null)
            {
                return false;
            }

            if (value is null)
            {
                return false;
            }

            var collection = new ParticleCollection(value.GetType(), compiled, parent);

            collection.Clear();
            return collection.Add(value);
        }

        public static CompiledParticle Compile(this ParticleConstraint particle)
            => new CompiledParticle(particle);
    }
}
