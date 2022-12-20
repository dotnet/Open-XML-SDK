// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Methods to help with using <see cref="IFeatureCollection"/>.
    /// </summary>
    public static class FeatureExtensions
    {
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
