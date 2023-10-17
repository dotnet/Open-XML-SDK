// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System.IO;

namespace DocumentFormat.OpenXml.Builder;

internal static class PackageSaveExtensions
{
    public static void UseSaving(this OpenXmlPackage package)
    {
        package.Features.Set<IPackageSaveFeature>(new DefaultSaveFeature(package));

        if (package.AutoSave)
        {
            package.Features.GetRequired<IDisposableFeature>().Register(() => package.Save());
        }
    }

    private sealed class DefaultSaveFeature : IPackageSaveFeature
    {
        private readonly OpenXmlPackage _package;

        public DefaultSaveFeature(OpenXmlPackage package)
        {
            _package = package;
        }

        public bool ShouldSave => _package.Features.GetRequired<IPackageFeature>().Package.FileOpenAccess != FileAccess.Read;

        public void Save()
            => _package.Features.GetRequired<IPackageFeature>().Package.Save();

        public void Save(OpenXmlPart part)
        {
            // Only save if the part has changed and is loaded
            if (IsPartContentChanged(part) && part.PartRootElement is not null)
            {
                part.PartRootElement.Save();
            }
        }

        private static bool IsPartContentChanged(OpenXmlPart part)
        {
            // If the root element of the part is loaded,
            // consider the part changed and should be saved.
            if (!part.IsRootElementLoaded &&
                part.OpenXmlPackage.MarkupCompatibilityProcessSettings.ProcessMode == MarkupCompatibilityProcessMode.ProcessAllParts)
            {
                if (part.PartRootElement is not null)
                {
                    return true;
                }
            }

            return part.IsRootElementLoaded;
        }
    }
}
