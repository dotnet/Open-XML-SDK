// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;

namespace DocumentFormat.OpenXml.Packaging.Builder;

internal static class SavePackageExtensions
{
    internal static IFeatureCollection EnableSavePackage(this IFeatureCollection features)
    {
        var feature = features.GetRequired<IPackageFeature>();
        var capabilities = feature.Capabilities;

        if (!capabilities.HasFlagFast(PackageCapabilities.Save) && capabilities.HasFlagFast(PackageCapabilities.Reload))
        {
            features.Set<IPackageFeature>(new SaveablePackage(feature));
        }

        return features;
    }

    private sealed class SaveablePackage : DelegatingPackageFeature
    {
        public SaveablePackage(IPackageFeature package)
            : base(package)
        {
        }

        public override PackageCapabilities Capabilities => base.Capabilities | PackageCapabilities.Save;

        public override void Save() => Feature.Reload();
    }
}
