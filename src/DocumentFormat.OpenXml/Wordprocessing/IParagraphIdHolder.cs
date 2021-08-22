// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines operations for elements holding w14:paraId (ParagraphId) values,
    /// i.e., <see cref="Paragraph" /> and <see cref="TableRow" /> instances.
    /// </summary>
    public interface IParagraphIdHolder
    {
        /// <summary>
        /// For <see cref="Paragraph" /> and <see cref="TableRow" /> instances that
        /// have already been added to the DOM tree, sets the w14:paraId (ParagraphId)
        /// value to a random and unique value.
        /// </summary>
        /// <exception cref="InvalidOperationException">If the paragraph has not been added to a DOM tree.</exception>
        string SetUniqueParagraphId();

        /// <summary>
        /// For <see cref="Paragraph" /> and <see cref="TableRow" /> instances that
        /// have not yet been added to the DOM tree, sets the w14:paraId (ParagraphId)
        /// value to a random and unique value.
        /// </summary>
        /// <param name="paragraphIdService">The <see cref="IParagraphIdService" /> used to create the random and unique value.</param>
        string SetUniqueParagraphId(IParagraphIdService paragraphIdService);
    }
}
