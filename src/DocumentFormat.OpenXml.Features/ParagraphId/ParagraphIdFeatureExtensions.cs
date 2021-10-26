// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// Extensions to add paragraph id generation to a document
    /// </summary>
    public static class ParagraphIdFeatureExtensions
    {
        /// <summary>
        /// Gets a <see cref="IParagraphIdCollectionFeature"/> for the supplied document. If not already created, this will create one and return it.
        /// </summary>
        /// <param name="doc">Document to get feature from.</param>
        /// <returns>Current or new <see cref="IParagraphIdCollectionFeature"/>.</returns>
        public static IParagraphIdCollectionFeature GetParagraphIdCollectionFeature(this WordprocessingDocument doc)
        {
            doc.TryAddParagraphIdFeature();

            return doc.Features.GetRequired<IParagraphIdCollectionFeature>();
        }

        /// <summary>
        /// Add the paragraph id feature if not already registered.
        /// </summary>
        /// <param name="doc">Document to add feature to.</param>
        /// <param name="options">Options of how paragraph ids should be generated.</param>
        /// <returns>True if feature was added.</returns>
        public static bool TryAddParagraphIdFeature(this WordprocessingDocument doc, ParagraphIdOptions? options = default)
        {
            options ??= new();

            doc.TryAddParagraphIdGeneratorFeature();

            if (doc.Features.Get<IParagraphIdCollectionFeature>() is null)
            {
                doc.TryAddPartEventsFeature();
                doc.TryAddElementEventFeature();

                var feature = new WordDocumentParagraphIdCollectionFeature(
                    doc,
                    options,
                    doc.Features.GetRequired<IPartEventsFeature>(),
                    doc.Features.GetRequired<IElementEventFeature>());

                doc.Features.SetDisposable<IParagraphIdCollectionFeature>(feature);

                feature.Initialize();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Adds a <see cref="IParagraphIdGeneratorFeature"/> if not already available.
        /// </summary>
        /// <param name="doc">Document to add generator to.</param>
        /// <returns>True if feature was added.</returns>
        public static bool TryAddParagraphIdGeneratorFeature(this WordprocessingDocument doc)
        {
            if (doc.Features.Get<IParagraphIdGeneratorFeature>() is null)
            {
                doc.TryAddRandomNumberGeneratorFeature();
                doc.Features.Set<IParagraphIdGeneratorFeature>(new ParagraphIdGeneratorFeature(doc.Features, doc.Features.GetRequired<IRandomNumberGeneratorFeature>()));

                return true;
            }

            return false;
        }

        internal static bool TryGetParagraphId(this OpenXmlElement element, out string? paraId)
        {
            if (element is Paragraph p)
            {
                paraId = p.ParagraphId;
                return true;
            }
            else if (element is TableRow row)
            {
                paraId = row.ParagraphId;
                return true;
            }

            paraId = null;
            return false;
        }

        internal static void SetParagraphId(this OpenXmlElement element, string paraId)
        {
            if (element is Paragraph p)
            {
                p.ParagraphId = paraId;
            }
            else if (element is TableRow row)
            {
                row.ParagraphId = paraId;
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
