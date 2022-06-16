// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Framework
{
    /// <summary>
    /// A helpful utility to generate hashcodes. This is in box in .NET Core 2.1 and .NET Standard 2.1 (and later versions)
    /// but this provides support for down-level. This does not implement as sophisticated an algorithm as that version does,
    /// but this should be sufficient for most use cases.
    /// </summary>
    internal struct HashCode
    {
        private const int Seed = 23;
        private const int Combinator = 37;

        private int _code;

        public void Add<T>(T? item)
            => Add(item?.GetHashCode() ?? 0);

        public void Add<T>(T? item, IEqualityComparer<T> comparer)
        {
            if (comparer is null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            if (item is null)
            {
                return;
            }

            Add(comparer.GetHashCode(item));
        }

        public int ToHashCode() => _code;

        public static int Combine<T1, T2>(T1 t1, T2 t2)
        {
            var hashcode = default(HashCode);

            hashcode.Add(t1);
            hashcode.Add(t2);

            return hashcode.ToHashCode();
        }

        public static int Combine<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            var hashcode = default(HashCode);

            hashcode.Add(t1);
            hashcode.Add(t2);
            hashcode.Add(t3);

            return hashcode.ToHashCode();
        }

        public static int Combine<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            var hashcode = default(HashCode);

            hashcode.Add(t1);
            hashcode.Add(t2);
            hashcode.Add(t3);
            hashcode.Add(t4);

            return hashcode.ToHashCode();
        }

        private void Add(int value)
        {
            unchecked
            {
                var code = _code;

                if (code == 0)
                {
                    code = Seed;
                }

                _code = (code * Combinator) + value;
            }
        }
    }
}
