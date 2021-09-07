// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal static class ServiceExtensions
    {
        public static T GetRequiredService<T>(this IServiceProvider services) => (T)services.GetService(typeof(T));
    }
}
