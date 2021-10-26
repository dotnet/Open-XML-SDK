// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Extensions to add events around part roots.
    /// </summary>
    public static class PartRootEventExtensions
    {
        /// <summary>
        /// Adds a feature to track eventing for a package lifecycle events.
        /// </summary>
        /// <param name="container">Container to add the feature to.</param>
        public static void AddPartRootEventsFeature(this OpenXmlPartContainer container)
        {
            if (container.Features.Get<IPartRootEventsFeature>() is null)
            {
                container.Features.Set<IPartRootEventsFeature>(new PartRootEventsFeature());
            }
        }

        internal static void OnChange(this IPartRootEventsFeature events, EventType type, OpenXmlPart? part)
        {
            if (part is not null && events is IRaiseFeatureEvent<OpenXmlPart> raise)
            {
                raise.OnChange(type, part);
            }
        }

        private class PartRootEventsFeature : FeatureEvent<OpenXmlPart>, IPartRootEventsFeature
        {
        }
    }
}
