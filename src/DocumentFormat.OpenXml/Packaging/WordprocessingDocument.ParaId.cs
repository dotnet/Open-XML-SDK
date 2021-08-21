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
        public ICollection<string> ParagraphIds => ParagraphIdService.ParagraphIds;
#else
        public IReadOnlyCollection<string> ParagraphIds => ParagraphIdService.ParagraphIds;
#endif

        /// <inheritdoc />
#if NET35 || NET40
        public ICollection<string> DuplicateParagraphIds => ParagraphIdService.DuplicateParagraphIds;
#else
        public IReadOnlyCollection<string> DuplicateParagraphIds => ParagraphIdService.DuplicateParagraphIds;
#endif

        /// <inheritdoc />
        public bool RegisterParagraphId(string value) => ParagraphIdService.RegisterParagraphId(value);

        /// <inheritdoc />
        public bool RegisterParagraphId(HexBinaryValue value) => ParagraphIdService.RegisterParagraphId(value);

        /// <inheritdoc />
        public string CreateUniqueParagraphId() => ParagraphIdService.CreateUniqueParagraphId();

        /// <summary>
        /// Gets the w14:paraId (ParagraphId) values existing in this <see cref="WordprocessingDocument"/>.
        /// </summary>
        /// <remarks>
        /// This method ensures all w14:paraId (ParagraphId) values are registered by loading
        /// all relevant part root elements as necessary.
        /// This method can be used to ensure uniqueness of w14:paraId (ParagraphId) values
        /// across all parts that can contain w:p (Paragraph) and w:tr (TableRow) elements.
        /// </remarks>
        /// <returns>
        /// The w14:paraId (ParagraphId) values existing in this <see cref="WordprocessingDocument"/>.
        /// </returns>
#if NET35 || NET40
        public ICollection<string> GetAllParagraphIds()
#else
        public IReadOnlyCollection<string> GetAllParagraphIds()
#endif
        {
            foreach (var openXmlPart in this.GetAllParts().Where(IsParagraphContainerPart))
            {
                OpenXmlPartRootElement? unused = openXmlPart.RootElement;
            }

            return ParagraphIds;
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
