// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// A feature to create a composite feature if shared among multiple instances.
    /// </summary>
    /// <typeparam name="T">Type of shared feature.</typeparam>
    public interface ISharedFeature<T>
    {
        /// <summary>
        /// Gets the count of features registered.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds an instance to the shared collection.
        /// </summary>
        /// <param name="feature">Feature to add</param>
        void Add(T feature);

        /// <summary>
        /// Removes a feature instance from the shared collection.
        /// </summary>
        /// <param name="feature">Feature to remove.</param>
        /// <returns>Whether the feature was removed or not.</returns>
        bool Remove(T feature);

        /// <summary>
        /// Gets a composite feature that handles delegating to the registered features in the collection.
        /// </summary>
        T Composite { get; }
    }
}
