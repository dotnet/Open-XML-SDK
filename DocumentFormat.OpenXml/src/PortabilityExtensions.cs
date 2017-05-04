using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml
{

#if !FEATURE_CLONEABLE
    internal interface ICloneable
    {
        object Clone();
    }
#endif

#if !FEATURE_SERIALIZATION
    internal sealed class SerializableAttribute : Attribute
    {
    }

    internal sealed class NonSerializedAttribute : Attribute
    {
    }
#endif

    internal static class ReflectionExtensions
    {
        /// <summary>
        /// .NET Standard 1.3 has the same API, but it will not find non-public constructors. Therefore, we will manually
        /// search for the constructor and invoke it.
        /// </summary>
        public static T CreateInstance<T>()
        {
#if FEATURE_ACTIVATOR_PRIVATE_CREATE
            return (T)Activator.CreateInstance(typeof(T), true);
#else
            var constructors = typeof(T).GetTypeInfo().DeclaredConstructors.First(c => c.GetParameters().Length == 0);
            return (T)constructors.Invoke(null);
#endif
        }


#if !FEATURE_ISSUBCLASSOF
        /// <summary>
        /// .NET Standard 1.3 does not have an equivalent API for this, but it is fairly
        /// trivial to replicate
        /// </summary>
        public static bool IsSubclassOf(this Type p, Type c)
        {
            if (p == c)
            {
                return false;
            }

            while (p != null)
            {
                if (p == c)
                {
                    return true;
                }

                p = p.GetTypeInfo().BaseType;
            }

            return false;
        }
#endif

// TypeInfo is used in the code base as .NET Standard requires it. However, .NET 4.0 and .NET 3.5 do not have this or other
// convience methods introduced in .NET 4.5 that are used. This provides similar functionality
#if !FEATURE_TYPEINFO
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

        public static FieldInfo GetDeclaredField(this Type type, String name)
        {
            return type.GetField(name);
        }
#endif
    }

#if !FEATURE_IREADONLYLIST
    internal interface IReadOnlyList<T> : IReadOnlyCollection<T>
    {
        T this[int index] { get; }
    }

    internal interface IReadOnlyCollection<T> : IEnumerable<T>
    {
        int Count { get; }
    }
#endif
}