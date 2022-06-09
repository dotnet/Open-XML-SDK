// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// A generator for paragraph id values that can ensure uniqueness if <see cref="IParagraphIdCollectionFeature"/> is registered.
    /// </summary>
    public interface IParagraphIdGeneratorFeature
    {
        /// <summary>
        /// Creates a w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, and unique within the scope of the <see cref="IParagraphIdCollectionFeature" />
        /// instance.
        /// </summary>
        /// <returns>A unique paragraph id value.</returns>
        string CreateUniqueParagraphId();
    }
}
