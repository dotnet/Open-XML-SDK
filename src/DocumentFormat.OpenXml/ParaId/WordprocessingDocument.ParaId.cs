// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    public partial class WordprocessingDocument
    {
        private ParagraphIdGenerator? _paragraphIdGenerator;

        /// <summary>
        /// Gets the <see cref="IParagraphIdGenerator" /> used to generate unique
        /// w14:paraId (ParagraphId) values.
        /// </summary>
        public IParagraphIdGenerator ParagraphIdGenerator => _paragraphIdGenerator ??= new RandomParagraphIdGenerator();

        /// <summary>
        /// Gets the registered w14:paraId (ParagraphId) values.
        /// </summary>
        /// <remarks>
        /// To ensure all existing w14:paraId (ParagraphId) values are registered,
        /// call <see cref="RegisterAllParagraphIds"/>.
        /// </remarks>
        public IEnumerable<string> RegisteredParagraphIds => ParagraphIdGenerator.RegisteredParagraphIds;

        /// <summary>
        /// Assigns unique w14:paraId (ParagraphId) values to w:p (Paragraph) and w:tr (TableRow)
        /// elements where those elements do not have a w14:paraId value or such values are not
        /// unique within this <see cref="WordprocessingDocument" />.
        /// </summary>
        public IEnumerable<string> AssignUniqueParagraphIds()
        {
            // Perform a first pass, registering all w14:paraId values.
            RegisterAllParagraphIds();

            // Perform a second pass, assigning new w14:paraId values where those values
            // are missing or not unique.
            var paragraphIds = new HashSet<string>();

            foreach (var openXmlPart in this.GetAllParts().Where(IsParagraphContainerPart))
            {
                var rootElement = openXmlPart.RootElement;
                if (rootElement is null)
                {
                    continue;
                }

                IEnumerable<IParagraphIdHolder> paraIdHolders = rootElement.Descendants().OfType<IParagraphIdHolder>();
                foreach (var paraIdHolder in paraIdHolders)
                {
                    var value = paraIdHolder.ParagraphId?.Value;
                    if (value is null || !paragraphIds.Add(value))
                    {
                        paragraphIds.Add(paraIdHolder.SetUniqueParagraphId());
                    }
                }
            }

            return RegisteredParagraphIds;
        }

        /// <summary>
        /// Registers all w14:paraId (ParagraphId) values existing in this <see cref="WordprocessingDocument" />.
        /// </summary>
        /// <remarks>
        /// This method ensures all w14:paraId (ParagraphId) values are registered by loading
        /// all relevant part root elements and reading all w:p and w:tr descendents of such
        /// part root elements.
        /// This method can be used to ensure uniqueness of w14:paraId (ParagraphId) values
        /// across all parts that can contain w:p (Paragraph) and w:tr (TableRow) elements
        /// by first registering all w14:paraId (ParagraphId) values and only then generating
        /// new values.
        /// </remarks>
        public IEnumerable<string> RegisterAllParagraphIds()
        {
            foreach (var openXmlPart in this.GetAllParts().Where(IsParagraphContainerPart))
            {
                var rootElement = openXmlPart.RootElement;
                if (rootElement is null)
                {
                    continue;
                }

                IEnumerable<IParagraphIdHolder> paraIdHolders = rootElement.Descendants().OfType<IParagraphIdHolder>();
                foreach (var paraIdHolder in paraIdHolders)
                {
                    var value = paraIdHolder.ParagraphId?.Value;
                    if (value is not null)
                    {
                        ParagraphIdGenerator.RegisterParagraphId(value);
                    }
                }
            }

            return RegisteredParagraphIds;
        }

        private static bool IsParagraphContainerPart(OpenXmlPart part)
        {
            return part is Packaging.MainDocumentPart or
                WordprocessingCommentsPart or
                HeaderPart or
                FooterPart or
                FootnotesPart or
                EndnotesPart;
        }
    }
}
