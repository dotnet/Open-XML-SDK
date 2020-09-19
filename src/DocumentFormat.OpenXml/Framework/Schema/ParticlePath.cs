// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;

#if NET35
using System.Linq;
#endif

namespace DocumentFormat.OpenXml.Framework.Schema
{
    internal class ParticlePath : IComparable<ParticlePath>, IEquatable<ParticlePath>
    {
        private readonly ParticlePathItem[] _values;

        public static ParticlePath Create(params ParticlePathItem[] values)
            => new ParticlePath(values);

        private ParticlePath(ParticlePathItem[] values)
        {
            _values = values;
        }

        public ParticleType Type
        {
            get
            {
                if (_values.Length == 0)
                {
                    return ParticleType.Invalid;
                }
                else
                {
                    return _values[_values.Length - 1].Type;
                }
            }
        }

        public int CompareTo(ParticlePath other)
            => CompareTo(other, true);

        public override string ToString()
#if NET35
            => string.Join(", ", _values.Select(v => v.ToString()).ToArray());
#else
            => string.Join(", ", (IEnumerable<ParticlePathItem>)_values);
#endif

        private int CompareTo(ParticlePath other, bool isCompare)
        {
            if (other is null)
            {
                // See https://docs.microsoft.com/en-us/dotnet/api/system.string.compareto
                return 1;
            }

            var en = new Enumerator(this);
            var on = new Enumerator(other);

            while (en.MoveNext() && on.MoveNext())
            {
                var (currentParticleType, currentIndex) = en.Current;
                var (otherParticleType, otherIndex) = on.Current;

                if (currentParticleType == ParticleType.Element && otherParticleType == ParticleType.Element)
                {
                    return currentIndex.CompareTo(otherIndex);
                }
                else if (currentParticleType == ParticleType.Sequence && otherParticleType == ParticleType.Sequence)
                {
                    var compared = currentIndex.CompareTo(otherIndex);

                    if (compared != 0)
                    {
                        return compared;
                    }
                }
                else if (currentParticleType == ParticleType.Choice && otherParticleType == ParticleType.Choice)
                {
                    // If the two elements are at the same index within a choice, we want to continue down the path. If they are
                    // different, we can end and say that we're at an equivalent point.
                    if (currentIndex != otherIndex)
                    {
                        return 0;
                    }
                }
                else if (currentParticleType == ParticleType.All && otherParticleType == ParticleType.All)
                {
                    var compared = currentIndex.CompareTo(otherIndex);

                    if (compared != 0)
                    {
                        // When checking for compare, anything within an All is equivalent. For equality, it needs to be the same
                        return isCompare ? 0 : -1;
                    }
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        public bool IsSibling(ParticlePath other)
          => Equals(other, _values.Length - 1);

        public override bool Equals(object obj)
        {
            if (obj is ParticlePath path)
            {
                return Equals(path);
            }

            return false;
        }

        /// <summary>
        /// Checks if two <see cref="ParticlePath"/> instances are the same. They may not have the exact same sequence, but if they are replaceable, then they are equal.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(ParticlePath other)
            => CompareTo(other, false) == 0;

        public override int GetHashCode()
            => HashCode.Combine(Type, _values.Length);

        private bool Equals(ParticlePath other, int length)
        {
            length = System.Math.Min(other._values.Length, length);

            for (int i = 0; i < length; i++)
            {
                if (!Equals(_values[i], other._values[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private struct Enumerator
        {
            private readonly ParticlePathItem[] _path;
            private int _idx;

            public Enumerator(ParticlePath path)
            {
                _path = path._values;
                _idx = -1;
            }

            public ParticlePathItem Current => _path[_idx];

            public bool MoveNext()
            {
                if (_idx + 1 < _path.Length)
                {
                    _idx++;
                    return true;
                }

                return false;
            }
        }
    }
}
