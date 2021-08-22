// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines the operations of the w14:paraId (ParagraphId) service.
    /// </summary>
    public interface IParagraphIdService
    {
        /// <summary>
        /// Gets the w14:paraId values that have been registered with the
        /// <see cref="IParagraphIdService" /> instance.
        /// </summary>
#if NET35 || NET40
        ICollection<string> RegisteredParagraphIds { get; }
#else
        IReadOnlyCollection<string> RegisteredParagraphIds { get; }
#endif

        /// <summary>
        /// Registers an existing w14:paraId (ParagraphId) value to ensure the uniqueness of
        /// values generated later.
        /// </summary>
        /// <param name="value">The w14:paraId (ParagraphId) value.</param>
        /// <returns>
        /// <see langword="true"/>, if <paramref name="value" /> did not exist; <see langword="false"/>, otherwise.
        /// </returns>
        bool RegisterParagraphId(string value);

        /// <summary>
        /// Registers an existing w14:paraId (ParagraphId) value to ensure the uniqueness of
        /// values generated later.
        /// </summary>
        /// <param name="value">The w14:paraId (ParagraphId) value.</param>
        /// <returns>
        /// <see langword="true"/>, if <paramref name="value" /> did not exist; <see langword="false"/>, otherwise.
        /// </returns>
        /// <exception cref="ArgumentException">If the HexBinaryValue`s InnerText property value is null.</exception>
        bool RegisterParagraphId(HexBinaryValue value);

        /// <summary>
        /// Creates a w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, and unique within the scope of the <see cref="IParagraphIdService" />
        /// instance.
        /// </summary>
        /// <remarks>
        /// The previously existing w14:paraId values are registered when reading the DOM tree
        /// from the OpenXmlPart, using the <see cref="RegisterParagraphId(string)" /> and
        /// <see cref="RegisterParagraphId(HexBinaryValue)" /> methods.
        /// </remarks>
        /// <returns>
        /// A w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, and unique within the scope of the <see cref="IParagraphIdService" />
        /// instance.
        /// </returns>
        string CreateUniqueParagraphId();
    }
}
