// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Schema;
using DocumentFormat.OpenXml.Validation.Schema;
using System;

namespace DocumentFormat.OpenXml.Framework
{
    /// <summary>
    /// These extensions are set up so that it is easier to test a <see cref="CompiledParticle"/> against an <see cref="OpenXmlCompositeElement"/>.
    /// </summary>
    internal static class ParticleExtensions
    {
        public static ParticleCollection GetCollection(this CompiledParticle compiled, OpenXmlType type, OpenXmlCompositeElement element)
            => new(type, compiled, element);

        public static OpenXmlElement? Get(this CompiledParticle? compiled, OpenXmlCompositeElement element, OpenXmlType type)
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
                if (child.Metadata.Type == type)
                {
                    return child;
                }

                child = child.Next;
            }
            while (child is not null && child != element.FirstChild);

            return null;
        }

        public static bool Set(this CompiledParticle? compiled, OpenXmlCompositeElement parent, OpenXmlElement value)
            => Set(compiled, parent, value, value.Metadata.Type);

        public static bool Set(this CompiledParticle? compiled, OpenXmlCompositeElement parent, OpenXmlElement? value, OpenXmlType? type)
        {
            if (type is null)
            {
                return false;
            }

            if (compiled is null)
            {
                return false;
            }

            var collection = new ParticleCollection(type.Value, compiled, parent);

            collection.Clear();

            if (value is not null)
            {
                return collection.Add(value);
            }

            return true;
        }

        public static CompiledParticle Compile(this CompositeParticle.Builder builder)
            => Compile(builder.Build());

        public static CompiledParticle Compile(this ParticleConstraint? particle)
            => new CompiledParticle(particle);
    }
}
