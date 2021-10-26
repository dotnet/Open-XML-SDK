// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    internal class WordDocumentParagraphIdCollectionFeature : IParagraphIdCollectionFeature, IDisposable
    {
        private readonly Dictionary<OpenXmlPart, HashSet<string>> _parts = new();
        private readonly WordprocessingDocument _doc;
        private readonly ParagraphIdOptions _options;
        private readonly IPartEventsFeature _partEvents;
        private readonly IElementEventFeature _elementEvents;

        public WordDocumentParagraphIdCollectionFeature(
            WordprocessingDocument doc,
            ParagraphIdOptions options,
            IPartEventsFeature partEvents,
            IElementEventFeature elementEvents)
        {
            _doc = doc;
            _options = options;

            _partEvents = partEvents;
            _elementEvents = elementEvents;
        }

        internal void Initialize()
        {
            Register(_doc);
            RegisterEvents();
        }

        public bool Contains(string paraId)
        {
            foreach (var part in _parts)
            {
                if (part.Value.Contains(paraId))
                {
                    return true;
                }
            }

            return false;
        }

        public int Count
        {
            get
            {
                var count = 0;

                foreach (var names in _parts.Values)
                {
                    count += names.Count;
                }

                return count;
            }
        }

        private void RegisterEvents()
        {
            _elementEvents.Change += ElementsChange;
            _partEvents.Change += PartEventsChange;
        }

        private void UnregisterEvents()
        {
            _elementEvents.Change -= ElementsChange;
            _partEvents.Change -= PartEventsChange;
        }

        private void ElementsChange(FeatureEventArgs<PartElementEventArgs> obj)
        {
            if (obj.Type == EventType.Removed)
            {
                if (obj.Argument.Element.TryGetParagraphId(out var paraId) && paraId is not null && _parts.TryGetValue(obj.Argument.Part, out var set))
                {
                    set.Remove(paraId);
                }
            }
            else if (obj.Type == EventType.Reloading || obj.Type == EventType.Adding)
            {
                if (IsParagraphContainerPart(obj.Argument.Part))
                {
                    Register(obj.Argument.Part, obj.Argument.Element);
                }
            }
        }

        private void PartEventsChange(FeatureEventArgs<OpenXmlPart> obj)
        {
            if (obj.Type == EventType.Removed)
            {
                _parts.Remove(obj.Argument);
            }
        }

        private void Register(WordprocessingDocument wordDocument)
        {
            foreach (var part in wordDocument.GetAllParts())
            {
                Register(part);
            }
        }

        private void Register(OpenXmlPart openXmlPart)
        {
            if (!IsParagraphContainerPart(openXmlPart))
            {
                return;
            }

            var rootElement = openXmlPart.RootElement;
            if (rootElement is null)
            {
                return;
            }

            foreach (var element in rootElement.Descendants())
            {
                Register(openXmlPart, element);
            }
        }

        private void Register(OpenXmlPart part, OpenXmlElement element)
        {
            if (element.TryGetParagraphId(out var paraId))
            {
                if (paraId is not null)
                {
                    var collection = _doc.Features.GetRequired<IParagraphIdCollectionFeature>();

                    if (_options.EnsureUniquenessOnExistingNodes && collection.Contains(paraId))
                    {
                        var generator = _doc.Features.GetRequired<IParagraphIdGeneratorFeature>();

                        paraId = generator.CreateUniqueParagraphId();
                        element.SetParagraphId(paraId);
                    }

                    Add(part, paraId);
                }
                else if (_options.AutoGenerateIds)
                {
                    var generator = _doc.Features.GetRequired<IParagraphIdGeneratorFeature>();

                    paraId = generator.CreateUniqueParagraphId();
                    element.SetParagraphId(paraId);

                    Add(part, paraId);
                }
            }
        }

        private void Add(OpenXmlPart part, string paraId)
        {
            if (!_parts.TryGetValue(part, out var set))
            {
                set = new(ParagraphIdCollectionFeature.Comparer);
                _parts[part] = set;
            }

            set.Add(paraId);
        }

        private static bool IsParagraphContainerPart(OpenXmlPart part)
        {
            return part is MainDocumentPart or
                WordprocessingCommentsPart or
                HeaderPart or
                FooterPart or
                FootnotesPart or
                EndnotesPart;
        }

        public void Dispose()
        {
            UnregisterEvents();
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var part in _parts)
            {
                foreach (var paraId in part.Value)
                {
                    yield return paraId;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
