// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System;

namespace DocumentFormat.OpenXml.Framework.Schema
{
    internal class ParticlePathItem : IEquatable<ParticlePathItem>
    {
        public ParticlePathItem(ParticleType type, byte index)
        {
            Type = type;
            Index = index;
        }

        public ParticleType Type { get; }

        public byte Index { get; }

        public void Deconstruct(out ParticleType type, out byte index)
        {
            type = Type;
            index = Index;
        }

        public override bool Equals(object obj)
            => Equals(obj as ParticlePathItem);

        public override string ToString() => $"({Type}:{Index})";

        public bool Equals(ParticlePathItem other)
        {
            if (other is null)
            {
                return false;
            }

            return Type == other.Type && Index == other.Index;
        }

        public override int GetHashCode() => HashCode.Combine(Type, Index);

        public static ParticlePathItem Create(ParticleConstraint particle, byte index)
            => new ParticlePathItem(particle.ParticleType, index);
    }
}
