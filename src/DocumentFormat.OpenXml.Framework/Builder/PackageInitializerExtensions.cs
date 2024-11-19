// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Builder;

internal static class PackageInitializerExtensions
{
    private const string Key = "__RegisteredPackageInitializers";

    public static IPackageBuilder<TPackage> WithInitializer<TPackage>(this IPackageBuilder<TPackage> builder, Action<OpenXmlPackage> initializer)
        where TPackage : OpenXmlPackage
    {
        return builder.WithInitializer(new DelegateInitializer(initializer));
    }

    public static IPackageBuilder<TPackage> WithInitializer<TPackage>(this IPackageBuilder<TPackage> builder, IPackageInitializer initializer)
        where TPackage : OpenXmlPackage
    {
        if (builder.Properties.TryGetValue(Key, out var existing) && existing is List<IPackageInitializer> initializers)
        {
            initializers.Add(initializer);
        }
        else
        {
            builder.Properties[Key] = new List<IPackageInitializer> { initializer };
        }

        return builder;
    }

    public static List<IPackageInitializer>? GetInitializers<TPackage>(this IPackageBuilder<TPackage> builder)
       where TPackage : OpenXmlPackage
    {
        if (builder.Properties.TryGetValue(Key, out var existing) && existing is List<IPackageInitializer> initializers)
        {
            return initializers;
        }

        return null;
    }

    private sealed class DelegateInitializer : IPackageInitializer
    {
        private readonly Action<OpenXmlPackage> _action;

        public DelegateInitializer(Action<OpenXmlPackage> action)
        {
            _action = action;
        }

        public void Initialize(OpenXmlPackage package) => _action(package);
    }
}
