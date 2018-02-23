// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml
{
    internal static class PartActivator
    {
        /// <summary>
        /// .NET Standard 1.3 has the same API, but it will not find non-public constructors. Therefore, we will manually
        /// search for the constructor and invoke it.
        /// </summary>
        public static T CreateInstance<T>()
        {
            var constructors = typeof(T).GetTypeInfo().DeclaredConstructors.First(c => c.GetParameters().Length == 0);
            return (T)constructors.Invoke(null);
        }
    }
}
