// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Features;
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
        /// Gets a <see cref="IParagraphIdFeature"/> for the supplied document. If not already created, this will create one and return it.
        /// </summary>
        /// <param name="doc">Document to get feature from.</param>
        /// <returns>Current or new <see cref="IParagraphIdFeature"/>.</returns>
        public static IParagraphIdFeature GetParagraphIdFeature(this WordprocessingDocument doc)
        {
            doc.TryAddParagraphIdFeature();

            return doc.Features.GetRequired<IParagraphIdFeature>();
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

            if (doc.Features.Get<IParagraphIdFeature>() is null)
            {
                doc.TryAddRandomNumberGeneratorFeature();
                doc.TryAddPartEventsFeature();
                doc.TryAddElementEventFeature();

                var randomNumber = doc.Features.GetRequired<IRandomNumberGeneratorFeature>();
                IParagraphIdFeature feature = options switch
                {
                    { TrackDocument: false } => new UniqueParagraphIdFeature(randomNumber),
                    _ => new WordDocumentParagraphIdFeature(doc, options, randomNumber, doc.Features.GetRequired<IPartEventsFeature>(), doc.Features.GetRequired<IElementEventFeature>()),
                };

                doc.Features.SetDisposable(feature);

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
