using System;
using System.Linq;
using System.Reflection;

namespace System
{
    internal static class ReflectionExtensions
    {
        public static T CreateInstance<T>()
        {
            return (T)Activator.CreateInstance(typeof(T), true);
        }
    }
}
