// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal class PropertyAccessor<TInstance, TProperty>
    {
#if FEATURE_NO_CONDITIONAL_WEAK_TABLE
        private static readonly LockingDictionary<Type, Func<TProperty>> _activatorCache = new LockingDictionary<Type, Func<TProperty>>();
#else
        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<Type, Func<TProperty>> _activatorCache = new System.Runtime.CompilerServices.ConditionalWeakTable<Type, Func<TProperty>>();
#endif

        private readonly PropertyInfo _property;

        private Func<TInstance, TProperty> _getter;
        private Action<TInstance, TProperty> _setter;
        private Func<TProperty> _activator;

        public PropertyAccessor(PropertyInfo property)
        {
            _property = property;
        }

        public TProperty Get(TInstance instance)
        {
            if (_getter is null)
            {
                lock (this)
                {
                    if (_getter is null)
                    {
                        _getter = CreateGetter(_property);
                    }
                }
            }

            return _getter(instance);
        }

        public void Set(TInstance instance, TProperty value)
        {
            if (_setter is null)
            {
                lock (this)
                {
                    if (_setter is null)
                    {
                        _setter = CreateSetter(_property);
                    }
                }
            }

            _setter(instance, value);
        }

        public TProperty Create()
        {
            if (_activator is null)
            {
                lock (this)
                {
                    if (_activator is null)
                    {
                        _activator = _activatorCache.GetValue(typeof(TProperty), CreateActivator);
                    }
                }
            }

            return _activator();
        }

        private static Func<TInstance, TProperty> CreateGetter(PropertyInfo property)
        {
#if NETSTANDARD1_3
            var method = property.GetMethod;
#else
            var method = property.GetGetMethod();
#endif

            var instance = Expression.Parameter(typeof(TInstance), "instance");
            var instanceCast = Expression.Convert(instance, property.DeclaringType);
            var result = Expression.Convert(Expression.Call(instanceCast, method), typeof(TProperty));

            return Expression.Lambda<Func<TInstance, TProperty>>(result, instance).Compile();
        }

        private static Action<TInstance, TProperty> CreateSetter(PropertyInfo property)
        {
#if NETSTANDARD1_3
            var method = property.SetMethod;
#else
            var method = property.GetSetMethod();
#endif

            var instance = Expression.Parameter(typeof(TInstance), "instance");
            var instanceCast = Expression.Convert(instance, property.DeclaringType);

            var param = Expression.Parameter(typeof(TProperty), "value");
            var paramCast = Expression.Convert(param, property.PropertyType);

            var result = Expression.Call(instanceCast, method, paramCast);

            return Expression.Lambda<Action<TInstance, TProperty>>(result, instance, param).Compile();
        }

        private static Func<TProperty> CreateActivator(Type type)
        {
#if NETSTANDARD1_3
            var constructor = type.GetTypeInfo().DeclaredConstructors.FirstOrDefault(c => !c.GetParameters().Any());
#else
            var constructor = type.GetConstructor(Type.EmptyTypes);
#endif

            if (constructor is null)
            {
                throw new ArgumentOutOfRangeException(nameof(type));
            }

            return Expression.Lambda<Func<TProperty>>(Expression.New(constructor)).Compile();
        }
    }
}
