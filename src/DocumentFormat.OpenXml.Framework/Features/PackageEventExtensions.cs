// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Extensions to add events around lifecycle.
    /// </summary>
    public static class PackageEventExtensions
    {
        /// <summary>
        /// Adds a feature to track eventing for a package lifecycle events.
        /// </summary>
        /// <param name="package">Package to add the feature to.</param>
        public static void AddPackageEventsFeature(this OpenXmlPackage package)
        {
            if (package.Features.Get<IPackageEventsFeature>() is null)
            {
                package.Features.Set<IPackageEventsFeature>(new PackageClosingEventsFeature());
            }
        }

        internal static void OnChange(this IPackageEventsFeature events, OpenXmlPackage package, EventType type)
        {
            if (events is IRaiseFeatureEvent<OpenXmlPackage> raise)
            {
                raise.OnChange(type, package);
            }
        }

        private class PackageClosingEventsFeature : FeatureEvent<OpenXmlPackage>, IPackageEventsFeature
        {
        }
    }
}
