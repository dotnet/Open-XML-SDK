// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal static class ReflectionExtensions
    {
        public static Func<TIn, TOut> CreateGetter<TIn, TOut>(this PropertyInfo property)
        {
            var method = property.GetMethod;
            var isValueType = property.DeclaringType.GetTypeInfo().IsValueType;
            var instance = Expression.Parameter(typeof(TIn), "instance");
            var instanceCast = !isValueType ?
                Expression.TypeAs(instance, property.DeclaringType) :
                Expression.Convert(instance, property.DeclaringType);

            return Expression.Lambda<Func<TIn, TOut>>(
                Expression.TypeAs(
                    Expression.Call(instanceCast, method),
                    typeof(TOut)),
                instance)
                .Compile();
        }

        public static Action<TIn, TValue> CreateSetter<TIn, TValue>(this PropertyInfo property)
        {
            var method = property.SetMethod;

            var instance = Expression.Parameter(typeof(TIn), "instance");
            var instanceCast = Expression.Convert(instance, property.DeclaringType);

            var param = Expression.Parameter(typeof(TValue), "value");
            var paramCast = Expression.Convert(param, property.PropertyType);

            return Expression.Lambda<Action<TIn, TValue>>(
                Expression.Call(instanceCast, method, paramCast),
                instance, param).Compile();
        }
    }
}
