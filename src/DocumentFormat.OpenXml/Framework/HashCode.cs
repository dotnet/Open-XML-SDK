// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Framework
{
    internal struct HashCode
    {
        public static int Combine<T1, T2>(T1 t1, T2 t2)
        {
            unchecked
            {
                var hash = 19;
                hash = hash * 13 + (t1?.GetHashCode() ?? 0);
                hash = hash * 13 + (t2?.GetHashCode() ?? 0);
                return hash;
            }
        }

        public static int Combine<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            unchecked
            {
                var hash = 19;
                hash = hash * 13 + (t1?.GetHashCode() ?? 0);
                hash = hash * 13 + (t2?.GetHashCode() ?? 0);
                hash = hash * 13 + (t3?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}
