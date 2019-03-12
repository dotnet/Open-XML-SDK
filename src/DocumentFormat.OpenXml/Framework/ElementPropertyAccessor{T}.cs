// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal class ElementPropertyAccessor<T>
    {
        private PropertyInfo _property;
        private PackageCache _cache;
        private Func<OpenXmlElement, T> _getter;
        private Action<OpenXmlElement, T> _setter;
        private Func<T> _activator;

        public ElementPropertyAccessor(PackageCache cache, PropertyInfo property)
        {
            _property = property;
            _cache = cache;
        }

        public T Get(OpenXmlElement instance)
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

        public void Set(OpenXmlElement instance, T value)
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

        public T Create()
        {
            if (_activator is null)
            {
                lock (this)
                {
                    if (_activator is null)
                    {
                        _activator = _cache.GetFactory<T>(_property.PropertyType);
                        _cache = null;
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

        private static Func<OpenXmlElement, T> CreateGetter(PropertyInfo property)
        {
#if NETSTANDARD1_3
            var method = property.GetMethod;
#else
            var method = property.GetGetMethod();
#endif

            var instance = Expression.Parameter(typeof(OpenXmlElement), "instance");
            var instanceCast = Expression.Convert(instance, property.DeclaringType);
            var result = Expression.Convert(Expression.Call(instanceCast, method), typeof(T));

            return Expression.Lambda<Func<OpenXmlElement, T>>(result, instance).Compile();
        }

        private static Action<OpenXmlElement, T> CreateSetter(PropertyInfo property)
        {
#if NETSTANDARD1_3
            var method = property.SetMethod;
#else
            var method = property.GetSetMethod();
#endif

            var instance = Expression.Parameter(typeof(OpenXmlElement), "instance");
            var instanceCast = Expression.Convert(instance, property.DeclaringType);

            var param = Expression.Parameter(typeof(T), "value");
            var paramCast = Expression.Convert(param, property.PropertyType);

            var result = Expression.Call(instanceCast, method, paramCast);

            return Expression.Lambda<Action<OpenXmlElement, T>>(result, instance, param).Compile();
        }
    }
}
