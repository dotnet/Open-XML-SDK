// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    internal static class ServiceExtensions
    {
        public static T GetRequiredService<T>(this IServiceProvider services)
            where T : class
        {
            if (services.GetService(typeof(T)) is T t)
            {
                return t;
            }

            throw new InvalidOperationException(SR.Format(ExceptionMessages.UnknownService, typeof(T).FullName));
        }
    }
}
