// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// A concrete implementation of the <see cref="IParagraphIdGenerator" />, which
    /// creates secure random w14:paraId (ParagraphId) values.
    /// </summary>
    public class RandomParagraphIdGenerator : ParagraphIdGenerator
    {
        private static readonly RandomNumberGenerator Generator = RandomNumberGenerator.Create();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public RandomParagraphIdGenerator() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance with the w14:paraId (ParagraphId) values existing
        /// in the given <see cref="WordprocessingDocument" />.
        /// </summary>
        /// <param name="wordDocument">The <see cref="WordprocessingDocument" />.</param>
        public RandomParagraphIdGenerator(WordprocessingDocument wordDocument) : base(wordDocument)
        {
        }

        /// <summary>
        /// Initializes a new instance with a set of existing w14:paraId (ParagraphId)
        /// values that will not be produced by that instance.
        /// </summary>
        /// <param name="paragraphIds">The collection of existing w14:paraId (ParagraphId) values.</param>
        public RandomParagraphIdGenerator(IEnumerable<string> paragraphIds) : base(paragraphIds)
        {
        }

        /// <inheritdoc />
        protected override string CreateNextParagraphId()
        {
            var bytes = new byte[] { 0x00, 0x00, 0x00, 0x00 };

            do
            {
                Generator.GetBytes(bytes);
            } while (bytes[0] >= 0x80 || bytes[0] == 0 && bytes[1] == 0 && bytes[2] == 0 && bytes[3] == 0);

            return HexStringFactory.Create(bytes);
        }
    }
}
