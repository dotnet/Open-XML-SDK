// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    public partial class WordprocessingDocument : IParagraphIdService
    {
        private IParagraphIdService? _paragraphIdService;

        private IParagraphIdService ParagraphIdService => _paragraphIdService ??= new RandomParagraphIdService();

        /// <inheritdoc />
#if NET35 || NET40
        public ICollection<string> RegisteredParagraphIds => ParagraphIdService.RegisteredParagraphIds;
#else
        public IReadOnlyCollection<string> RegisteredParagraphIds => ParagraphIdService.RegisteredParagraphIds;
#endif

        /// <inheritdoc />
        public bool RegisterParagraphId(string value) => ParagraphIdService.RegisterParagraphId(value);

        /// <inheritdoc />
        public bool RegisterParagraphId(HexBinaryValue value) => ParagraphIdService.RegisterParagraphId(value);

        /// <inheritdoc />
        public string CreateUniqueParagraphId() => ParagraphIdService.CreateUniqueParagraphId();

        /// <summary>
        /// Assigns unique w14:paraId (ParagraphId) values to w:p (Paragraph) and w:tr (TableRow)
        /// elements where those elements do not have a w14:paraId value or such values are not
        /// unique within this <see cref="WordprocessingDocument" />.
        /// </summary>
#if NET35 || NET40
        public ICollection<string> AssignUniqueParagraphIds()
#else
        public IReadOnlyCollection<string> AssignUniqueParagraphIds()
#endif
        {
            // Perform a first pass, registering all w14:paraId values.
            RegisterAllParagraphIds();

            // Perform a second pass, assigning new w14:paraId values where those values
            // are missing or not unique.
            var paragraphIds = new HashSet<string>();

            foreach (var openXmlPart in this.GetAllParts().Where(IsParagraphContainerPart))
            {
                OpenXmlPartRootElement? rootElement = openXmlPart.RootElement;
                if (rootElement is null)
                {
                    continue;
                }

                IEnumerable<IParagraphIdHolder> paraIdHolders = rootElement.Descendants().OfType<IParagraphIdHolder>();
                foreach (var paraIdHolder in paraIdHolders)
                {
                    string? value = paraIdHolder.ParagraphId?.Value;
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
#if NET35 || NET40
        public ICollection<string> RegisterAllParagraphIds()
#else
        public IReadOnlyCollection<string> RegisterAllParagraphIds()
#endif
        {
            foreach (var openXmlPart in this.GetAllParts().Where(IsParagraphContainerPart))
            {
                OpenXmlPartRootElement? rootElement = openXmlPart.RootElement;
                if (rootElement is null)
                {
                    continue;
                }

                IEnumerable<IParagraphIdHolder> paraIdHolders = rootElement.Descendants().OfType<IParagraphIdHolder>();
                foreach (var paraIdHolder in paraIdHolders)
                {
                    string? value = paraIdHolder.ParagraphId?.Value;
                    if (value is not null)
                    {
                        RegisterParagraphId(value);
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
