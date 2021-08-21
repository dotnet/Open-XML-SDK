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
        protected readonly HashSet<string> InternalParagraphIds;

        /// <summary>
        /// Used to keep track of duplicate w14:paraId values that already existed
        /// in the scope of this instance.
        /// </summary>
        protected readonly HashSet<string> InternalDuplicateParagraphIds;

        /// <summary>
        /// Default constructor.
        /// </summary>
        protected ParagraphIdService()
        {
            InternalParagraphIds = new HashSet<string>();
            InternalDuplicateParagraphIds = new HashSet<string>();
        }

        /// <summary>
        /// Initializes a new instance with a set of existing w14:paraId (ParagraphId)
        /// values that will not be produced by that instance.
        /// </summary>
        /// <param name="paragraphIds">The collection of existing w14:paraId (ParagraphId) values.</param>
        protected ParagraphIdService(IEnumerable<string> paragraphIds)
        {
            InternalParagraphIds = new HashSet<string>(paragraphIds.Select(id => id.ToUpperInvariant()));
            InternalDuplicateParagraphIds = new HashSet<string>();
        }

        /// <inheritdoc />
#if NET35 || NET40
        public ICollection<string> ParagraphIds => InternalParagraphIds;
#else
        public IReadOnlyCollection<string> ParagraphIds => InternalParagraphIds;
#endif

        /// <inheritdoc />
#if NET35 || NET40
        public ICollection<string> DuplicateParagraphIds => InternalDuplicateParagraphIds;
#else
        public IReadOnlyCollection<string> DuplicateParagraphIds => InternalDuplicateParagraphIds;
#endif

        /// <inheritdoc />
        public virtual bool RegisterParagraphId(string value)
        {
            bool isAdded = InternalParagraphIds.Add(value.ToUpperInvariant());

            if (!isAdded)
            {
                InternalDuplicateParagraphIds.Add(value);
            }

            return isAdded;
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
            while (!InternalParagraphIds.Add(paragraphId))
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
