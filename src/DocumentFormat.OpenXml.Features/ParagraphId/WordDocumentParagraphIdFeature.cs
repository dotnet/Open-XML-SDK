// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Features
{
    internal class WordDocumentParagraphIdFeature : IParagraphIdFeature, IDisposable
    {
        private readonly Dictionary<OpenXmlPart, HashSet<string>> _parts = new();
        private readonly ParagraphIdOptions _options;
        private readonly IPartEventsFeature _partEvents;
        private readonly IElementEventFeature _elementEvents;
        private readonly UniqueParagraphIdFeature _other;

        public WordDocumentParagraphIdFeature(
            WordprocessingDocument doc,
            ParagraphIdOptions options,
            IRandomNumberGeneratorFeature randomNumber,
            IPartEventsFeature partEvents,
            IElementEventFeature elementEvents)
        {
            _other = new UniqueParagraphIdFeature(randomNumber);
            _options = options;

            Register(doc);

            _partEvents = partEvents;
            _elementEvents = elementEvents;

            RegisterEvents();
        }

        string IParagraphIdFeature.CreateUniqueParagraphId() => _other.CreateUniqueParagraphId(Contains, true);

        public string CreateUniqueParagraphId() => _other.CreateUniqueParagraphId(Contains, false);

        public IEnumerable<string> RegisteredParagraphIds
        {
            get
            {
                foreach (var other in _other.RegisteredParagraphIds)
                {
                    yield return other;
                }

                foreach (var part in _parts)
                {
                    foreach (var paraId in part.Value)
                    {
                        yield return paraId;
                    }
                }
            }
        }

        public bool Contains(string paraId)
        {
            if (_other.Contains(paraId))
            {
                return true;
            }

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

                foreach (var parts in _parts)
                {
                    count += parts.Value.Count;
                }

                return _other.Count + count;
            }
        }

        private void RegisterEvents()
        {
            _elementEvents.Change += ElementsChange;
            _partEvents.Change += PartEventsChange;
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

        private void UnregisterEvents()
        {
            _elementEvents.Change -= ElementsChange;
            _partEvents.Change -= PartEventsChange;
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
                    if (_options.EnsureUniquenessOnExistingNodes && Contains(paraId))
                    {
                        paraId = CreateUniqueParagraphId();
                        element.SetParagraphId(paraId);
                    }

                    Add(part, paraId);
                }
                else if (_options.AutoGenerateIds)
                {
                    paraId = CreateUniqueParagraphId();
                    element.SetParagraphId(paraId);

                    Add(part, paraId);
                }
            }
        }

        private void Add(OpenXmlPart part, string paraId)
        {
            if (!_parts.TryGetValue(part, out var set))
            {
                set = new();
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
    }
}
