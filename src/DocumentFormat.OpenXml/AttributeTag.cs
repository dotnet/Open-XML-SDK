// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;

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

    internal readonly struct AttributeTag
    {
        private static ConditionalWeakTable<Type, AttributeTag[]> _tags = new ConditionalWeakTable<Type, AttributeTag[]>();

        public static AttributeTag[] Load(Type type)
        {
            return _tags.GetValue(type, t =>
            {
                return t.GetRuntimeProperties()
                    .Where(p => p.GetCustomAttribute<SchemaAttrAttribute>() != null)
                    .OrderBy(p => p.GetCustomAttribute<SchemaIndexAttribute>().Index)
                    .Select(Create)
                    .ToArray();
            });
        }

        private readonly Func<OpenXmlSimpleType> _factory;
        private readonly Func<OpenXmlElement, OpenXmlSimpleType> _getter;
        private readonly Action<OpenXmlElement, OpenXmlSimpleType> _setter;

        private static AttributeTag Create(PropertyInfo property)
        {
            var schema = property.GetCustomAttribute<SchemaAttrAttribute>();

            var tag = new AttributeTag(
                schema.NamespaceId,
                schema.Tag,
                property.CreateGetter<OpenXmlElement, OpenXmlSimpleType>(),
                property.CreateSetter<OpenXmlElement, OpenXmlSimpleType>(),
                OpenXmlSimpleType.CreateFactory(property.PropertyType));

            return tag;
        }

        private AttributeTag(
            byte namespaceId,
            string name,
            Func<OpenXmlElement, OpenXmlSimpleType> getter,
            Action<OpenXmlElement, OpenXmlSimpleType> setter,
            Func<OpenXmlSimpleType> factory)
        {
            _factory = factory;
            _getter = getter;
            _setter = setter;

            Name = name;
            NamespaceId = namespaceId;
        }

        public string Name { get; }

        public byte NamespaceId { get; }

        public string Namespace => NamespaceIdMap.GetNamespaceUri(NamespaceId);

        public string NamespacePrefix => NamespaceIdMap.GetNamespacePrefix(NamespaceId);

        public OpenXmlSimpleType GetValue(OpenXmlElement element) => _getter(element);

        public void SetValue(OpenXmlElement element, OpenXmlSimpleType value) => _setter(element, value);

        public OpenXmlSimpleType CreateNew() => _factory();

        public XmlQualifiedName GetQName() => new XmlQualifiedName(Name, Namespace);
    }
}
