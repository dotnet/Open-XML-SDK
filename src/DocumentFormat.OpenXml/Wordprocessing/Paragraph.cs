// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Paragraph
    {
        private Document? _document;

        /// <summary>
        /// Gets the <see cref="Document" />.
        /// </summary>
        /// <remarks>
        /// Lazily stores a reference to the part root element of type Document.
        /// Avoids having to traverse the parent hierarchy each time the
        /// TrySetFixedAttribute() method is called.
        /// When cloning the Paragraph instance, using CloneNode() or Clone(),
        /// the reference will not be retained.
        /// </remarks>
        internal Document? Document
        {
            get
            {
                _document ??= (Document?) GetPartRootElement();
                return _document;
            }
        }

        /// <summary>
        /// Attempts to set the attribute to a known attribute and registers any existing
        /// w14:paraId values with the root <see cref="Document" /> instance.
        /// </summary>
        /// <remarks>
        /// This is the Paragraph-specific implementation that registers the w14:paraId
        /// values when loading the DOM tree.
        /// The same method will have to be added to the TableRow class.
        /// </remarks>
        /// <param name="qname">The attribute's qualified name.</param>
        /// <param name="value">The attribute's value.</param>
        /// <param name="strictRelationshipFound"></param>
        /// <returns>true if the attribute is a known attribute.</returns>
        private protected override bool TrySetFixedAttribute(in OpenXmlQualifiedName qname, string? value, bool strictRelationshipFound)
        {
            if (RawState.Attributes.Any())
            {
                if (strictRelationshipFound)
                {
                    return StrictTranslateAttribute(qname, value);
                }

                AttributeCollection.AttributeEntry attribute = RawState.Attributes[qname];

                if (!attribute.IsNil)
                {
                    attribute.Value ??= attribute.Property.CreateNew();
                    attribute.Value.InnerText = value;

                    if (qname.Name == "paraId" && value is not null)
                    {
                        Document?.RegisterParagraphId(value);
                    }

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// For Paragraph instances that have already been added to the DOM tree,
        /// sets the <see cref="ParagraphId" /> to a random and unique value.
        /// </summary>
        /// <exception cref="InvalidOperationException">If the paragraph has not been added to a DOM tree.</exception>
        public void SetUniqueParagraphId()
        {
            Document? document = Document;

            if (document is null)
            {
                throw new InvalidOperationException("Paragraph must be added to the DOM tree before calling this method.");
            }

            ParsedState.Attributes.GetProperty(nameof(ParagraphId)).Value = document.CreateUniqueParagraphId();
        }

        /// <summary>
        /// For Paragraph instances that have not yet been added to the DOM tree,
        /// sets the <see cref="ParagraphId" /> to a random and unique value.
        /// </summary>
        /// <param name="document">The <see cref="Document" /> used to create the random and unique value.</param>
        /// <returns>This <see cref="Paragraph" /> instance.</returns>
        public Paragraph WithUniqueParagraphId(Document document)
        {
            ParsedState.Attributes.GetProperty(nameof(ParagraphId)).Value = document.CreateUniqueParagraphId();
            return this;
        }
    }
}
