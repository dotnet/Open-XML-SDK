// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Framework.Schema
{
    internal class ParticleCompiler
    {
        private readonly Stack<ParticlePathItem> _values;
        private readonly List<LookupItem> _path;

        private ParticleCompiler()
        {
            _path = new List<LookupItem>();
            _values = new Stack<ParticlePathItem>(4);
        }

        public static LookupItem[] Compile(ParticleConstraint particle)
        {
            var instance = new ParticleCompiler();
            instance.Visit(particle);

            var result = new LookupItem[instance._path.Count];
            instance._path.CopyTo(result);

            return result;
        }

        private void Visit(ParticleConstraint particle)
        {
            switch (particle)
            {
                case ElementParticle element:
                    {
                        Visit(element);
                        break;
                    }

                case CompositeParticle any when any.ParticleType == ParticleType.Any:
                    {
                        throw new NotSupportedException(ExceptionMessages.AnyParticleTypeNotSupported);
                    }

                case CompositeParticle composite:
                    {
                        VisitComposite(composite);
                        break;
                    }
            }
        }

        private void Visit(ElementParticle element)
        {
            var newValues = new ParticlePathItem[_values.Count];
            _values.CopyTo(newValues, 0);
            Array.Reverse(newValues);

            var particlePath = ParticlePath.Create(newValues);

            _path.Add(new LookupItem(element.ElementType, particlePath));
        }

        private void VisitComposite(CompositeParticle seq)
        {
            var stack = new Stack<ParticleConstraint>(seq.Reverse());
            byte count = 0;

            while (stack.Count > 0)
            {
                var item = stack.Pop();

                if (item.ParticleType == ParticleType.Group && item is CompositeParticle group)
                {
                    foreach (var child in group)
                    {
                        stack.Push(child);
                    }
                }
                else
                {
                    _values.Push(ParticlePathItem.Create(seq, count));
                    count++;
                    Visit(item);
                    _values.Pop();
                }
            }
        }
    }
}
