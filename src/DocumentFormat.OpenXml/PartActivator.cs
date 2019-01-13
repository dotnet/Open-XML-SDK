// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal static class PartActivator<T>
    {
#if FEATURE_NO_CONDITIONAL_WEAK_TABLE
        private static readonly LockingDictionary<Type, Func<T>> _activatorCache = new LockingDictionary<Type, Func<T>>();
#else
        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<Type, Func<T>> _activatorCache = new System.Runtime.CompilerServices.ConditionalWeakTable<Type, Func<T>>();
#endif

        public static T CreateInstance()
        {
            var activator = GetActivator(typeof(T));

            return activator();
        }

        public static Func<T> GetActivator(Type type)
        {
            return _activatorCache.GetValue(type, CreateActivator);
        }

        private static Func<T> CreateActivator(Type type)
        {
#if DEBUG
            Debug.Assert(typeof(T).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()));
#endif

#if NETSTANDARD1_3
            var constructor = type.GetTypeInfo().DeclaredConstructors.FirstOrDefault(c => !c.GetParameters().Any());
#else
            var constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.HasThis, Type.EmptyTypes, null);
#endif

            if (constructor is null)
            {
                throw new ArgumentOutOfRangeException(nameof(type));
            }

            return Expression.Lambda<Func<T>>(Expression.New(constructor)).Compile();
        }
    }
}
