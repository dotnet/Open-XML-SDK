// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Features;

internal class ReflectionPartFactory : IPartFactory
{
    public T Create<T>() where T : OpenXmlPart => Utility<T>.Activator();

    private static class Utility<T>
    {
        public static readonly Func<T> Activator = ClassActivator<T>.CreateActivator(typeof(T));
    }
}
