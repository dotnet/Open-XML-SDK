using System;
using System.Linq;
using System.Reflection;

namespace System
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
#if FEATURE_REFLECTION
            return (T)Activator.CreateInstance(typeof(T), true);
#else
            var constructors = typeof(T).GetTypeInfo().DeclaredConstructors.First(c => c.GetParameters().Length == 0);
            return (T)constructors.Invoke(null);
#endif
        }

#if !FEATURE_REFLECTION
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
    }
}
