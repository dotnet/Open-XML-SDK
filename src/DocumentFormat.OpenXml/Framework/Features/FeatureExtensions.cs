// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Framework.Features
{
    /// <summary>
    /// Methods to help with using <see cref="IFeatureCollection"/>.
    /// </summary>
    public static class FeatureExtensions
    {
        internal static OpenXmlPartData GetPartMetadata(this OpenXmlPartContainer part)
            => part.Features.GetRequired<IPartMetadataProvider>().Parse(part);

        /// <summary>
        /// Gets a required feature from the supplied collection.
        /// </summary>
        /// <typeparam name="TFeature">Feature type.</typeparam>
        /// <param name="features">Features collection to search.</param>
        /// <returns>The available feature.</returns>
        public static TFeature GetRequired<TFeature>(this IFeatureCollection features)
        {
            if (features.Get<TFeature>() is TFeature feature)
            {
                return feature;
            }

            throw new NotSupportedException(SR.Format(ExceptionMessages.FeatureNotRegistered, typeof(TFeature).FullName));
        }
    }
}
