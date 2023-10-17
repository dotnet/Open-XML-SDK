// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using System;

namespace DocumentFormat.OpenXml.Packaging;

/// <summary>
/// Extension methods that attempt to enable support in a few areas for multi-threaded package access
/// </summary>
internal static class PackageLockingExtensions
{
    /// <summary>
    /// Enables a few multi-threaded package access scenarios. This is not exhaustive, but currently enables some basic
    /// locking around the following scenarios:
    /// <list type="bullet">
    /// <item>Saving</item>
    /// <item>Cloning</item>
    /// </list>
    /// </summary>
    public static void UseLocking<TPackage>(this TPackage package)
        where TPackage : OpenXmlPackage
    {
        if (package is null)
        {
            throw new ArgumentNullException(nameof(package));
        }

        var lockFeature = new LockedFeature<TPackage>(package);

        package.Features.Set<IPackageSaveFeature>(lockFeature);
        package.Features.Set<ICloningFeature<TPackage>>(lockFeature);
    }

    private sealed class LockedFeature<TPackage> : ICloningFeature<TPackage>, IPackageSaveFeature
        where TPackage : OpenXmlPackage
    {
        private readonly object _syncLock = new();
        private readonly ICloningFeature<TPackage> _clone;
        private readonly IPackageSaveFeature _save;

        public LockedFeature(TPackage package)
        {
            _clone = package.Features.GetRequired<ICloningFeature<TPackage>>();
            _save = package.Features.GetRequired<IPackageSaveFeature>();
        }

        void ICloningFeature<TPackage>.CopyParts(TPackage destination, OpenSettings? settings)
        {
            lock (_syncLock)
            {
                _clone.CopyParts(destination, settings);
            }
        }

        void IPackageSaveFeature.Save()
        {
            lock (_syncLock)
            {
                _save.Save();
            }
        }
    }
}
