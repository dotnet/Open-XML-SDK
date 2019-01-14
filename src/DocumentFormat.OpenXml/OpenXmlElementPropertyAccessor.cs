// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal class OpenXmlElementPropertyAccessor
    {
        private PropertyInfo _property;
        private PackageCache _cache;
        private Func<OpenXmlElement, OpenXmlSimpleType> _getter;
        private Action<OpenXmlElement, OpenXmlSimpleType> _setter;
        private Func<OpenXmlSimpleType> _activator;

        public OpenXmlElementPropertyAccessor(PackageCache cache, PropertyInfo property)
        {
            _property = property;
            _cache = cache;
        }

        public OpenXmlSimpleType Get(OpenXmlElement instance)
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

        public void Set(OpenXmlElement instance, OpenXmlSimpleType value)
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

        public OpenXmlSimpleType Create()
        {
            if (_activator is null)
            {
                lock (this)
                {
                    if (_activator is null)
                    {
                        _activator = _cache.GetSimpleTypeFactory(_property.PropertyType);
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

        private static Func<OpenXmlElement, OpenXmlSimpleType> CreateGetter(PropertyInfo property)
        {
#if NETSTANDARD1_3
            var method = property.GetMethod;
#else
            var method = property.GetGetMethod();
#endif

            var instance = Expression.Parameter(typeof(OpenXmlElement), "instance");
            var instanceCast = Expression.Convert(instance, property.DeclaringType);
            var result = Expression.Convert(Expression.Call(instanceCast, method), typeof(OpenXmlSimpleType));

            return Expression.Lambda<Func<OpenXmlElement, OpenXmlSimpleType>>(result, instance).Compile();
        }

        private static Action<OpenXmlElement, OpenXmlSimpleType> CreateSetter(PropertyInfo property)
        {
#if NETSTANDARD1_3
            var method = property.SetMethod;
#else
            var method = property.GetSetMethod();
#endif

            var instance = Expression.Parameter(typeof(OpenXmlElement), "instance");
            var instanceCast = Expression.Convert(instance, property.DeclaringType);

            var param = Expression.Parameter(typeof(OpenXmlSimpleType), "value");
            var paramCast = Expression.Convert(param, property.PropertyType);

            var result = Expression.Call(instanceCast, method, paramCast);

            return Expression.Lambda<Action<OpenXmlElement, OpenXmlSimpleType>>(result, instance, param).Compile();
        }
    }
}
