// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Runtime.CompilerServices;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Paragraph : IParagraphIdHolder
    {
        private WordprocessingDocument? _wordprocessingDocument;

        /// <summary>
        /// Gets the <see cref="WordprocessingDocument" /> in which this <see cref="Paragraph"/>
        /// is ultimately contained (e.g., in the <see cref="MainDocumentPart" /> or other parts
        /// that can contain <see cref="Paragraph" /> instances.
        /// </summary>
        /// <remarks>
        /// Lazily stores a reference to the <see cref="WordprocessingDocument"/>.
        /// Avoids having to traverse the parent hierarchy each time the
        /// TrySetFixedAttribute() method is called. When cloning the Paragraph
        /// instance, using CloneNode() or Clone(), the reference will not be
        /// retained.
        /// The <see cref="WordprocessingDocument" /> class implements the
        /// <see cref="IParagraphIdGenerator" /> interface, which we need to create
        /// unique w14:paraId (ParagraphId) values. We could have stored a reference
        /// to a <see cref="IParagraphIdGenerator" /> instance. However, storing the
        /// <see cref="WordprocessingDocument" /> reference might be useful for
        /// future enhancements.
        /// </remarks>
        internal WordprocessingDocument? WordprocessingDocument
        {
            get
            {
                if (_wordprocessingDocument == null)
                {
                    var partRootElement = GetPartRootElement();
                    _wordprocessingDocument = partRootElement?.OpenXmlPart?.OpenXmlPackage as WordprocessingDocument;
                }

                return _wordprocessingDocument;
            }
        }

        /// <summary>
        /// Sets named property's value, registering w14:paraId values.
        /// </summary>
        /// <typeparam name="TSimpleType">The property type.</typeparam>
        /// <param name="value">The property value.</param>
        /// <param name="propertyName">The property name.</param>
        private protected override void SetAttribute<TSimpleType>(TSimpleType? value, [CallerMemberName] string propertyName = null!)
            where TSimpleType : class
        {
            if (propertyName is nameof(ParagraphId) && value is HexBinaryValue hexBinaryValue)
            {
                // TODO: Discuss how we want to deal with duplicate w14:paraId values assigned by the caller.
                // The RegisterParagraphId() method returns true if the hexBinaryValue was unique and false otherwise.
                // Therefore, if desired (e.g., always or based on settings), we could throw an exception.
                WordprocessingDocument?.ParagraphIdGenerator.RegisterParagraphId(hexBinaryValue);
            }

            base.SetAttribute(value, propertyName);
        }

        /// <summary>
        /// Attempts to set the attribute to a known attribute and registers any existing
        /// w14:paraId values with the <see cref="WordprocessingDocument" /> instance.
        /// </summary>
        /// <remarks>
        /// This is the Paragraph-specific implementation that registers the w14:paraId
        /// values when loading the DOM tree.
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

                var attribute = RawState.Attributes[qname];

                if (!attribute.IsNil)
                {
                    attribute.Value ??= attribute.Property.CreateNew();
                    attribute.Value.InnerText = value;

                    if (qname.Name == "paraId" && value is not null)
                    {
                        WordprocessingDocument?.ParagraphIdGenerator.RegisterParagraphId(value);
                    }

                    return true;
                }
            }

            return false;
        }

        /// <inheritdoc />
        public string SetUniqueParagraphId()
        {
            var wordprocessingDocument = WordprocessingDocument;
            if (wordprocessingDocument is null)
            {
                throw new InvalidOperationException("Paragraph must be added to the DOM tree before calling this method.");
            }

            return SetUniqueParagraphId(wordprocessingDocument.ParagraphIdGenerator);
        }

        /// <inheritdoc />
        public string SetUniqueParagraphId(IParagraphIdGenerator paragraphIdGenerator)
        {
            string paragraphId = paragraphIdGenerator.CreateUniqueParagraphId();
            ParsedState.Attributes.GetProperty(nameof(ParagraphId)).Value = new HexBinaryValue(paragraphId);
            return paragraphId;
        }
    }
}
