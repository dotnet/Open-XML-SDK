// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal class PropertyAccessor<TInstance, TProperty>
    {
        private PropertyInfo _property;
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
                        CleanUp();
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
                        CleanUp();
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
                        _activator = ClassActivator<TProperty>.GetActivator(_property.PropertyType);
                        CleanUp();
                    }
                }
            }

            return _activator();
        }

        /// <summary>
        /// Once all delegates are created, we do not need to continue to hold onto <see cref="_property"/>
        /// </summary>
        private void CleanUp()
        {
            if (_getter is null && _setter is null && _activator is null)
            {
                _property = null;
            }
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
    }
}
