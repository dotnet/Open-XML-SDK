// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// The base class for concrete <see cref="IParagraphIdGenerator" /> implementations.
    /// </summary>
    public abstract class ParagraphIdGenerator : IParagraphIdGenerator
    {
        /// <summary>
        /// Used to keep track of the existing and generated w14:paraId values.
        /// </summary>
        protected readonly HashSet<string> InternalRegisteredParagraphIds;

        /// <summary>
        /// Default constructor.
        /// </summary>
        protected ParagraphIdGenerator() : this(Enumerable.Empty<string>())
        {
        }

        /// <summary>
        /// Initializes a new instance with the w14:paraId (ParagraphId) values existing
        /// in the given <see cref="WordprocessingDocument" />.
        /// </summary>
        /// <param name="wordDocument">The <see cref="WordprocessingDocument" />.</param>
        protected ParagraphIdGenerator(WordprocessingDocument wordDocument) : this(GetAllParagraphIds(wordDocument))
        {
        }

        /// <summary>
        /// Initializes a new instance with a set of existing w14:paraId (ParagraphId)
        /// values that will not be produced by that new instance.
        /// </summary>
        /// <param name="paragraphIds">The collection of existing w14:paraId (ParagraphId) values.</param>
        protected ParagraphIdGenerator(IEnumerable<string> paragraphIds)
        {
            InternalRegisteredParagraphIds = new HashSet<string>(paragraphIds, StringComparer.OrdinalIgnoreCase);
        }

        /// <inheritdoc />
        public IEnumerable<string> RegisteredParagraphIds => InternalRegisteredParagraphIds;

        /// <inheritdoc />
        public string CreateUniqueParagraphId()
        {
            string paragraphId = CreateNextParagraphId();
            while (!InternalRegisteredParagraphIds.Add(paragraphId))
            {
                paragraphId = CreateNextParagraphId();
            }

            return paragraphId;
        }

        /// <summary>
        /// Creates a w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, but possibly not unique within the scope of this instance.
        /// </summary>
        /// <remarks>
        /// Implementations must ensure the strings are in uppercase.
        /// </remarks>
        /// <returns>
        /// A w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, but possibly not unique within the scope of this instance.
        /// </returns>
        protected abstract string CreateNextParagraphId();

        /// <inheritdoc />
        public void AssignUniqueParagraphIds(WordprocessingDocument wordDocument)
        {
            // Perform a first pass, registering all w14:paraId values.
            RegisterAllParagraphIds(wordDocument);

            // Perform a second pass, assigning new w14:paraId values where those values
            // are missing or not unique.
            var paragraphIds = new HashSet<string>();

            foreach (var openXmlPart in wordDocument.GetAllParts().Where(IsParagraphContainerPart))
            {
                var rootElement = openXmlPart.RootElement;
                if (rootElement is null)
                {
                    continue;
                }

                IEnumerable<IIdentifiableByParaId> elements = rootElement.Descendants().OfType<IIdentifiableByParaId>();
                foreach (var element in elements)
                {
                    var value = element.ParagraphId?.Value;
                    if (value is null || !paragraphIds.Add(value))
                    {
                        var paragraphId = CreateUniqueParagraphId();
                        element.ParagraphId = paragraphId;
                        paragraphIds.Add(paragraphId);
                    }
                }
            }
        }

        /// <inheritdoc />
        public void RegisterAllParagraphIds(WordprocessingDocument wordDocument)
        {
            foreach (var paragraphId in GetAllParagraphIds(wordDocument))
            {
                InternalRegisteredParagraphIds.Add(paragraphId);
            }
        }

        private static IEnumerable<string> GetAllParagraphIds(WordprocessingDocument wordDocument)
        {
            foreach (var openXmlPart in wordDocument.GetAllParts().Where(IsParagraphContainerPart))
            {
                var rootElement = openXmlPart.RootElement;
                if (rootElement is null)
                {
                    continue;
                }

                IEnumerable<IIdentifiableByParaId> elements = rootElement.Descendants().OfType<IIdentifiableByParaId>();
                foreach (var element in elements)
                {
                    var value = element.ParagraphId?.Value;
                    if (value is not null)
                    {
                        yield return value;
                    }
                }
            }
        }

        private static bool IsParagraphContainerPart(OpenXmlPart part)
        {
            return part is MainDocumentPart or
                WordprocessingCommentsPart or
                HeaderPart or
                FooterPart or
                FootnotesPart or
                EndnotesPart;
        }
    }
}
