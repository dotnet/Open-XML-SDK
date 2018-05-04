// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

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

        public static Func<T> Activator<T>() where T : new() => CachedActivator<T>.Activator;

        private static class CachedActivator<T>
            where T : new()
        {
            private static readonly Expression<Func<T>> Creator = () => new T();

            public static Func<T> Activator { get; } = Creator.Compile();
        }

        public static Func<TBase> Activator<TInstance, TBase>()
            where TInstance : TBase, new() => CachedActivator<TInstance, TBase>.Activator;

        private static class CachedActivator<TInstance, TBase>
            where TInstance : TBase, new()
        {
            private static readonly Expression<Func<TBase>> Creator = () => new TInstance();

            public static Func<TBase> Activator { get; } = Creator.Compile();
        }
    }
}
