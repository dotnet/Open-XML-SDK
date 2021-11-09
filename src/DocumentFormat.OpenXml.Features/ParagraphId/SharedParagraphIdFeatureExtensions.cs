// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    /// <summary>
    /// A collection of extensions that will add support for shared <see cref="IParagraphIdCollectionFeature"/> instances among multiple documents.
    /// </summary>
    public static class SharedParagraphIdFeatureExtensions
    {
        /// <summary>
        /// Registers a document for a shared paragraph id collection.
        /// </summary>
        /// <param name="doc">Document to register for a shared collection.</param>
        /// <returns>The existing or new shared collection.</returns>
        public static ISharedFeature<IParagraphIdCollectionFeature> AddSharedParagraphIdFeature(this WordprocessingDocument doc)
        {
            var existingShared = doc.Features.Get<ISharedFeature<IParagraphIdCollectionFeature>>();

            if (existingShared is not null)
            {
                return existingShared;
            }

            doc.AddParagraphIdFeature();

            var sharedFeature = new SharedParagraphIdCollectionFeature
            {
                doc.Features.GetRequired<IParagraphIdCollectionFeature>(),
            };

            doc.Features.Set<IParagraphIdCollectionFeature>(sharedFeature);
            doc.Features.Set<ISharedFeature<IParagraphIdCollectionFeature>>(sharedFeature);

            return sharedFeature;
        }

        /// <summary>
        /// Registers a document to use a shared paragragraph collection, which potentially may ensure uniqueness among many documents.
        /// </summary>
        /// <param name="shared">Shared collection feature.</param>
        /// <param name="doc">Document to register with shared paragraph collection.</param>
        /// <returns></returns>
        public static ISharedFeature<IParagraphIdCollectionFeature> Add(this ISharedFeature<IParagraphIdCollectionFeature> shared, WordprocessingDocument doc)
        {
            doc.AddPackageEventsFeature();
            doc.AddParagraphIdFeature();

            var paragraphIdCollection = doc.Features.GetRequired<IParagraphIdCollectionFeature>();
            shared.Add(paragraphIdCollection);
            doc.Features.SetDisposable(new ParagraphIdSnapshotGenerator(paragraphIdCollection, shared, doc.Features.GetRequired<IPackageEventsFeature>()));
            doc.Features.Set(shared);
            doc.Features.Set(shared.Composite);

            return shared;
        }

        /// <summary>
        /// Add arbitrary values to be tracked as a shared collection.
        /// </summary>
        /// <param name="shared">Shared collection feature.</param>
        /// <param name="paragraphIds">Paragraph ids to be included with the shared collection.</param>
        /// <returns></returns>
        public static ISharedFeature<IParagraphIdCollectionFeature> Add(this ISharedFeature<IParagraphIdCollectionFeature> shared, IEnumerable<string> paragraphIds)
        {
            shared.Add(new ParagraphIdCollectionFeature(paragraphIds));
            return shared;
        }

        internal class SharedParagraphIdCollectionFeature : IParagraphIdCollectionFeature, ISharedFeature<IParagraphIdCollectionFeature>
        {
            private readonly List<IParagraphIdCollectionFeature> _others = new();

            public void Add(IParagraphIdCollectionFeature other)
            {
                _others.Add(other);
            }

            public int Count
            {
                get
                {
                    var count = 0;

                    foreach (var other in _others)
                    {
                        count += other.Count;
                    }

                    return count;
                }
            }

            public IParagraphIdCollectionFeature Composite => this;

            public bool Contains(string id)
            {
                foreach (var other in _others)
                {
                    if (other.Contains(id))
                    {
                        return true;
                    }
                }

                return false;
            }

            public bool Remove(IParagraphIdCollectionFeature collection)
                => _others.Remove(collection);

            public IEnumerator<string> GetEnumerator()
            {
                foreach (var other in _others)
                {
                    foreach (var item in other)
                    {
                        yield return item;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        private sealed class ParagraphIdSnapshotGenerator : IDisposable
        {
            private readonly IParagraphIdCollectionFeature _collection;
            private readonly ISharedFeature<IParagraphIdCollectionFeature> _shared;
            private readonly IPackageEventsFeature _events;

            public ParagraphIdSnapshotGenerator(
                IParagraphIdCollectionFeature collection,
                ISharedFeature<IParagraphIdCollectionFeature> shared,
                IPackageEventsFeature packageEvents)
            {
                _collection = collection;
                _shared = shared;
                _events = packageEvents;

                _events.Change += PackageChangeEvent;
            }

            private void PackageChangeEvent(FeatureEventArgs<OpenXmlPackage> obj)
            {
                if (obj.Type == EventType.Closing)
                {
                    if (_shared.Remove(_collection))
                    {
                        _shared.Add(new ParagraphIdCollectionFeature(_collection));
                    }
                }
            }

            public void Dispose()
            {
                _events.Change -= PackageChangeEvent;
            }
        }
    }
}
