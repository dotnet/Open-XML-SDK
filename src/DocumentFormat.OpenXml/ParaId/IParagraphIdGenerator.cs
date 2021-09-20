// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// Defines the operations of the w14:paraId (ParagraphId) generator.
    /// </summary>
    public interface IParagraphIdGenerator
    {
        /// <summary>
        /// Gets the w14:paraId values that have been registered with the
        /// <see cref="IParagraphIdGenerator" /> instance.
        /// </summary>
        IEnumerable<string> RegisteredParagraphIds { get; }

        /// <summary>
        /// Creates a w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, and unique within the scope of the <see cref="IParagraphIdGenerator" />
        /// instance.
        /// </summary>
        /// <returns>
        /// A w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, and unique within the scope of the <see cref="IParagraphIdGenerator" />
        /// instance.
        /// </returns>
        string CreateUniqueParagraphId();

        /// <summary>
        /// Assigns unique w14:paraId (ParagraphId) values to w:p (Paragraph) and w:tr (TableRow)
        /// elements where those elements do not have a w14:paraId value or such values are not
        /// unique within the given <see cref="WordprocessingDocument" />.
        /// </summary>
        /// <param name="wordDocument">The <see cref="WordprocessingDocument" />.</param>
        void AssignUniqueParagraphIds(WordprocessingDocument wordDocument);

        /// <summary>
        /// Registers all w14:paraId (ParagraphId) values existing in the given
        /// <see cref="WordprocessingDocument" />.
        /// </summary>
        /// <param name="wordDocument">The <see cref="WordprocessingDocument" />.</param>
        /// <remarks>
        /// <para>
        /// This method ensures all w14:paraId (ParagraphId) values are registered by loading
        /// all relevant part root elements and reading all w:p (Paragraph) and w:tr (TableRow)
        /// descendents of such part root elements.
        /// </para>
        /// <para>
        /// This method can be used to ensure uniqueness of w14:paraId (ParagraphId) values
        /// across all parts that can contain w:p (Paragraph) and w:tr (TableRow) elements
        /// by first registering all w14:paraId (ParagraphId) values and only then generating
        /// new values.
        /// </para>
        /// </remarks>
        void RegisterAllParagraphIds(WordprocessingDocument wordDocument);
    }
}
