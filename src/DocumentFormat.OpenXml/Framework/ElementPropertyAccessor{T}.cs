// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework
{
    internal class ElementPropertyAccessor<T>
    {
        private readonly Lazy<Func<OpenXmlElement, T>> _getter;
        private readonly Lazy<Action<OpenXmlElement, T>> _setter;
        private readonly Lazy<Func<T>> _activator;

        public ElementPropertyAccessor(Func<Type, Func<T>> activatorFactory, PropertyInfo property)
        {
            _getter = new Lazy<Func<OpenXmlElement, T>>(() => CreateGetter(property), true);
            _setter = new Lazy<Action<OpenXmlElement, T>>(() => CreateSetter(property), true);
            _activator = new Lazy<Func<T>>(() => activatorFactory(property.PropertyType), true);
        }

        public T Get(OpenXmlElement instance) => _getter.Value(instance);

        public void Set(OpenXmlElement instance, T value) => _setter.Value(instance, value);

        public T Create() => _activator.Value();

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
