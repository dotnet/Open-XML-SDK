// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Methods to help with using <see cref="IFeatureCollection"/>.
    /// </summary>
    public static class FeatureExtensions
    {
        internal static OpenXmlPartData GetPartMetadata(this OpenXmlPartContainer part)
            => part.Features.GetRequired<IPartMetadataFeature>().Parse(part);

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
