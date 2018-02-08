// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
