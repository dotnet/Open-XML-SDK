// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public partial class Document
    {
        private static readonly RNGCryptoServiceProvider Generator = new();

        /// <summary>
        /// Used to keep track of the existing and generated w14:paraId values.
        /// </summary>
        /// <remarks>
        /// TODO: Consider exposing a read-only view that could help users generate their own unique values.
        /// </remarks>
        internal readonly HashSet<string> ParagraphIds = new();

        /// <summary>
        /// Used to keep track of duplicate w14:paraId values that already existed
        /// in the Document.
        /// </summary>
        internal readonly HashSet<string> DuplicateParagraphIds = new();

        /// <summary>
        /// Gets the number of w14:paraId value collisions prevented.
        /// </summary>
        /// <remarks>
        /// TODO: Revisit.
        /// Potentially temporary property used to keep track of how many collisions
        /// were prevented by our explicit uniqueness check rather than the secure
        /// random number generator.
        /// </remarks>
        internal int PreventedParagraphIdCollisions { get; private set; }

        private protected override bool StrictTranslateAttribute(in OpenXmlQualifiedName qname, string? value)
        {
            if (string.Equals("conformance", qname.Name, StringComparison.Ordinal) &&
                string.Equals("strict", value, StringComparison.Ordinal))
            {
                return true;
            }

            return base.StrictTranslateAttribute(qname, value);
        }

        /// <summary>
        /// Registers an existing w14:paraId value to ensure the uniqueness of values
        /// generated later.
        /// </summary>
        /// <param name="value">The w14:paraId value.</param>
        /// <returns>true, if <paramref name="value" /> did not exist; false, otherwise.</returns>
        internal bool RegisterParagraphId(string value)
        {
            bool isAdded = ParagraphIds.Add(value.ToUpperInvariant());

            if (!isAdded)
            {
                DuplicateParagraphIds.Add(value);
            }

            return isAdded;
        }

        /// <summary>
        /// Registers an existing w14:paraId value to ensure the uniqueness of values
        /// generated later.
        /// </summary>
        /// <param name="value">The w14:paraId value.</param>
        /// <returns>true, if <paramref name="value" /> did not exist; false, otherwise.</returns>
        /// <exception cref="ArgumentException">If the HexBinaryValue`s InnerText property value is null.</exception>
        internal bool RegisterParagraphId(HexBinaryValue value)
        {
            if (value.InnerText is null)
            {
                throw new ArgumentException(@"Invalid HexBinaryValue: InnerText is null.", nameof(value));
            }

            return RegisterParagraphId(value.InnerText);
        }

        /// <summary>
        /// Creates a secure random w14:paraId value but neither checks whether
        /// the value is unique nor registers the value.
        /// </summary>
        /// <returns>A random w14:paraId value.</returns>
        internal static HexBinaryValue CreateRandomParagraphId()
        {
            // We create a four-byte secure random number, noting that the first byte
            // will become the most significant byte. Since we create non-zero bytes,
            // the value will be greater than zero. We further ensure the value is less
            // than 0x80000000 by masking the most significant byte.
            var bytes = new byte[4];
            Generator.GetNonZeroBytes(bytes);
            bytes[0] &= 0x7f;

            return HexBinaryValue.Create(bytes);
        }

        /// <summary>
        /// Creates a secure random w14:paraId value that is unique within this Document.
        /// </summary>
        /// <remarks>
        /// The previously existing w14:paraId values are registered when reading the DOM tree
        /// from the OpenXmlPart, using the RegisterParagraphId() methods.
        /// </remarks>
        /// <returns>A random and unique w14:paraId value.</returns>
        internal HexBinaryValue CreateUniqueParagraphId()
        {
            HexBinaryValue paragraphId = CreateRandomParagraphId();
            while (!ParagraphIds.Add(paragraphId.InnerText!))
            {
                PreventedParagraphIdCollisions++;
                paragraphId = CreateRandomParagraphId();
            }

            return paragraphId;
        }
    }
}
