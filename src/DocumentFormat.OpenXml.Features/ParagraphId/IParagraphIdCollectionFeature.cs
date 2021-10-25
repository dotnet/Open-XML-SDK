// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Provides access to the paragraph id collection in a document.
    /// </summary>
    public interface IParagraphIdCollectionFeature : IEnumerable<string>
    {
        /// <summary>
        /// Gets a count of all the registered paragraph ids.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Identifies if the id exists.
        /// </summary>
        /// <param name="id">The id to check.</param>
        /// <returns>Whether the feature is tracking that id.</returns>
        bool Contains(string id);
    }
}
