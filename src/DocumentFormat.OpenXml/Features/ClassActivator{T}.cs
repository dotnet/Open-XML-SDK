// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

#if NETSTANDARD1_3
using System.Linq;
#endif

namespace DocumentFormat.OpenXml.Features
{
    internal static class ClassActivator<T>
    {
        public static Func<T> CreateActivator(Type type)
        {
#if DEBUG
            Debug.Assert(typeof(T).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()));
#endif

#if NETSTANDARD1_3
            var constructor = type.GetTypeInfo().DeclaredConstructors.FirstOrDefault(c => !c.GetParameters().Any() && !c.IsStatic);
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
