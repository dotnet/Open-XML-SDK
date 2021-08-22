// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    /// <summary>
    /// The base class for concrete <see cref="IParagraphIdService" /> implementations.
    /// </summary>
    public abstract class ParagraphIdService : IParagraphIdService
    {
        /// <summary>
        /// Used to keep track of the existing and generated w14:paraId values.
        /// </summary>
        protected readonly HashSet<string> InternalRegisteredParagraphIds;

        /// <summary>
        /// Default constructor.
        /// </summary>
        protected ParagraphIdService()
        {
            InternalRegisteredParagraphIds = new HashSet<string>();
        }

        /// <summary>
        /// Initializes a new instance with a set of existing w14:paraId (ParagraphId)
        /// values that will not be produced by that new instance.
        /// </summary>
        /// <param name="paragraphIds">The collection of existing w14:paraId (ParagraphId) values.</param>
        protected ParagraphIdService(IEnumerable<string> paragraphIds)
        {
            InternalRegisteredParagraphIds = new HashSet<string>(paragraphIds.Select(id => id.ToUpperInvariant()));
        }

        /// <inheritdoc />
#if NET35 || NET40
        public ICollection<string> RegisteredParagraphIds => new ReadOnlyCollectionWrapper<string>(InternalRegisteredParagraphIds);
#else
        public IReadOnlyCollection<string> RegisteredParagraphIds => InternalRegisteredParagraphIds;
#endif

        /// <inheritdoc />
        public virtual bool RegisterParagraphId(string value)
        {
            return InternalRegisteredParagraphIds.Add(value.ToUpperInvariant());
        }

        /// <inheritdoc />
        public bool RegisterParagraphId(HexBinaryValue value)
        {
            return value.Value is not null && RegisterParagraphId(value.Value);
        }

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
        /// <returns>
        /// A w14:paraId (ParagraphId) value that is greater than 0x00000000, less than
        /// 0x80000000, but possibly not unique within the scope of this instance.
        /// </returns>
        protected abstract string CreateNextParagraphId();
    }
}
