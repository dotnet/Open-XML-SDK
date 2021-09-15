// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Defines the operations of the w14:paraId (ParagraphId) generator.
    /// </summary>
    public interface IParagraphIdFeature
    {
        /// <summary>
        /// Gets the w14:paraId values that have been registered with the
        /// <see cref="IParagraphIdFeature" /> instance.
        /// </summary>
        IEnumerable<string> RegisteredParagraphIds { get; }

        /// <summary>
        /// Gets a count of all the registered paragraph ids.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Creates a w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, and unique within the scope of the <see cref="IParagraphIdFeature" />
        /// instance.
        /// </summary>
        /// <returns>
        /// A w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, and unique within the scope of the <see cref="IParagraphIdFeature" />
        /// instance.
        /// </returns>
        string CreateUniqueParagraphId();

        /// <summary>
        /// Identifies if the id exists.
        /// </summary>
        /// <param name="id">The id to check.</param>
        /// <returns>Whether the feature is tracking that id.</returns>
        bool Contains(string id);
    }
}
