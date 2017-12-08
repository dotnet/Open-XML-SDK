using System;

namespace DocumentFormat.OpenXml
{
    internal static class PartActivator
    {
        public static T CreateInstance<T>()
        {
            return (T)Activator.CreateInstance(typeof(T), true);
        }
    }
}
