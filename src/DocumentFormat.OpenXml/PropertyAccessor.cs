// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

#if FEATURE_NO_CONDITIONAL_WEAK_TABLE
using TagLookup = DocumentFormat.OpenXml.LockingDictionary<System.Type, DocumentFormat.OpenXml.AttributeTag[]>;
#else
#endif

namespace DocumentFormat.OpenXml
{
    internal class PropertyAccessor<TInstance, TProperty>
    {
        private static readonly Dictionary<Type, Func<TProperty>> _activatorCache = new Dictionary<Type, Func<TProperty>>();

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
                        _activator = CreateActivator(_property.PropertyType);
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

            var isValueType = property.DeclaringType.GetTypeInfo().IsValueType;
            var instance = Expression.Parameter(typeof(TInstance), "instance");
            var instanceCast = !isValueType ?
                Expression.TypeAs(instance, property.DeclaringType) :
                Expression.Convert(instance, property.DeclaringType);

            return Expression.Lambda<Func<TInstance, TProperty>>(
                Expression.TypeAs(
                    Expression.Call(instanceCast, method),
                    typeof(TProperty)),
                instance)
                .Compile();
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

            return Expression.Lambda<Action<TInstance, TProperty>>(
                Expression.Call(instanceCast, method, paramCast),
                instance, param).Compile();
        }

        private static Func<TProperty> CreateActivator(Type type)
        {
            if (!_activatorCache.TryGetValue(type, out var activator))
            {
                lock (_activatorCache)
                {
                    if (!_activatorCache.TryGetValue(type, out activator))
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

                        activator = Expression.Lambda<Func<TProperty>>(Expression.New(constructor)).Compile();

                        _activatorCache.Add(type, activator);
                    }
                }
            }

            return activator;
        }
    }
}
