// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal static class ClassActivator
    {
        public static T CreateInstance<T>() => Utility<T>.Activator();

        private static class Utility<T>
        {
            public static readonly Func<T> Activator = ClassActivator<T>.CreateActivator(typeof(T));
        }
    }
}
