// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Framework
{
    /// <summary>
    /// Represents a collection of features.
    /// </summary>
    public interface IFeatureCollection
    {
        /// <summary>
        /// Gets or sets a given feature. Setting a null value removes the feature.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The requested feature, or null if it is not present.</returns>
        object? this[Type key] { get; set; }

        /// <summary>
        /// Gets a value indicating whether the collection can be modified.
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Gets a value that is incremented for each modification and can be used to verify cached results.
        /// </summary>
        int Revision { get; }

        /// <summary>
        /// Retrieves the requested feature from the collection.
        /// </summary>
        /// <typeparam name="TFeature">The feature key.</typeparam>
        /// <returns>The requested feature, or null if it is not present.</returns>
        TFeature? Get<TFeature>();

        /// <summary>
        /// Sets the given feature in the collection.
        /// </summary>
        /// <typeparam name="TFeature">The feature key.</typeparam>
        /// <param name="instance">The feature value.</param>
        void Set<TFeature>(TFeature? instance);
    }
}
