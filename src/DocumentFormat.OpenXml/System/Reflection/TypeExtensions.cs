// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// TypeInfo is used in the code base as .NET Standard requires it. However, .NET 4.0 and .NET 3.5 do not have this or other
    /// convience methods introduced in .NET 4.5 that are used. This provides similar functionality.
    /// </summary>
    internal static class TypeExtensions
    {
        public static Type GetTypeInfo(this Type type) => type;

        public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttribute(element, attributeType);
        }

        public static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute
        {
            return (T)GetCustomAttribute(element, typeof(T));
        }

        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
        {
            return Attribute.GetCustomAttributes(element, attributeType);
        }

        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute
        {
            return (IEnumerable<T>)GetCustomAttributes(element, typeof(T));
        }

        public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit)
        {
            return Attribute.GetCustomAttributes(element, attributeType, inherit);
        }

        public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit) where T : Attribute
        {
            return (IEnumerable<T>)GetCustomAttributes(element, typeof(T), inherit);
        }

        public static FieldInfo GetDeclaredField(this Type type, string name)
        {
            return type.GetField(name);
        }
    }
}
