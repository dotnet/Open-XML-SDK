// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;

namespace DocumentFormat.OpenXml
{
    internal static class Cached
    {
#if FEATURE_ARRAY_EMPTY
        public static T[] Array<T>() => System.Array.Empty<T>();
#else
        public static T[] Array<T>() => EmptyArray<T>.Value;

        private static class EmptyArray<T>
        {
            internal static readonly T[] Value = new T[0];
        }
#endif

        public static ReadOnlyCollection<T> ReadOnlyCollection<T>() => ReadOnlyCollectionCache<T>.Value;

        private static class ReadOnlyCollectionCache<T>
        {
            internal static ReadOnlyCollection<T> Value = new ReadOnlyCollection<T>(Array<T>());
        }
    }
}
