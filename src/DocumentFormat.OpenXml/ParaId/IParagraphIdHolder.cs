// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines operations for elements holding w14:paraId (ParagraphId) values,
    /// i.e., <see cref="Paragraph" /> and <see cref="TableRow" /> instances.
    /// </summary>
    internal interface IParagraphIdHolder
    {
        /// <summary>
        /// <para>Gets or sets the w14:paraId attribute value.</para>
        /// <para>This property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: w14:paraId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w14=http://schemas.microsoft.com/office/word/2010/wordml
        /// </remark>
        HexBinaryValue? ParagraphId { get; set; }

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
        /// <param name="paragraphIdGenerator">The <see cref="IParagraphIdGenerator" /> used to create the random and unique value.</param>
        string SetUniqueParagraphId(IParagraphIdGenerator paragraphIdGenerator);
    }
}
