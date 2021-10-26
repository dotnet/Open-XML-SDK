// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Extensions to add events around parts.
    /// </summary>
    public static class PartEventFeatureExtensions
    {
        /// <summary>
        /// Adds a feature to track eventing for a package creating or removing parts.
        /// </summary>
        /// <param name="package">Package to add the feature to.</param>
        public static void AddPartEventsFeature(this OpenXmlPackage package)
        {
            if (package.Features.Get<IPartEventsFeature>() is null)
            {
                package.Features.Set<IPartEventsFeature>(new PartEventsFeature());
            }
        }

        internal static void OnChange(this IPartEventsFeature events, OpenXmlPart part, EventType type)
        {
            if (events is IRaiseFeatureEvent<OpenXmlPart> raise)
            {
                raise.OnChange(type, part);
            }
        }

        private class PartEventsFeature : FeatureEvent<OpenXmlPart>, IPartEventsFeature
        {
        }
    }
}
